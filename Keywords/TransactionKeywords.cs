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

            return await TransactionEndpoints.Deposit(EndpointUrls.DepositUrl, transaction);
        }

        public async Task<HttpResponseMessage> Withdraw(Guid accountNumber, int amount)
        {
            var transaction = new Transaction
            {
                AccountNumber = accountNumber,
                Amount = amount
            };

            return await TransactionEndpoints.Withdraw(EndpointUrls.WithdrawUrl, transaction);
        }
    }
}