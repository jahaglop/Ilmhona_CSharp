using System;

namespace PracticeProjects
{
    class NumberGuessingGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ИГРА УГАДАЙ ЧИСЛО ===");
            Console.WriteLine("Я загадал число от 1 до 100!");
            
            Random random = new Random();
            int zagadannoeCHislo = random.Next(1, 101);
            int popytki = 0;
            int maksPopytok = 7;
            bool pobedil = false;
            
            while (popytki < maksPopytok && !pobedil)
            {
                Console.Write($"\nПопытка {popytki + 1}/{maksPopytok} - Введите ваше предположение: ");
                
                if (int.TryParse(Console.ReadLine(), out int dogadka))
                {
                    popytki++;
                    
                    if (dogadka == zagadannoeCHislo)
                    {
                        Console.WriteLine($"🎉 Поздравляю! Вы угадали за {popytki} попыток!");
                        pobedil = true;
                    }
                    else if (dogadka < zagadannoeCHislo)
                    {
                        Console.WriteLine("Слишком мало! Попробуйте больше число.");
                    }
                    else
                    {
                        Console.WriteLine("Слишком много! Попробуйте меньшее число.");
                    }
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите правильное число!");
                }
            }
            
            if (!pobedil)
            {
                Console.WriteLine($"\n😞 Игра окончена! Загаданное число было {zagadannoeCHislo}");
            }
            
            Console.WriteLine("Спасибо за игру!");
            Console.ReadLine();
        }
    }
}

/* 
ПРОЕКТ 1: Улучшите игру угадывания
1. Добавьте уровни сложности (Легкий: 1-50, Средний: 1-100, Сложный: 1-200)
2. Ведите учет рекордов (наименьшее количество попыток)
3. Позвольте игроку играть несколько раундов
4. Добавьте подсказки как "очень близко", когда остается 5 чисел
*/
