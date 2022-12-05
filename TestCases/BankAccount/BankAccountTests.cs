namespace TestCases.BankAccount
{
    public class BankAccountTests : TestBaseProvider
    {
        [Fact]
        public async Task UserCanCreateAccountTest()
        {
            Account account = new Account
            {
                AccountNumber = new Guid(),
                AvailableAmount = 100
            };

            HttpResponseMessage response = await AccountKeywords.CreateAccount(account);

            response.StatusCode.Should().Be(HttpStatusCode.Created);
        }

        [Fact]
        public async Task UserCanCreateMultipleAccountsTest()
        {
            Account accountOne = new Account
            {
                AccountNumber = new Guid(),
                AvailableAmount = 100
            };

            Account accountTwo = new Account
            {
                AccountNumber = new Guid(),
                AvailableAmount = 100
            };

            await AccountKeywords.CreateAccount(accountOne);

            HttpResponseMessage response = await AccountKeywords.CreateAccount(accountTwo);

            response.StatusCode.Should().Be(HttpStatusCode.Created);
        }

        [Fact]
        public async Task UserCanDeleteExistingAccountTest()
        {
            await AccountKeywords.CreateAccount();
            Guid accountNumber = (await AccountKeywords.GetAvailableAccounts()).First().AccountNumber;

            List<Account> accounts = await AccountKeywords.GetAvailableAccounts();
            Account account = accounts.First();
            HttpResponseMessage response = await AccountKeywords.DeleteAccount(accountNumber);

            response.StatusCode.Should().Be(HttpStatusCode.NoContent);
        }

        [Fact]
        public async Task UserCanNotDeleteNonExistingAccountTest()
        {
            Guid fakeGuid = new Guid();

            HttpResponseMessage response = await AccountKeywords.DeleteAccount(fakeGuid);

            response.Should().HaveStatusCode(HttpStatusCode.NotFound);
        }
    }
}