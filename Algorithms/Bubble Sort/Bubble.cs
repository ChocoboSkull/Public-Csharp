namespace BubbleSort
{
    public class Bubble
    {
        public int[]? IntArray { get; set; }

        public int[] SortArray() 
        {
            var n = IntArray.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (IntArray[j] > IntArray[j + 1])
                    {
                        var tempVar = IntArray[j];
                        IntArray[j] = IntArray[j + 1];
                        IntArray[j + 1] = tempVar;
                    }
                }
            }

            return IntArray;
        }
    }
}