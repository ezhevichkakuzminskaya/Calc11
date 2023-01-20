using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int result;
            Console.WriteLine("Введите число a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b:");
            b = Convert.ToInt32(Console.ReadLine());
            result = a + b;
            Console.WriteLine("Ответ:" + result);
            Console.ReadKey();
        }
    }
}
