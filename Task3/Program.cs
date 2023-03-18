using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
    Потрібно описати структуру з іменем Price, що містить такі поля:
        • назва товару;
        • назва магазину, де продається товар;
        • вартість товару у гривнях.
    Написати програму, яка виконує такі дії:
        • введення з клавіатури даних до масиву, що складається з двох елементів типу Price 
         (записи мають бути впорядковані в алфавітному порядку за назвами магазинів);
        • виведення на екран інформації про товари, що продаються в магазині, назва якого введена з клавіатури 
         (якщо такого магазину немає, вивести виняток).
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            PriceTable priceTable = new PriceTable(); //Создание экземпляра класса PriceTable и инициализация конструктором по умолчанию

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(priceTable[i]); //Отображение содержимого priceTable
            }

            Console.WriteLine("Введите номер товара для поиска:");
            string product = Console.ReadLine();

            Console.WriteLine(priceTable[product]); //Отображение результата поиска

            // Delay.
            Console.ReadKey();
        }
    }
}
