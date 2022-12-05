namespace Keywords
{
    public class TransactionEndpoints
    {
        public async Task<HttpResponseMessage> Deposit(string url, object serializableObject)
        {
            return await MethodProvider.Post(url, serializableObject);
        }

        public async Task<HttpResponseMessage> Withdraw(string url, object serializableObject)
        {
            return await MethodProvider.Post(url, serializableObject);
        }
    }
}