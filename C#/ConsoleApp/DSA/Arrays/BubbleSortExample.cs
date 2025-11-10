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
                
                if (intArr[j] < intArr[i])
                {
                    //int intTemp = intArr[i];
                    //intArr[i] = intArr[j];
                    //intArr[j] = intArr[i];

                    (intArr[i], intArr[j]) = (intArr[j], intArr[i]);
                }
            }
        }

        foreach(var item in intArr)
        {
            Console.WriteLine(item);
        }
    }
}
