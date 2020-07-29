using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.add
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите погоду");

            string word = Console.ReadLine();
            
            switch (word)
            {
                case "жарко":
                    {
                        Console.WriteLine($"{word} - xot");
                        break;
                    }
                case "прохладно":
                    {
                        Console.WriteLine($"{word} -coоl");
                        break;
                    }
                case "солнечно":
                    {
                        Console.WriteLine($"{word} -sunny");
                        break;
                    }
                case "дождливо":
                    {
                        Console.WriteLine($"{word} -rainy");
                        break;
                    }
                case "ясно":
                    {
                        Console.WriteLine($"{word} -clear");
                        break;
                    }
                case "пасмурно":
                    {
                        Console.WriteLine($"{word} -cloudy");
                        break;
                    }
                case "туманно":
                    {
                        Console.WriteLine($"{word} -misty");
                        break;
                    }
                case "ветряно":
                    {
                        Console.WriteLine($"{word} -windy");
                        break;
                    }
                case "сухо":
                    {
                        Console.WriteLine($"{word} -dry");
                        break;
                    }
                case "влажно":
                    {
                        Console.WriteLine($"{word} -humid");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Такого слова нет");
                        break;
                    }
            }
            Console.ReadKey();
        }

    }
}
