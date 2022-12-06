using DataProvider;
using DataProvider.DataObjects;

namespace Keywords
{
    public class TransactionKeywords
    {
        private TransactionEndpoints TransactionEndpoints;

        public TransactionKeywords()
        {
            TransactionEndpoints = new TransactionEndpoints();
        }

        public async Task<HttpResponseMessage> Deposit(Guid accountNumber, int amount)
        {
            var transaction = new Transaction
            {
                AccountNumber = accountNumber,
                Amount = amount
            };

            string url = string.Format(EndpointUrls.DepositUrl, accountNumber);

            return await TransactionEndpoints.Deposit(url, transaction);
        }

        public async Task<HttpResponseMessage> Withdraw(Guid accountNumber, int amount)
        {
            var transaction = new Transaction
            {
                AccountNumber = accountNumber,
                Amount = amount
            };
            string url = string.Format(EndpointUrls.WithdrawUrl, accountNumber);
            return await TransactionEndpoints.Withdraw(url, transaction);
        }
    }
}