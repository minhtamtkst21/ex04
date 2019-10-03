using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minhtam4b
{
    public class Program2
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Nhap do dai mang: ");
            //string dodai= Console.ReadLine();
            //int lenght = int.Parse(dodai);
            //InputValues(new int[lenght]);
            a(4,'i');
            Console.WriteLine();
            b(4,'o');
            Console.WriteLine();
            c(4,'i');
            Console.WriteLine();
            d(4,'i');
            Console.WriteLine();
            e(4,'v');
            Console.WriteLine();
            f(4,'v');
            Console.WriteLine();
            g(4,'a');
            Console.WriteLine();
            h(4,'w');
            Console.WriteLine();
            //i(4,'a');
            Console.WriteLine();
            //j(4,'x');
            Console.WriteLine();
            //k(4,'+');
        }
        public static void InputValues(int[] iArr)
        {
            for (int i=0;i<iArr.Length;i++)
            {
                Console.Write("A[{0}] = ",i);
               String str =  Console.ReadLine();
               iArr[i] = int.Parse(str);
            }
        }
        public static bool IsContain5(int[] iArr)
        {
             for (int i=0;i<iArr.Length;i++)
             {
                 if (iArr[i] == 5)
                     return true;
             }
             return false;
        }
        public static bool IsContain5or6(int[] iArr)
        {
            for (int i = 0; i < iArr.Length; i++)
            {
                if (iArr[i] == 5 || iArr[i] == 6)
                    return true;
            }
            return false;
        }
        public static bool IsContain5and6(int[] iArr)
        {
            bool b5= false, b6= false;
            for (int i = 0; i < iArr.Length; i++)
            {
                if (iArr[i] == 5)
                    b5=true;
                if (iArr[i] == 6)
                    b6=true;
                if (b5==true && b6==true)
                    return true;
            }
            return false;
        }
        public static int count5(int[] iArr)
        {
            int dem = 0;
            for (int i = 0; i < iArr.Length; i++)
            {
                if (iArr[i] == 5)
                    dem++;
            }
            return dem;
        }
        public static int count5or6(int[] iArr)
        {
            int dem = 0;
            for (int i = 0; i < iArr.Length; i++)
            {
                if (iArr[i] == 5 || iArr[i] == 6)
                    dem++;
            }
            return dem;
        }
        public static int sumArray(int[] iArr)
        {
            int sum = 0;
            for (int i = 0; i < iArr.Length; i++)
            {
                sum = sum + iArr[i];
            }
            return sum;
        }
        static void a(int n, char c)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(c);
            }
        }
        static void a1(int n, char c)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(c);
            }
        }
        static void b(int n, char c)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("o");
                }
                Console.WriteLine();
            }
        }
        static void c(int n, char c)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i==1 || i==n)
                    {
                        Console.Write("o");
                    }
                    else
                    {
                        if (j == 1 || j == n)
                        {
                            Console.Write("o");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
        static void d(int n, char c)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == n)
                    {
                        Console.Write("o");
                    }
                    else
                    {
                        if (j == 1 || j == n)
                        {
                            Console.Write("o");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
        //1:0s,1c,5s,1c 2*2+1 
        //2:1s,1c,3s,1c 1*2+1 
        //3:2s,1c,1s,1c 0*2+1 
        //4:3s,1c
        static void e(int n, char c)
        {
            for (int i=1 ;i<=n;i++)
            {
                if (i == n)
                {
                    a1(n-1, ' ');
                    a1(1, c);
                    Console.WriteLine();
                }
                else
                {
                    a1(i-1, ' ');
                    a1(1, c);
                    a1(2 * (n - i + 1) - 3, ' ');
                    a1(1, c);
                    Console.WriteLine();
                }
            }
        }
        static void f(int n, char c)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    a1(2*n-1,c);
                    Console.WriteLine();
                }
                else
                {
                    if (i == n)
                    {
                        a1(n - 1, ' ');
                        a1(1, c);
                        Console.WriteLine();
                    }
                    else
                    {
                        a1(i - 1, ' ');
                        a1(1, c);
                        a1(2 * (n - i + 1) - 3, ' ');
                        a1(1, c);
                        Console.WriteLine();
                    }
                }
            }
        }
        static void g(int n, char c)
        {
            for (int i=1;i<=n;i++)
            {
                if(i==1)
                {
                    a1(n-1,' ');
                    a1(1, c);
                    
                    Console.WriteLine();
                }
                else
                    if (i==n)
                    {
                        a1(2 * n - 1, c);
                        Console.WriteLine();
                    }
                    else
                    {
                        a1(n - i, ' ');
                        a1(1, c);
                        a1(2*i -3, ' ');
                        a1(1, c);
                        Console.WriteLine();
                    }
            }
        }
        static void h(int n,char c)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i == n)
                {
                    a1(n - 1, ' ');
                    a1(1, c);
                    Console.WriteLine();
                }
                else
                {
                    a1(i - 1, ' ');
                    a1(1, c);
                    a1(2 * (n - i + 1) - 3, ' ');
                    a1(1, c);
                    Console.WriteLine();
                }
            }
        }
    }
}
