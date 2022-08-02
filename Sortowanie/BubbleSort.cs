namespace Sortowanie
{
    internal class BubbleSort : ISortAlgoritm
    {
        public void Sort(ref string[] input, bool isNumeric)
        {
            bool itemMoved = false;
            do
            {
                itemMoved = false;
                for (int i = 0; i < input.Count() - 1; i++)
                {
                    if (isNumeric ? (long.Parse(input[i]) > long.Parse(input[i + 1])) : (input[i].CompareTo(input[i + 1]) > 0))
                    {
                        var lowerValue = input[i + 1];
                        input[i + 1] = input[i];
                        input[i] = lowerValue;
                        itemMoved = true;
                    }
                }
            } while (itemMoved);
        }
    }
}
