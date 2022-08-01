namespace Waluty
{
    public class NBPJson
    {
        public string table { get; set; }
        public string no { get; set; }
        public string tradingDate { get; set; }
        public string effectiveDate { get; set; }
        public Rate[] rates { get; set; }
    }
}