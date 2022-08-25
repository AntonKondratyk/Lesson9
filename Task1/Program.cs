using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калк");
            try
            {
                Console.WriteLine("цел число 1");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("цел число 2");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("1 2 3 4 слож выч умн дел");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n < 0 || n > 4)
                {
                    Console.WriteLine("еще раз, идиот");
                }
                else
                {
                    switch (n)
                    {
                        case 1: Console.WriteLine("сумма={0}", x + y); break;
                        case 2: Console.WriteLine("сумма={0}", x - y); break;
                        case 3: Console.WriteLine("сумма={0}", x * y); break;
                        case 4: Console.WriteLine("сумма={0:f2}", x / y); break;
                    }
                }
                /*double l = Convert.ToDouble(Console.ReadLine());
                double r = l / (2 * Math.PI);
                Console.WriteLine(r);
                Console.ReadKey();*/
            }
            catch (FormatException)
            {
                Console.WriteLine("неверный формат ввода");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("дел на 0");
            }
            Console.ReadKey();
            }
        }
    }
