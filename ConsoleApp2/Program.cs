using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a, b;
                while (true)
                {
                    Console.Write("Nhap a : ");
                    if (double.TryParse(Console.ReadLine(), out a) && a > 0)
                    {
                        break;
                    }
                    Console.WriteLine("Nhap sai roi , nhap lai!");
                }

                while (true)
                {
                    Console.Write("Nhap b: ");
                    if (double.TryParse(Console.ReadLine(), out b) && b > 0)
                    {
                        break;
                    }
                    Console.WriteLine("Nhap sai roi , nhap lai!");
                }
                double tichso = a*b;
                Console.WriteLine("Tich 2 so la :" + tichso);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
