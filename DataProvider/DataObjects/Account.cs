using Newtonsoft.Json;

namespace DataProvider.DataObjects
{
    public class Account
    {
        [JsonProperty("account_id")]
        public Guid AccountNumber { get; set; }
        [JsonProperty("balance")]
        public int AvailableAmount { get; set; }
    }
}