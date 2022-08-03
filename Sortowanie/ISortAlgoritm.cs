namespace Sortowanie
{
    /// <summary>
    /// Inteface ISortAlhoritm zapewnia, że każdy algorytm będzie miał zaimplementowaną metodę Sort.
    /// </summary>
    internal interface ISortAlgoritm
    {
        public void Sort(ref string[] input, bool isNumeric);
    }
}
