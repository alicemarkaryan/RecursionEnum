using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Fibonachi recursion

            Console.WriteLine(Fibonachii(10));

            //Enum Task
            int a = 9;
            int b = 0;
            int div = a / b;
            if (b == 0)

                switch (b)
                {
                    case 0:
                        Console.WriteLine(Error.divideByZeroException);
                        break;
                    case 1:
                        Console.WriteLine(Error.stackOverFolw);
                        break;
                    case 2:
                        Console.WriteLine(Error.fileNotFound);
                        break;
                    case 3:
                        Console.WriteLine(Error.indexOutOfBound);
                        break;
                }
            Console.WriteLine((int)Error.divideByZeroException);

            // Task

           Console.WriteLine(Swap("Alice"));

            //TAsk 1
            Console.WriteLine(Mult(9));

        }
       // Fibonachi recursion

        public static int Fibonachii(int x)
        { 
            if (x <= 2)
            {
                return 1;
            }
            return Fibonachii(x - 1) + Fibonachii(x - 2);
        }
        public static string Swap(string a)
        {
            if (a.Length < 1)
            {
                return "";
            }
             return a[a.Length - 1] + Swap(a.Substring(0, a.Length - 1));

        }

        public enum Error
        {
            stackOverFolw,
            indexOutOfBound,
            fileNotFound,
            divideByZeroException
        }

       //TAsk 2
        public static int Mult(int b)
        {
            int a = 5;
            if (b == 0)
            {
                return 1;
            }
            Console.WriteLine(+a + "*" + b + "=" + a * b);
            return a * Mult(b - 1);



        }

    }
}
