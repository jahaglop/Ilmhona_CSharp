using System;
using System.Collections.Generic;

namespace PracticeProjects
{
    class TodoListApp
    {
        static List<string> spisokZadach = new List<string>();
        static List<bool> statusVypolneniya = new List<bool>();
        
        static void Main(string[] args)
        {
            Console.WriteLine("=== ПРИЛОЖЕНИЕ СПИСОК ДЕЛ ===");
            
            while (true)
            {
                PokazatMenu();
                string vybor = Console.ReadLine();
                
                switch (vybor)
                {
                    case "1":
                        DobavitZadachu();
                        break;
                    case "2":
                        PosmotretZadachi();
                        break;
                    case "3":
                        OtmetitVypolneno();
                        break;
                    case "4":
                        UdalitZadachu();
                        break;
                    case "5":
                        OchistitVseZadachi();
                        break;
                    case "6":
                        Console.WriteLine("До свидания! Оставайтесь продуктивными!");
                        return;
                    default:
                        Console.WriteLine("Неверный выбор! Попробуйте снова.\n");
                        break;
                }
            }
        }
        
        static void PokazatMenu()
        {
            Console.WriteLine("\n=== МЕНЮ СПИСКА ДЕЛ ===");
            Console.WriteLine("1. Добавить задачу");
            Console.WriteLine("2. Посмотреть задачи");
            Console.WriteLine("3. Отметить задачу как выполненную");
            Console.WriteLine("4. Удалить задачу");
            Console.WriteLine("5. Очистить все задачи");
            Console.WriteLine("6. Выход");
            Console.Write("Выберите опцию: ");
        }
        
        static void DobavitZadachu()
        {
            Console.Write("Введите новую задачу: ");
            string zadacha = Console.ReadLine();
            
            if (!string.IsNullOrWhiteSpace(zadacha))
            {
                spisokZadach.Add(zadacha);
                statusVypolneniya.Add(false);
                Console.WriteLine($"✅ Задача '{zadacha}' успешно добавлена!");
            }
            else
            {
                Console.WriteLine("❌ Задача не может быть пустой!");
            }
        }
        
        static void PosmotretZadachi()
        {
            Console.WriteLine("\n=== ВАШИ ЗАДАЧИ ===");
            
            if (spisokZadach.Count == 0)
            {
                Console.WriteLine("Задач пока нет. Добавьте задачи для начала!");
                return;
            }
            
            for (int i = 0; i < spisokZadach.Count; i++)
            {
                string status = statusVypolneniya[i] ? "✅" : "⭕";
                string tekstZadachi = statusVypolneniya[i] ? $"[ВЫПОЛНЕНО] {spisokZadach[i]}" : spisokZadach[i];
                Console.WriteLine($"{i + 1}. {status} {tekstZadachi}");
            }
            
            int vypolnenoKolichestvo = 0;
            foreach (bool vypolneno in statusVypolneniya)
            {
                if (vypolneno) vypolnenoKolichestvo++;
            }
            
            Console.WriteLine($"\nПрогресс: {vypolnenoKolichestvo}/{spisokZadach.Count} задач выполнено");
        }
        
        static void OtmetitVypolneno()
        {
            PosmotretZadachi();
            
            if (spisokZadach.Count == 0) return;
            
            Console.Write("Введите номер задачи для отметки как выполненной: ");
            if (int.TryParse(Console.ReadLine(), out int nomerZadachi))
            {
                if (nomerZadachi >= 1 && nomerZadachi <= spisokZadach.Count)
                {
                    int indeks = nomerZadachi - 1;
                    if (!statusVypolneniya[indeks])
                    {
                        statusVypolneniya[indeks] = true;
                        Console.WriteLine($"✅ Задача '{spisokZadach[indeks]}' отмечена как выполненная!");
                    }
                    else
                    {
                        Console.WriteLine("ℹ️ Эта задача уже выполнена!");
                    }
                }
                else
                {
                    Console.WriteLine("❌ Неверный номер задачи!");
                }
            }
            else
            {
                Console.WriteLine("❌ Пожалуйста, введите правильный номер!");
            }
        }
        
        static void UdalitZadachu()
        {
            PosmotretZadachi();
            
            if (spisokZadach.Count == 0) return;
            
            Console.Write("Введите номер задачи для удаления: ");
            if (int.TryParse(Console.ReadLine(), out int nomerZadachi))
            {
                if (nomerZadachi >= 1 && nomerZadachi <= spisokZadach.Count)
                {
                    int indeks = nomerZadachi - 1;
                    string udalennayaZadacha = spisokZadach[indeks];
                    spisokZadach.RemoveAt(indeks);
                    statusVypolneniya.RemoveAt(indeks);
                    Console.WriteLine($"🗑️ Задача '{udalennayaZadacha}' удалена!");
                }
                else
                {
                    Console.WriteLine("❌ Неверный номер задачи!");
                }
            }
            else
            {
                Console.WriteLine("❌ Пожалуйста, введите правильный номер!");
            }
        }
        
        static void OchistitVseZadachi()
        {
            if (spisokZadach.Count == 0)
            {
                Console.WriteLine("Нет задач для очистки!");
                return;
            }
            
            Console.Write("Вы уверены, что хотите очистить все задачи? (д/н): ");
            string podtverzhdenie = Console.ReadLine().ToLower();
            
            if (podtverzhdenie == "д" || podtverzhdenie == "да")
            {
                spisokZadach.Clear();
                statusVypolneniya.Clear();
                Console.WriteLine("🧹 Все задачи очищены!");
            }
            else
            {
                Console.WriteLine("Операция очистки отменена.");
            }
        }
    }
}

/* 
ПРОЕКТ 3: Улучшите список дел
1. Добавьте приоритеты задач (Высокий, Средний, Низкий)
2. Добавьте сроки выполнения для задач
3. Сохраняйте задачи в файл и загружайте их при запуске программы
4. Добавьте категории/теги для задач
5. Добавьте функцию поиска для нахождения конкретных задач
*/
