namespace Keywords
{
    public static class ClientProvider
    {
        public static HttpClient CreateClient(string url)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            return client;
        }
    }
}