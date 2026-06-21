namespace DSA_Problems;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 5, 4, 3, 2, 1 };
        int[] array2 = { 1, 5, 3, 4, 6 };

        bool CheckSorted(int[] arr)
        {
            int k = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                //Console.WriteLine($"{i},{k}");
                if (arr[i] >= arr[k])
                {
                    k = i;
                }
                else
                {
                    break;
                }
                //Console.WriteLine($"{i},{k}");
            }
            if (k == arr.Length - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        if (CheckSorted(array))
        {
            Console.WriteLine($"Array array Is sorted");
        }
        else
        {
            Console.WriteLine($"Array array Is not sorted");
        }

        if (CheckSorted(array2))
        {
            Console.WriteLine($"Array array2 Is sorted");
        }
        else
        {
            Console.WriteLine($"Array array Is not sorted");
        }
    }
}