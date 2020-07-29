using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 0 до 100");

            int num = int.Parse(Console.ReadLine());

            if (0 <= num && num <= 14)
            {
                Console.WriteLine("Ваше число попадает в промжуток 0-14");
            }
            else if (15 <= num && num <= 35)
            {
                Console.WriteLine("Ваше число попадает в промжуток 15-35");
            }
            else if (36 <= num && num <= 50)
            {
                Console.WriteLine("Ваше число попадает в промжуток 36-50");
            }
            else if (50 <= num && num <= 100)
            {
                Console.WriteLine("Ваше число попадает в промжуток 50-100");
            }
            else
            {
                Console.WriteLine("Ваше число не входит ни в один промежуток");
            }

            Console.ReadKey();
        }
    }
}
