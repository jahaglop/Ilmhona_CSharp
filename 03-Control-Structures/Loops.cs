using System;

namespace ControlStructures
{
    class Loops
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ПРИМЕРЫ ЦИКЛА FOR ===");
            
            // Простой цикл for
            Console.WriteLine("Считаем от 1 до 5:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Счет: {i}");
            }
            
            // Таблица умножения
            Console.WriteLine("\nТаблица умножения на 5:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"5 x {i} = {5 * i}");
            }
            
            Console.WriteLine("\n=== ПРИМЕРЫ ЦИКЛА WHILE ===");
            
            // Цикл while
            int chislo = 1;
            Console.WriteLine("Четные числа от 2 до 10:");
            while (chislo <= 5)
            {
                Console.WriteLine(chislo * 2);
                chislo++;
            }
            
            Console.WriteLine("\n=== ПРИМЕРЫ ЦИКЛА DO-WHILE ===");
            
            // Цикл do-while (пример меню)
            int vybor;
            do
            {
                Console.WriteLine("\nПростое меню:");
                Console.WriteLine("1. Сказать Привет");
                Console.WriteLine("2. Сказать До свидания");
                Console.WriteLine("3. Выход");
                Console.Write("Выберите опцию: ");
                vybor = int.Parse(Console.ReadLine());
                
                switch (vybor)
                {
                    case 1:
                        Console.WriteLine("Привет!");
                        break;
                    case 2:
                        Console.WriteLine("До свидания!");
                        break;
                    case 3:
                        Console.WriteLine("Выходим...");
                        break;
                    default:
                        Console.WriteLine("Неверный выбор!");
                        break;
                }
            } while (vybor != 3);
            
            Console.ReadLine();
        }
    }
}

/* 
ЗАДАНИЕ 6: Практика с циклами
1. Создайте цикл, который отображает числа от 10 до 1 (обратный отсчет)
2. Создайте цикл, который вычисляет сумму чисел от 1 до 100
3. Спросите у пользователя число и отобразите его таблицу умножения
4. Создайте игру-угадалку, где пользователь угадывает число от 1 до 10
*/
