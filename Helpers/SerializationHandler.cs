using Newtonsoft.Json;

namespace Helpers
{
    public static class SerializationHandler
    {
        public static T DeserializeResponse<T>(HttpResponseMessage response) where T : class
        {
            return JsonConvert.DeserializeObject<T>(ContentHandler.GetResponseContent(response));
        }

        public static string SerializeObject(object serializableObject)
        {
            return JsonConvert.SerializeObject(serializableObject);
        }
    }
}