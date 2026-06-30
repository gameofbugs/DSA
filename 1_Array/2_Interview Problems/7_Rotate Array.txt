namespace DSA_Problems;

class Program
{
    static void Main(string[] args)
    {
        int[] arr1 = { 1, 2, 3, 4, 5 };
        System.Console.WriteLine("Enter Number");
        int k = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Begpre Right ROtate");
        foreach (int i in arr1)
        {
            System.Console.WriteLine(i);
        }
        for (int j = 0; j < k; j++)
        {
            int lastElement = arr1[arr1.Length - 1];
            for (int i = arr1.Length - 2; i >= 0; i--)
            {
                arr1[i + 1] = arr1[i];
                if (i == 0)
                {
                    arr1[i] = lastElement;
                }
            }
        }
        System.Console.WriteLine("After Right ROtate");
        foreach (int i in arr1)
        {
            System.Console.WriteLine(i);
        }
    }
}