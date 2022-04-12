namespace SelectionSort
{
    public class Selection
    {
        public int[]? IntArray { get; set; }

        public int[] SortArray() 
        {
            var arrayLength = IntArray.Length;
            for (int i = 0; i < arrayLength - 1; i++)
            {
                var smallestVal = i;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (IntArray[j] < IntArray[smallestVal])
                    {
                        smallestVal = j;
                    }
                }
        
                var tempVar = IntArray[smallestVal];
                IntArray[smallestVal] = IntArray[i];
                IntArray[i] = tempVar;
            }

            return IntArray;
        }
    }
}