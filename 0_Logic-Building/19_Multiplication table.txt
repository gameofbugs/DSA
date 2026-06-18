namespace DSA_Problems;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a NUmber:");
        int a = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{a} X {i} = {a * i}");
        }
    }
}