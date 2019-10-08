using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minhtam4b_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawU(4);
        }
        private static void SetUp(char[,] arr, int n)
        {
            for (int d = 0; d < n; d++)
                for (int c = 0; c < n; c++)
                    arr[c, d] = ' ';
        }
        private static void Print(char[,] arr,int n)
        {
            for (int d = 0; d < n; d++)
            {
                for (int c = 0; c < n; c++)
                    Console.Write("" + arr[d, c]);
                Console.WriteLine();
            }
        }
        static void DrawU(int n)
        {
            char[,] arr = new char[n, n];
            SetUp(arr, n);

            for (int i = 0; i < n; i++)
            {
                arr[i, 0] = 'u';
                arr[i, n - 1] = 'u';
                arr[n - 1, i] = 'u';
            }
            Print(arr, n);
        }
    }
}
