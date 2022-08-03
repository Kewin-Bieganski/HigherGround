namespace Waluty
{
    /// <summary>
    /// Klasa Rate reprezentuje walute
    /// </summary>
    public class Rate
    {
        /// <summary>
        /// currency - nazwa waluty
        /// </summary>
        public string currency { get; set; }
        
        /// <summary>
        /// code - kod waluty w formacie ISO 4217
        /// </summary>
        public string code { get; set; }

        /// <summary>
        /// bid - przeliczony kurs kupna waluty
        /// </summary>
        public float bid { get; set; }

        /// <summary>
        /// ask - przeliczony kurs sprzedaży waluty
        /// </summary>
        public float ask { get; set; }
    }
}