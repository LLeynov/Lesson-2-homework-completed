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
            //Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.

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

            Console.WriteLine("Средняя температура за сутки составляет : " + ((a + b) / 2));

        }
    }
}
