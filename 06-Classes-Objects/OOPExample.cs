using System;

namespace OOPPrinciples
{
    // Абстрактный класс, демонстрирующий Абстракцию и Инкапсуляцию
    public abstract class Zhivotnoe
    {
        private string imya; // Инкапсулированное поле

        public string Imya // Свойство для доступа к полю
        {
            get { return imya; }
            set { imya = value; }
        }

        public Zhivotnoe(string imya)
        {
            this.imya = imya;
        }

        // Абстрактный метод для Абстракции
        public abstract void Govorit();
    }

    // Наследование - Собака наследует от Животного
    public class Sobaka : Zhivotnoe
    {
        public Sobaka(string imya) : base(imya) {}

        // Полиморфизм - разная реализация
        public override void Govorit()
        {
            Console.WriteLine($"{Imya} говорит: Гав!");
        }
    }

    // Наследование - Кошка наследует от Животного
    public class Koshka : Zhivotnoe
    {
        public Koshka(string imya) : base(imya) {}

        // Полиморфизм - разная реализация
        public override void Govorit()
        {
            Console.WriteLine($"{Imya} говорит: Мяу!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Zhivotnoe sobaka = new Sobaka("Бобик");
            Zhivotnoe koshka = new Koshka("Мурка");

            // Полиморфизм в действии
            sobaka.Govorit(); // Бобик говорит: Гав!
            koshka.Govorit(); // Мурка говорит: Мяу!
            
            Console.ReadLine();
        }
    }
}

/* 
ПРОДВИНУТОЕ ЗАДАНИЕ 10: Расширьте пример с Животными
1. Добавьте класс Птица, который наследует от Животного
2. Добавьте виртуальный метод ИздатьЗвук() в класс Животное
3. Добавьте свойства как Возраст, Цвет в класс Животное
4. Создайте класс Зоопарк, который управляет несколькими животными
5. Добавьте методы как ПокормитьЖивотных(), СписокВсехЖивотных() в Зоопарк
*/
