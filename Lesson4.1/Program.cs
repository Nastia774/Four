using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int operand1 = 12, operand2 = 3;
            Console.WriteLine("Введите знак арифметической операции: +, -, *, /");
            string oper = Console.ReadLine();

            switch (oper)
            {
                case "+":
                    {
                        int sum = operand1 + operand2;

                        Console.WriteLine($" {operand1} + {operand2} = {sum}");
                        break;
                    }
                case "-":
                    {
                        int raz = operand1 - operand2;

                        Console.WriteLine($" {operand1} - {operand2} = {raz}");
                        break;

                    }
                case "*":
                    {
                        int mult = operand1 * operand2;

                        Console.WriteLine($" {operand1} * {operand2} = {mult}");
                        break;
                    }
                case "/":
                    {
                        int del = operand1 / operand2;

                        Console.WriteLine($" {operand1} / {operand2} = {del}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Такого арифметического знака нет");
                        break;
                    }
            }

            Console.ReadKey();
        }
    }
}
