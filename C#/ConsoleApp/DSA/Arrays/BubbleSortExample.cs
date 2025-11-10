namespace ConsoleApp.DSA;

public class BubbleSortExample
{
    public static void Main(string[] arg)
    {
        int[] intArr = { 7, 12, 9, 11, 3 };
        for (int i = 0; i <= intArr.Length - 2; i++)
        {
            for (int j = i+1; j <= intArr.Length - 1; j++)
            {
                int intTemp = intArr[i];
                if (intArr[j] < intTemp)
                {
                    intArr[i] = intArr[j];
                    intArr[j] = intTemp;
                }
            }
        }

        foreach(var item in intArr)
        {
            Console.WriteLine(item);
        }
    }
}
