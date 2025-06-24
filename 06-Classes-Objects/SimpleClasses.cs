using System;

namespace ClassesObjects
{
    // Простой пример класса для начинающих
    class Chelovek
    {
        // Поля (приватные)
        private string imya;
        private int vozrast;
        
        // Свойства (публичный доступ к приватным полям)
        public string Imya
        {
            get { return imya; }
            set { imya = value; }
        }
        
        public int Vozrast
        {
            get { return vozrast; }
            set 
            { 
                if (value >= 0) // Базовая проверка
                    vozrast = value;
            }
        }
        
        // Конструктор
        public Chelovek(string imya, int vozrast)
        {
            this.imya = imya;
            this.vozrast = vozrast;
        }
        
        // Методы
        public void Predstavitsya()
        {
            Console.WriteLine($"Привет, меня зовут {imya}, мне {vozrast} лет.");
        }
        
        public void DenRozhdeniya()
        {
            vozrast++;
            Console.WriteLine($"С днем рождения! {imya} теперь {vozrast} лет.");
        }
        
        public bool Sovershennoletniy()
        {
            return vozrast >= 18;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объектов
            Chelovek chelovek1 = new Chelovek("Алиса", 25);
            Chelovek chelovek2 = new Chelovek("Боб", 17);
            
            // Использование методов объектов
            chelovek1.Predstavitsya();
            chelovek2.Predstavitsya();
            
            // Проверка совершеннолетия
            if (chelovek1.Sovershennoletniy())
            {
                Console.WriteLine($"{chelovek1.Imya} совершеннолетний.");
            }
            
            if (!chelovek2.Sovershennoletniy())
            {
                Console.WriteLine($"{chelovek2.Imya} еще несовершеннолетний.");
            }
            
            // Использование свойств
            Console.WriteLine($"\nИзменяем возраст {chelovek2.Imya}...");
            chelovek2.Vozrast = 18;
            chelovek2.Predstavitsya();
            
            // День рождения
            chelovek1.DenRozhdeniya();
            
            Console.ReadLine();
        }
    }
}

/* 
ЗАДАНИЕ 9: Создайте свои классы
1. Создайте класс Книга с полями название, автор, страницы и методом ПоказатьИнфо
2. Создайте класс Автомобиль с полями марка, модель, год и методами Завести(), Остановить()
3. Создайте класс БанковскийСчет с балансом и методами Пополнить(), Снять()
4. Создайте несколько объектов и протестируйте все методы
*/
