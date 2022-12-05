namespace TestCases.BankTransactions
{
    public class BankTransactionsTests : TestBase
    {
        [Fact]
        public async Task UserCanDepositMoneyIntoExistingAccountTest()
        {
            await AccountKeywords.CreateAccount();
            Guid accountNumber = (await AccountKeywords.GetAvailableAccounts()).First().AccountNumber;

            HttpResponseMessage response = await TransactionKeywords.Deposit(accountNumber, TestData.defaultAmount);

            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task UserCanNotDepositMoneyIntoNotExistingAccountTest()
        {
            Guid accountNumber = new Guid();

            HttpResponseMessage response = await TransactionKeywords.Deposit(accountNumber, TestData.defaultAmount);

            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Fact]
        public async Task UserCanWithdrawMoneyFromExistingAccountTest()
        {
            await AccountKeywords.CreateAccount();
            Guid accountNumber = (await AccountKeywords.GetAvailableAccounts()).First().AccountNumber;
            await TransactionKeywords.Deposit(accountNumber, TestData.defaultAmount);

            HttpResponseMessage response = await TransactionKeywords.Withdraw(accountNumber, TestData.defaultAmount/2);

            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task UserCanNotWithdrawMoneyFromNotExistingAccountTest()
        {
            await AccountKeywords.CreateAccount();
            Guid accountNumber = new Guid();

            HttpResponseMessage response = await TransactionKeywords.Deposit(accountNumber, TestData.defaultAmount);

            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Theory]
        [InlineData(9999, HttpStatusCode.OK)]
        [InlineData(10000, HttpStatusCode.OK)]
        [InlineData(10001, HttpStatusCode.UnprocessableEntity)]
        public async Task ValidateDepositLimitationsTests(int amount, HttpStatusCode expectedStatusCode)
        {
            await AccountKeywords.CreateAccount();
            Guid accountNumber = (await AccountKeywords.GetAvailableAccounts()).First().AccountNumber;

            HttpResponseMessage response = await TransactionKeywords.Deposit(accountNumber, amount);

            response.StatusCode.Should().Be(expectedStatusCode);
        }

        [Theory]
        [InlineData(899 ,HttpStatusCode.OK)]
        [InlineData(900, HttpStatusCode.OK)]
        [InlineData(901, HttpStatusCode.UnprocessableEntity)]
        public async Task ValidateWithdrawLimitationsTests(int amount, HttpStatusCode expectedStatusCode)
        {
            await AccountKeywords.CreateAccount();
            Guid accountNumber = (await AccountKeywords.GetAvailableAccounts()).First().AccountNumber;
            await TransactionKeywords.Deposit(accountNumber, TestData.defaultAmount);

            HttpResponseMessage response = await TransactionKeywords.Withdraw(accountNumber, amount);

            response.StatusCode.Should().Be(expectedStatusCode);
        }
    }
}