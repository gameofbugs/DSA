namespace DSA_Problems;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        int num = Convert.ToInt32(Console.ReadLine());
        int len = 0;
        while (num > 0)
        {
            num = num / 10;
            len++;
        }
        Console.WriteLine(len);
    }
}