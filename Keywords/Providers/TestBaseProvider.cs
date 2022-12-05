using DataProvider.DataObjects;

namespace Keywords.Providers
{
    public class TestBaseProvider : IDisposable
    {
        protected AccountKeywords AccountKeywords { get; set; }

        public TestBaseProvider()
        {
            InitializeKeywords();
            cleanUp();
        }

        protected virtual void InitializeKeywords()
        {
            AccountKeywords = new AccountKeywords();
        }

        protected virtual void cleanUp()
        {
            List<Account> accounts = AccountKeywords.GetAvailableAccounts().GetAwaiter().GetResult();
            foreach (Account account in accounts)
            {
                AccountKeywords.DeleteAccount(account.AccountNumber).GetAwaiter().GetResult();
            }
        }

        protected virtual void Dispose(bool isDisposable)
        {
            if (!isDisposable)
            {
                return;
            }

            cleanUp();
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}