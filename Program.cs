//***********************************************************
//* Практическая работа № 5                                 *
//* Выполнил: Кузин. Я. Н., группа 2ИСПд                    *
//* Задание: составить программу работы линейного алгоритма *
//***********************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, t, m, k, v1, v2; // ввод переменных
            Console.WriteLine("Магазин");
            Console.Write("Здравствуйте!");
            Console.Write("\nЗаплатите за мороженое = "); // Ввод данных
            n = Int32.Parse(Console.ReadLine());
            Console.Write("Заплатите за лимонад  = ");
            t = Int32.Parse(Console.ReadLine());
            Console.Write("Сколько стаканчиков мороженного? = ");
            m = Int32.Parse(Console.ReadLine());
            Console.Write("Сколько бутылок лимонада? = ");
            k = Int32.Parse(Console.ReadLine());
            v1 = m * n; v2 = k * t;
            if (n > 10 & t > 15)
                Console.WriteLine("Возьмите сдачу");
            if (n < 5 & t < 10)
                Console.WriteLine("Нужно доплатить");
            if (n >= 5 & t >= 10)
                Console.WriteLine("Спасибо за покупку!");
            Console.ReadKey();



        }
    }
}
