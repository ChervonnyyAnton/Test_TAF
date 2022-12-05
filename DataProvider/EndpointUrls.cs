namespace DataProvider
{
    public static class EndpointUrls
    {
        public static string BaseUrl = "http://localhost:5000/";
        public static string GetAvailableAccountsUrl => BaseUrl + "account/getAll";
        public static string GetAccountInformationUrl => BaseUrl + "account/{0}";
        public static string CreateAccountUrl => BaseUrl + "account/new";
        public static string DeleteAccountUrl => BaseUrl + "account{0}";
        public static string DepositUrl => BaseUrl + "account{0}/deposit";
        public static string WithdrawUrl => BaseUrl + "account{0}/withdraw";
    }
}