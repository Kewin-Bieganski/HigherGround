using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Sortowanie
{
    /// <summary>
    /// Klasa FileContentSort daje możliwość posortowania danych wskazanym algrytmem.
    /// </summary>
    internal class FileContentSort
    {
        Stopwatch stopwatch = new Stopwatch();
        
        /// <summary>
        /// isNumeric - czy input ma zostac potraktowany jako liczba czy tekst
        /// </summary>
        private bool isNumeric;

        /// <summary>
        /// fileContents - zawartość pliku
        /// </summary>
        private string[] fileContents;

        public FileContentSort(string fullPath)
        {
            fileContents = File.ReadAllLines(fullPath);
            // Upewnij się czy plik jest liczbowy lub tekstowy.
            isNumeric = fileContents.All(x => Regex.IsMatch(x, "^[0-9]+$"));
        }

        /// <summary>
        /// Metoda sort umożliwia wybranie algorytmu do posortowania pliku.
        /// </summary>
        /// <param name="sortMode">Algortym</param>
        public void Sort(SortMode sortMode)
        {
            switch (sortMode)
            {
                case SortMode.BubbleSort:
                    PassToSort(new BubbleSort());
                    break;
                case SortMode.QuickSort:
                    PassToSort(new QuickSort());
                    break;
                case SortMode.InsertionSort:
                    PassToSort(new InsertionSort());
                    break;
            }
        }

        /// <summary>
        /// Metoda PassToSort wywołuje posortowanie pliku, a także odmierza czas sortowania.
        /// </summary>
        /// <param name="sortAlgoritm">Instacja algorytmu</param>
        private void PassToSort(ISortAlgoritm sortAlgoritm)
        {
            stopwatch.Restart();
            sortAlgoritm.Sort(ref fileContents, isNumeric);
            stopwatch.Stop();
        }

        /// <summary>
        /// Metoda SortInfo zwraca informacje o sortowaniu.
        /// </summary>
        /// <returns>Informacje o sortowaniu</returns>
        public string SortInfo()
        {
            return $"Sortowanie trwało: {stopwatch.ElapsedMilliseconds} ms\nLiczba posortowanych elementów: {fileContents.Length}";
        }

        /// <summary>
        /// Metoda ToString zwraca zawartosc pliku.
        /// </summary>
        /// <returns>Zawartosc pliku</returns>
        public override string? ToString()
        {
            return string.Join("\n", fileContents);
        }
    }
}
