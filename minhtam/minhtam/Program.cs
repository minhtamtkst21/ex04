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

            Console.WriteLine(Ceil(3.5));
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
    }
}
