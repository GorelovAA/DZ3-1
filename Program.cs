using System;

namespace DZ3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Задание 1. Приложение по определению чётного или нечётного числа
            Console.WriteLine("Задание 1. Приложение по определению чётного или нечётного числа»");

            Console.WriteLine("\nВведите число: ");               /// Просим ввести число
            int i = int.Parse(Console.ReadLine());              /// Ввод + преобразование числа

            if (i % 2 == 0)                                     /// Проверяем условие
            {
                Console.WriteLine("Ваше число четное!");        /// Вывод сообщения если истина - четное

            }
            else Console.WriteLine("Ваше число не четное!");    /// Вывод сообщения если ложь - четное

        }
    }
}
