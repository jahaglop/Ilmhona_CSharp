using System;
using System.Collections.Generic;

namespace PracticeProjects
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ПРОСТОЙ КАЛЬКУЛЯТОР ===");
            
            while (true)
            {
                PokazatMenu();
                string vybor = Console.ReadLine();
                
                if (vybor == "6")
                {
                    Console.WriteLine("Спасибо за использование калькулятора!");
                    break;
                }
                
                if (vybor == "5")
                {
                    PokazatIstoriu();
                    continue;
                }
                
                // Получаем числа от пользователя
                Console.Write("Введите первое число: ");
                if (!double.TryParse(Console.ReadLine(), out double chislo1))
                {
                    Console.WriteLine("Неверное число! Попробуйте снова.\n");
                    continue;
                }
                
                Console.Write("Введите второе число: ");
                if (!double.TryParse(Console.ReadLine(), out double chislo2))
                {
                    Console.WriteLine("Неверное число! Попробуйте снова.\n");
                    continue;
                }
                
                double rezultat = 0;
                string operaciya = "";
                bool vernaOperaciya = true;
                
                switch (vybor)
                {
                    case "1":
                        rezultat = chislo1 + chislo2;
                        operaciya = "+";
                        break;
                    case "2":
                        rezultat = chislo1 - chislo2;
                        operaciya = "-";
                        break;
                    case "3":
                        rezultat = chislo1 * chislo2;
                        operaciya = "*";
                        break;
                    case "4":
                        if (chislo2 != 0)
                        {
                            rezultat = chislo1 / chislo2;
                            operaciya = "/";
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: Нельзя делить на ноль!\n");
                            vernaOperaciya = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Неверный выбор! Попробуйте снова.\n");
                        vernaOperaciya = false;
                        break;
                }
                
                if (vernaOperaciya)
                {
                    Console.WriteLine($"Результат: {chislo1} {operaciya} {chislo2} = {rezultat}\n");
                    DobavitVIstoriu($"{chislo1} {operaciya} {chislo2} = {rezultat}");
                }
            }
            
            Console.ReadLine();
        }
        
        static List<string> istoriyaVychisleniy = new List<string>();
        
        static void PokazatMenu()
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложение (+)");
            Console.WriteLine("2. Вычитание (-)");
            Console.WriteLine("3. Умножение (*)");
            Console.WriteLine("4. Деление (/)");
            Console.WriteLine("5. Показать историю");
            Console.WriteLine("6. Выход");
            Console.Write("Введите ваш выбор (1-6): ");
        }
        
        static void DobavitVIstoriu(string vychislenie)
        {
            istoriyaVychisleniy.Add(vychislenie);
        }
        
        static void PokazatIstoriu()
        {
            Console.WriteLine("\n=== ИСТОРИЯ ВЫЧИСЛЕНИЙ ===");
            if (istoriyaVychisleniy.Count == 0)
            {
                Console.WriteLine("Вычислений пока нет.");
            }
            else
            {
                for (int i = 0; i < istoriyaVychisleniy.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {istoriyaVychisleniy[i]}");
                }
            }
            Console.WriteLine();
        }
    }
}

/* 
ПРОЕКТ 2: Улучшите калькулятор
1. Добавьте больше операций (степень, квадратный корень, проценты)
2. Добавьте функции памяти (сохранить, вызвать, очистить память)
3. Добавьте возможность использовать предыдущий результат в следующем вычислении
4. Добавьте научные функции калькулятора (sin, cos, tan, log)
*/
