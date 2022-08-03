namespace Sortowanie
{
    /// <summary>
    /// Klasa InsertionSort reprezentuje algorytm sortowania InsertionSort.
    /// </summary>
    internal class InsertionSort : ISortAlgoritm
    {
        public void Sort(ref string[] input, bool isNumeric)
        {
            for (int i = 0; i < input.Count(); i++)
            {
                var item = input[i];
                var currentIndex = i;
                while (currentIndex > 0 && (isNumeric ? (long.Parse(input[currentIndex - 1]) > long.Parse(item)) : (input[currentIndex - 1].CompareTo(item) > 0)))
                {
                    input[currentIndex] = input[currentIndex - 1];
                    currentIndex--;
                }
                input[currentIndex] = item;
            }
        }
    }
}
