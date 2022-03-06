using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_homework
{
    internal class Program
    {
        [Flags]
        public enum WorkSchedule 
        { 
            Понедельник = 0b_0000001,
            Вторник = 0b_0000010,
            Среда = 0b_0000100,
            Четверг = 0b_0001000,
            Пятница = 0b_0010000,
            Суббота = 0b_0100000,
            Воскресенье = 0b_1000000,
        }
        static void Main(string[] args)
        {
            /*(*) Для полного закрепления битовых масок, попытайтесь создать универсальную структуру расписания недели, к примеру, чтобы описать 
            * работу какого либо офиса. Явный пример - офис номер 1 работает со вторника до пятницы, 
            офис номер 2 работает с понедельника до воскресенья и выведите его на экран консоли. */

            //WorkSchedule Shop = WorkSchedule.Вторник | WorkSchedule.Среда | WorkSchedule.Четверг | WorkSchedule.Пятница;
            WorkSchedule Shop = (WorkSchedule) 0b_0011110;


            /*WorkSchedule Office = WorkSchedule.Понедельник | WorkSchedule.Вторник | WorkSchedule.Среда | WorkSchedule.Четверг |
            WorkSchedule.Пятница | WorkSchedule.Суббота | WorkSchedule.Воскресенье; */ 

            WorkSchedule Office = (WorkSchedule) 0b_1111111;

            Console.WriteLine("Рабочие дни офиса : " + Office + ".");
            Console.WriteLine("Рабочие дни магазина : " + Shop + ".");








        }
    }
}
