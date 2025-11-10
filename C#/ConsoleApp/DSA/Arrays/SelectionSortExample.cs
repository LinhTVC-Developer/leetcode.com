namespace ConsoleApp.DSA.Arrays;

public class SelectionSortExample
{
    //public static void Main(int[] args)
    //{

    //}
}

public class Selection
{
    public int[]? NumArray { get; set; }
    public int[] SortArray()
    {
        var arrLength = NumArray.Length;

        for (int i = 0; i < arrLength; i++)
        {
            var smallestVal = i;
            for (int j = i + 1; j < arrLength; j++)
            {
                if (NumArray[j] < NumArray[smallestVal])
                {
                    smallestVal = j;
                }
            }

            //var tempVar = NumArray[smallestVal];
            //NumArray[smallestVal] = NumArray[i];
            //NumArray[i] = tempVar;

            (NumArray[smallestVal], NumArray[i]) = (NumArray[smallestVal], NumArray[i]);
        }
        return NumArray;
    }
}