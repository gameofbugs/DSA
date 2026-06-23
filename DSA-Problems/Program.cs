namespace DSA_Problems;

class Program
{
    static void Main(string[] args)
    {
        int[] arr1 = { -1, -1, 5, 5 };
        //int[] duplicateArray = new int[arr1.Length];
        //int index = 0;
        int diplicateElement = -1;
        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = i + 1; j < arr1.Length; j++)
            {
                if (arr1[i] == arr1[j])
                {

                    if (arr1[i] != diplicateElement)
                    {
                        diplicateElement = arr1[i];
                        Console.WriteLine(arr1[i]);
                        //index++;
                        break;
                    }
                }
            }
        }
    }
}