using Helpers;

namespace Keywords
{
    public class MethodProvider
    {
        public static async Task<HttpResponseMessage> Post(string url, object serializableObject)
        {
            HttpClient client = ClientProvider.CreateClient(url);
            string jsonString = SerializationHandler.SerializeObject(serializableObject);
            StringContent stringContent = ContentHandler.CreateStringContent(jsonString);
            return await client.PostAsync(client.BaseAddress, stringContent);
        }

        public static async Task<HttpResponseMessage> Put(string url, object serializableObject)
        {
            HttpClient client = ClientProvider.CreateClient(url);
            string jsonString = SerializationHandler.SerializeObject(serializableObject);
            StringContent stringContent = ContentHandler.CreateStringContent(jsonString);
            return await client.PutAsync(client.BaseAddress, stringContent);
        }

        public static async Task<HttpResponseMessage> Get(string url)
        {
            HttpClient client = ClientProvider.CreateClient(url);
            return await client.GetAsync(client.BaseAddress);
        }

        public static async Task<HttpResponseMessage> Delete(string url)
        {
            HttpClient client = ClientProvider.CreateClient(url);
            return await ClientProvider.CreateClient(url).DeleteAsync(client.BaseAddress);
        }
    }
}