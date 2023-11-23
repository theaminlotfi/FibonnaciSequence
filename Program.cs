#nullable disable
namespace FibonnaciSequence
{
    internal class Program
    {
        // n = Number of Fibonacci numbers
        // i = Ring loop
        public static int fibo(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 1;
            return (fibo(n - 2) + fibo(n - 1));
        }
        static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine("Enter a number:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Result is:");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("{0} ", fibo(i));
            }
        }
    }
}