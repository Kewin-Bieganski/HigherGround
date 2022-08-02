using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Sortowanie
{
    internal class FileContentSort
    {
        Stopwatch stopwatch = new Stopwatch();
        private bool isNumeric;
        private string[] fileContents;


        public FileContentSort(string fullPath)
        {
            fileContents = File.ReadAllLines(fullPath);
            isNumeric = fileContents.All(x => Regex.IsMatch(x, "^[0-9]+$"));
        }

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

        private void PassToSort(ISortAlgoritm sortAlgoritm)
        {
            stopwatch.Restart();
            sortAlgoritm.Sort(ref fileContents, isNumeric);
            stopwatch.Stop();
        }

        public string SortInfo()
        {
            return $"Sortowanie trwało: {stopwatch.ElapsedMilliseconds} ms\nLiczba posortowanych elementów: {fileContents.Length}";
        }

        public override string? ToString()
        {
            return string.Join("\n", fileContents);
        }
    }
}
