using System;

namespace VariablesDataTypes
{
    class Variables
    {
        static void Main(string[] args)
        {
            // Целочисленные типы
            int vozrast = 25;
            long naselenie = 7800000000L;
            
            // Типы с плавающей точкой
            double cena = 19.99;
            float temperatura = 23.5f;
            
            // Символы и строки
            char ocenka = 'A';
            string imya = "Иван Иванов";
            
            // Логический тип
            bool student = true;
            
            // Отображаем все переменные
            Console.WriteLine("Имя: " + imya);
            Console.WriteLine("Возраст: " + vozrast);
            Console.WriteLine("Оценка: " + ocenka);
            Console.WriteLine("Цена: " + cena + " руб.");
            Console.WriteLine("Температура: " + temperatura + "°C");
            Console.WriteLine("Студент: " + student);
            Console.WriteLine("Население мира: " + naselenie);
            
            Console.ReadLine();
        }
    }
}

/* 
ЗАДАНИЕ 3: Создайте свои переменные
1. Создайте переменные для вашей личной информации (имя, возраст, рост и т.д.)
2. Создайте переменные для вашего любимого фильма и его рейтинга
3. Отобразите всю информацию в красивом формате
4. Попробуйте использовать интерполяцию строк: $"Меня зовут {imya}"
*/
