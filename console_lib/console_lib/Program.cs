using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib_phepnhan;
namespace console_lib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float kq = phepnhan.Phepnhan(3, 7);
            Console.WriteLine("Ket qua phep tinh la:{0}",kq);
            Console.ReadLine();
        }
    }
}
