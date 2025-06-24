using System;

namespace ControlStructures
{
    class IfStatements
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваш возраст: ");
            int vozrast = int.Parse(Console.ReadLine());
            
            // Простое условие if
            if (vozrast >= 18)
            {
                Console.WriteLine("Вы совершеннолетний!");
            }
            else
            {
                Console.WriteLine("Вы несовершеннолетний.");
            }
            
            // Множественные условия
            if (vozrast < 13)
            {
                Console.WriteLine("Вы ребенок.");
            }
            else if (vozrast < 20)
            {
                Console.WriteLine("Вы подросток.");
            }
            else if (vozrast < 60)
            {
                Console.WriteLine("Вы взрослый.");
            }
            else
            {
                Console.WriteLine("Вы пожилой человек.");
            }
            
            // Логические операторы
            Console.Write("Введите ваш балл (0-100): ");
            int ball = int.Parse(Console.ReadLine());
            
            if (ball >= 90 && ball <= 100)
            {
                Console.WriteLine("Оценка: 5 - Отлично!");
            }
            else if (ball >= 80)
            {
                Console.WriteLine("Оценка: 4 - Хорошо!");
            }
            else if (ball >= 70)
            {
                Console.WriteLine("Оценка: 3 - Удовлетворительно");
            }
            else if (ball >= 60)
            {
                Console.WriteLine("Оценка: 2 - Неудовлетворительно");
            }
            else
            {
                Console.WriteLine("Оценка: 1 - Провал");
            }
            
            Console.ReadLine();
        }
    }
}

/* 
ЗАДАНИЕ 5: Создайте свои условия
1. Спросите температуру и скажите, жарко ли (>30), тепло (20-30), или холодно (<20)
2. Создайте простую проверку пароля (проверьте, что длина пароля > 8)
3. Спросите число и скажите, положительное оно, отрицательное или ноль
4. Создайте простой калькулятор, который спрашивает операцию (+, -, *, /) и два числа
*/
