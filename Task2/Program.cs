using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*
    Потрібно описати структуру з ім'ям Worker, що містить такі поля:
    • прізвище та ініціали працівника;
    • назва займаної посади;
    • рік надходження працювати.
    Написати програму, яка виконує такі дії:
    • введення з клавіатури даних до масиву, що складається з п'яти елементів типу Worker (записи мають бути впорядковані за абеткою);
    • якщо значення року введено не у відповідному форматі видає виняток;
    • виведення на екран прізвища працівника, стаж роботи якого перевищує введене значення.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Company comp = new Company(); //Создание экземпляра класса Company
            Console.WriteLine(comp[5]); //Отображение результата вызова индексатора

            // Delay.
            Console.ReadKey();
        }
    }
}

