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
            int resAdd;
            Console.WriteLine("Введите число a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b:");
            b = Convert.ToInt32(Console.ReadLine());
            resAdd = a + b;
            Console.WriteLine("Ответ:" + resAdd);
            double res = a * b;
            Console.WriteLine("Ответ:" + res);
            double resSub = a + b;
            Console.WriteLine("Ответ:" + resSub);
            Console.ReadKey();
        }
    }
}
