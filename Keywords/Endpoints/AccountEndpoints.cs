namespace Keywords
{
    public class AccountEndpoints
    {
        public async Task<HttpResponseMessage> Authenticate(string url, object serializableObject)
        {
            return await MethodProvider.Post(url, serializableObject);
        }

        public async Task<HttpResponseMessage> GetAvailableAccounts(string url)
        {
            return await MethodProvider.Get(url);
        }

        public async Task<HttpResponseMessage> GetAccountInformation(string url)
        {
            return await MethodProvider.Get(url);
        }

        public async Task<HttpResponseMessage> CreateAccount(string url, object serializableObject)
        {
            return await MethodProvider.Post(url, serializableObject);
        }

        public async Task<HttpResponseMessage> DeleteAccount(string url)
        {
            return await MethodProvider.Delete(url);
        }
    }
}