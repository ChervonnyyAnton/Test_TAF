using Newtonsoft.Json;

namespace DataProvider.DataObjects
{
    public class Transaction
    {
        [JsonProperty("account_id")]
        public Guid AccountNumber { get; set; }
        [JsonProperty("amount")]
        public int Amount { get; set; }
    }
}