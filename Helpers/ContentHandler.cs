using System.Text;

namespace Helpers
{
    public static class ContentHandler
    {
        public static StringContent CreateStringContent(string jsonString)
        {
            return new StringContent(jsonString, Encoding.UTF8, "application/json");
        }

        public static string GetResponseContent(HttpResponseMessage response)
        {
            return response.Content.ReadAsStringAsync().Result;
        }
    }
}