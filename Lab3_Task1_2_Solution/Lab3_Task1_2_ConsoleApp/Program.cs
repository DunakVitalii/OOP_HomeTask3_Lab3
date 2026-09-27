using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Task1_2_ConsoleApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Налаштування кодування для коректного відображення українських літер
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введіть ціле число: ");
            string input = Console.ReadLine();

            // Перевірка, чи дійсно введено ціле число
            if (int.TryParse(input, out int number))
            {
                Console.WriteLine($"Ви ввели число {number}");
            }
            else
            {
                Console.WriteLine("Помилка: введено некоректні дані, це не ціле число.");
            }

            // Затримка екрану, щоб вікно не закрилося миттєво
            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}
