using System;
using System.Collections.Generic;
using System.Text;

namespace minhtam
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsOdd(3));
            Console.WriteLine(IsEven(4));
            Console.WriteLine(IsPrime(5));
            Console.WriteLine(Square(3));
            Console.WriteLine(Cube(3));
            Console.WriteLine(Pow(2, 3));
            Console.WriteLine(Abs(-9));
            Console.WriteLine(Ceil(3.5));
            Console.WriteLine(Rand1());
            Console.WriteLine(Rand2());
            Console.WriteLine(Factorial(3));
        }
        public static bool IsOdd(int n)
        {
            if (n % 2 == 1)
                return true;
            return false;
        }
        public static bool IsEven(int n)
        {
            if (n % 2 == 0)
                return true;
            return false;
        }
        public static bool IsPrime(int n)
        {
            int dem = 0;
            for (int i=1;i<=n;i++)
            {
                if (n % i == 0)
                    dem++;
            }
            if (dem == 2)
                return true;
            return false;
        }
        public static int Square(int n)
        {
            return n * n;
        }
        public static int Cube(int n)
        {
            return n * n * n;
        }
        public static int Pow(int a, int b)
        {
            return a * b;
        }
        public static int Abs(int n)
        {
            if (n <= 0)
                return -n;
            return n;
        }
        public static int Ceil(Double x)
        {
            int n = (int) x + 1;
            return n;
        }
        public static int Floor(Double x)
        {
            int n = (int)x + 1;
            return n;
        }
        public static int Rand1()
        {
            Random rand = new Random();
            int n = rand.Next();
            return n;
        }
        public static double Rand2()
        {
            Random rand = new Random();
            double n = rand.NextDouble();
            return n;
        }
        public static long Factorial(long n)
        {
            int ketqua=1;
            for (int i = 2; i <= n; i++)
                ketqua = ketqua * i;
            return ketqua;
        }
    }
}
