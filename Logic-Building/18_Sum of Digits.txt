namespace DSA_Problems;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a NUmber:");
        int a = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while (a > 0)
        {
            int digit = a % 10;
            sum = sum + digit;
            a = a / 10;
        }
        Console.WriteLine(sum);
    }
}