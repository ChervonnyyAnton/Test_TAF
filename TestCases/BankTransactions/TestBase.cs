namespace TestCases.BankTransactions
{
    public class TestBase : TestBaseProvider
    {
        protected TransactionKeywords TransactionKeywords { get; set; }

        protected override void InitializeKeywords()
        {
            base.InitializeKeywords();
            TransactionKeywords = new TransactionKeywords();
        }
    }
}