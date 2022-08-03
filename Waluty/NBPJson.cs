namespace Waluty
{
    /// <summary>
    /// Klasa NBPJson reprezentuje odczyt tabeli walut
    /// </summary>
    public class NBPJson
    {
        /// <summary>
        /// table - typ tabeli
        /// </summary>
        public string table { get; set; }

        /// <summary>
        /// no - numer tabeli
        /// </summary>
        public string no { get; set; }

        /// <summary>
        /// tradingDate - data notowania
        /// </summary>
        public string tradingDate { get; set; }

        /// <summary>
        /// effectiveDate - data publikacji
        /// </summary>
        public string effectiveDate { get; set; }

        /// <summary>
        /// rate - lista kursów poszczególnych walut w tabeli
        /// </summary>
        public Rate[] rates { get; set; }
    }
}