using Newtonsoft.Json;

namespace DataProvider.DataObjects
{
    public class AvailableAccounts
    {
        [JsonProperty("accounts")]
        List<Account> Accounts { get; set; }
    }
}