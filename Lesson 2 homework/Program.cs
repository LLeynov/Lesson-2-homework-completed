using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Запросить у пользователя порядковый номер текущего месяца и вывести его название.
           

                Console.WriteLine("Введи номер месяца");
                int n = int.Parse(Console.ReadLine());
                if (n == 1)
                    Console.WriteLine("Вы ввели номер  " + n + ", месяц под этим номером -  Январь.");
                if (n == 2)
                    Console.WriteLine("Вы ввели номер " + n + " , месяц под этим номером -   Февраль.");
                if (n == 3)
                    Console.WriteLine("Вы ввели номер " + n + " , месяц под этим номером -   Март.");
                if (n == 4)
                    Console.WriteLine("Вы ввели номер " + n + " , месяц под этим номером -   Апрель.");
                if (n == 5)
                    Console.WriteLine("Вы ввели номер " + n + " , месяц под этим номером -   Май.");
                if (n == 6)
                    Console.WriteLine("Вы ввели номер " + n + " , месяц под этим номером -   Июнь.");
                if (n == 7)
                    Console.WriteLine("Вы ввели номер " + n + " , месяц под этим номером -   Июль.");
                if (n == 8)
                    Console.WriteLine("Вы ввели номер " + n + " , месяц под этим номером -   Август.");
                if (n == 9)
                    Console.WriteLine("Вы ввели номер " + n + " , месяц под этим номером -    Сентябрь.");
                if (n == 10)
                    Console.WriteLine("Вы ввели номер " + n + " , месяц под этим номером -   Октябрь.");
                if (n == 11)
                    Console.WriteLine("Вы ввели номер" + n + "  , месяц под этим номером -   Ноябрь.");
                if (n == 12)
                    Console.WriteLine("Вы ввели номер " + n + " , месяц под этим номером -  Декабрь.");
                if (n >= 13 || n == 0)
                    Console.WriteLine("Неправильно введен номер месяца,перезапустите программу.");
               
            
        }
    }
}
