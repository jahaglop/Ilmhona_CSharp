using System;

namespace MethodsFunctions
{
    class Methods
    {
        static void Main(string[] args)
        {
            // Вызов методов
            SkazatPrivet();
            SkazatPrivet("Алиса");
            
            int rezultat = SlozhitChisla(5, 3);
            Console.WriteLine($"5 + 3 = {rezultat}");
            
            double ploschad = VychislitPloschad(5.0);
            Console.WriteLine($"Площадь круга с радиусом 5: {ploschad:F2}");
            
            // Интерактивные примеры
            Console.Write("Введите два числа для умножения: ");
            int chislo1 = int.Parse(Console.ReadLine());
            int chislo2 = int.Parse(Console.ReadLine());
            
            int proizvedenie = Umnozhit(chislo1, chislo2);
            Console.WriteLine($"{chislo1} x {chislo2} = {proizvedenie}");
            
            Console.ReadLine();
        }
        
        // Метод без параметров и без возвращаемого значения
        static void SkazatPrivet()
        {
            Console.WriteLine("Привет, Мир!");
        }
        
        // Метод с параметром и без возвращаемого значения
        static void SkazatPrivet(string imya)
        {
            Console.WriteLine($"Привет, {imya}!");
        }
        
        // Метод с параметрами и возвращаемым значением
        static int SlozhitChisla(int a, int b)
        {
            return a + b;
        }
        
        // Метод с различными типами данных
        static double VychislitPloschad(double radius)
        {
            return Math.PI * radius * radius;
        }
        
        static int Umnozhit(int x, int y)
        {
            return x * y;
        }
    }
}

/* 
ЗАДАНИЕ 7: Создайте свои методы
1. Создайте метод, который вычисляет квадрат числа
2. Создайте метод, который проверяет, четное ли число (возвращает bool)
3. Создайте метод, который конвертирует градусы Цельсия в Фаренгейты
4. Создайте метод, который находит максимум из трех чисел
5. Создайте метод, который рисует узор из звездочек (например, треугольник)
*/
