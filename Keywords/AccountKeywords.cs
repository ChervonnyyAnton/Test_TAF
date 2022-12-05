using DataProvider;
using DataProvider.DataObjects;
using Helpers;

namespace Keywords
{
    public class AccountKeywords
    {
        private AccountEndpoints AccountEndpoints;

        public AccountKeywords()
        {
            AccountEndpoints = new AccountEndpoints();
        }

        public async Task CreateAccount()
        {
            var account = new Account
            {
                AccountNumber = new Guid(),
                AvailableAmount = 100
            };

            await AccountEndpoints.CreateAccount(EndpointUrls.CreateAccountUrl, account);
        }

        public async Task<HttpResponseMessage> CreateAccount(Account account)
        {
            return await AccountEndpoints.CreateAccount(EndpointUrls.CreateAccountUrl, account);
        }

        public async Task<HttpResponseMessage> DeleteAccount(Guid accountNumber)
        {
            string url = string.Format(EndpointUrls.DeleteAccountUrl, accountNumber);
            return await AccountEndpoints.DeleteAccount(url);
        }

        public async Task<List<Account>> GetAvailableAccounts()
        {
            HttpResponseMessage response = await AccountEndpoints.GetAvailableAccounts(EndpointUrls.GetAvailableAccountsUrl);
            return SerializationHandler.DeserializeResponse<List<Account>>(response);
        }

        public async Task<Account> GetAccountInformation(Guid accountNumber)
        {
            string url = string.Format(EndpointUrls.GetAccountInformationUrl, accountNumber);
            HttpResponseMessage response = await AccountEndpoints.GetAccountInformation(url);
            return SerializationHandler.DeserializeResponse<Account>(response);
        }
    }
}