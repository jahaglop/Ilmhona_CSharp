using System;
using System.Collections.Generic;

namespace ArraysCollections
{
    class Arrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== МАССИВЫ ===");
            
            // Объявление и инициализация массивов
            int[] chisla = {1, 2, 3, 4, 5};
            string[] frukty = {"яблоко", "банан", "апельсин", "виноград"};
            
            // Доступ к элементам массива
            Console.WriteLine($"Первое число: {chisla[0]}");
            Console.WriteLine($"Последний фрукт: {frukty[frukty.Length - 1]}");
            
            // Перебор массивов циклом
            Console.WriteLine("\nВсе числа:");
            for (int i = 0; i < chisla.Length; i++)
            {
                Console.WriteLine($"Индекс {i}: {chisla[i]}");
            }
            
            Console.WriteLine("\nВсе фрукты:");
            foreach (string frukt in frukty)
            {
                Console.WriteLine($"Фрукт: {frukt}");
            }
            
            Console.WriteLine("\n=== СПИСКИ ===");
            
            // Списки более гибкие, чем массивы
            List<string> goroda = new List<string>();
            goroda.Add("Москва");
            goroda.Add("Лондон");
            goroda.Add("Токио");
            goroda.Add("Париж");
            
            Console.WriteLine($"Количество городов: {goroda.Count}");
            
            // Добавление пользовательского ввода в список
            Console.Write("Введите название города: ");
            string gorodPolzovatelya = Console.ReadLine();
            goroda.Add(gorodPolzovatelya);
            
            Console.WriteLine("\nВсе города:");
            foreach (string gorod in goroda)
            {
                Console.WriteLine($"Город: {gorod}");
            }
            
            // Поиск элементов
            if (goroda.Contains("Лондон"))
            {
                Console.WriteLine("Лондон есть в списке!");
            }
            
            Console.ReadLine();
        }
    }
}

/* 
ЗАДАНИЕ 8: Работа с массивами и списками
1. Создайте массив ваших любимых фильмов и отобразите их
2. Создайте список оценок студентов и вычислите средний балл
3. Попросите пользователя ввести 5 чисел, сохраните в массив, найдите наибольшее
4. Создайте список покупок (List<string>) с функцией добавления/удаления
5. Создайте простую телефонную книгу, используя массивы (имена и номера телефонов)
*/
