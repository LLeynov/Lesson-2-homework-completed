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
            //(*) Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима».

            string maxtemp;
            Console.WriteLine("Пожалуйста,введите максимальную температуру за сутки.");
            maxtemp = Console.ReadLine();
            int a = Convert.ToInt32(maxtemp);
            Console.WriteLine("Максимальная температура за сутки была " + maxtemp + " градусов . ");

            string mintemp;
            Console.WriteLine("Пожалуйста,введите минимальную температуру за сутки.");
            mintemp = Console.ReadLine();
            int b = Convert.ToInt32(mintemp);
            Console.WriteLine("Минимальная температура за сутки была " + mintemp + " градусов . ");

            int averagetemp = (a + b) / 2;

            Console.WriteLine("Средняя температура за сутки составляет : " + averagetemp);


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

            if ((n == 1 || n == 12 || n == 2) && averagetemp >= 0)
                Console.WriteLine(("Средняя температура за сутки составляет : " + averagetemp + " градусов") + ",дождливая зима :( ");
          
            
            


        }
    }
}
