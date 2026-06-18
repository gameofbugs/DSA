namespace DSA_Problems;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter First NUmber:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second NUmber:");
        int b = Convert.ToInt32(Console.ReadLine());
        int gcd = 1;
        for (int i = 1; i <= a && i <= b; i++)
        {
            int num1 = a % i;
            int num2 = b % i;
            if (num1 == 0 && num2 == 0)
            {
                gcd = i;
            }
        }
        int lcm = a * b / gcd;
        Console.WriteLine(lcm);
    }
}