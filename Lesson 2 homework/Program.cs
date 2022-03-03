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
            //Определить, является ли введённое пользователем число чётным.
            int a;
            Console.WriteLine("введите число: ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("четное число");
            }
            else
            {
                Console.WriteLine("нечетное");
            }
            Console.ReadKey();
        }
    }
}
