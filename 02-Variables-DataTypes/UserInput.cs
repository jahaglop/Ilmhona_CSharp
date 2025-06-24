using System;

namespace VariablesDataTypes
{
    class UserInput
    {
        static void Main(string[] args)
        {
            // Получение ввода от пользователя
            Console.Write("Введите ваше имя: ");
            string imyaPolzovatelya = Console.ReadLine();
            
            Console.Write("Введите ваш возраст: ");
            string vvodVozrasta = Console.ReadLine();
            int vozrastPolzovatelya = int.Parse(vvodVozrasta); // Преобразование строки в int
            
            Console.Write("Введите ваш рост в метрах: ");
            string vvodRosta = Console.ReadLine();
            double rostPolzovatelya = double.Parse(vvodRosta);
            
            // Отображение информации
            Console.WriteLine("\n--- Ваша информация ---");
            Console.WriteLine($"Имя: {imyaPolzovatelya}");
            Console.WriteLine($"Возраст: {vozrastPolzovatelya} лет");
            Console.WriteLine($"Рост: {rostPolzovatelya} метров");
            Console.WriteLine($"В следующем году вам будет {vozrastPolzovatelya + 1} лет!");
            
            Console.ReadLine();
        }
    }
}

/* 
ЗАДАНИЕ 4: Интерактивная программа
1. Спросите у пользователя его любимую еду и цену
2. Спросите два числа и вычислите их сумму, разность и произведение
3. Спросите год рождения и вычислите, сколько лет будет в 2030 году
4. Добавьте обработку ошибок, используя TryParse вместо Parse
*/
