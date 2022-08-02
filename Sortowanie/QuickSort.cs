namespace Sortowanie
{
    internal class QuickSort : ISortAlgoritm
    {
        private bool isNumeric;
        public void Sort(ref string[] input, bool isNumeric)
        {
            this.isNumeric = isNumeric;
            sort(ref input, 0, input.Length - 1);
        }

        public void sort(ref string[] input, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = input[leftIndex];
            while (i <= j)
            {
                while (isNumeric ? (long.Parse(input[i]) < long.Parse(pivot)) : (input[i].CompareTo(pivot) < 0))
                {
                    i++;
                }

                while (isNumeric ? (long.Parse(input[j]) > long.Parse(pivot)) : (input[j].CompareTo(pivot) > 0))
                {
                    j--;
                }
                if (i <= j)
                {
                    var temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                sort(ref input, leftIndex, j);
            if (i < rightIndex)
                sort(ref input, i, rightIndex);
        }
    }
}