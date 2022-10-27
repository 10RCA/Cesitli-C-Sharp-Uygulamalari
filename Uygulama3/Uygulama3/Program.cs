using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("1. tam sayıyı giriniz");
            x = Convert.ToInt16(Console.ReadLine());
            int y;
            Console.WriteLine("2. tam sayıyı giriniz");
            y = Convert.ToInt16(Console.ReadLine());
            if ((x / y) == 0)
                Console.WriteLine("Girdiğiniz sayılar birbirine tam bölünüyor");
            else
                Console.WriteLine("Girdiğiniz sayılar birbirine tam bölünmüyor");
        }
    }
}
