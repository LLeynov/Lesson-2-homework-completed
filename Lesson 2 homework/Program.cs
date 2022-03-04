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
            /*Для полного закрепления понимания простых типов найдите любой чек, либо фотографию этого чека в интернете и схематично нарисуйте его в консоли,
            * только за место динамических, по вашему мнению, данных (это может быть дата, название магазина, сумма покупок) подставляйте переменные, которые
            были заранее заготовлены до вывода на консоль. */
           
            Console.WriteLine("{0,35}","ООО СуперЧек.ru "); //Спасибо Эмилю,подсказал,как сдвинуть)
            
            int checknumber = 42011;
            Console.WriteLine("{0,34}","Номер чека :" + checknumber); 
            
            string surname = ("Иванов");
            Console.WriteLine("{0,34}","Кассир : " + surname);

            string firstposname = ("Кирпич пустотельный одинарный м-150, 800 штук.");
            int firstposprice = (8176) ;
            Console.WriteLine("1. " + firstposname);
            Console.WriteLine("Стоимость................................... " + firstposprice);

            string secondposname = (" Цемент ПЦ-400 Д20 (МЕШКАХ)");
            int secondposprice = 5400;
            Console.WriteLine("2." + secondposname);
            Console.WriteLine("Стоимость................................... " + secondposprice);

            string thirdposname = (" Щебень фракция 20х40 т.");
            int thirdposprice = 2400;
            Console.WriteLine("3." + thirdposname);
            Console.WriteLine("Стоимость...................................." + (thirdposprice));

            string fourthposname = (" Гвозди жидкие/ 310 мл, 4 штуки.");
            int fourthposprice = 652;
            Console.WriteLine("4." + fourthposname);
            Console.WriteLine("Стоимость....................................." + (fourthposprice));

            Console.WriteLine("=================================================");
            int fullcheck = (firstposprice + secondposprice + thirdposprice + fourthposprice);
            Console.WriteLine("Всего......................................."+ fullcheck);
            Console.WriteLine("{0,45}","ККМ 00000000 ИНН 000000000000 №" + checknumber);

            
            Console.WriteLine(DateTime.Now + "........................" + surname);
            int sellnumber = 2890;
            Console.WriteLine("{0,32}", "Продажа №" + sellnumber);
            
            Console.WriteLine("1..........................................." + fullcheck);
            Console.WriteLine("ИТОГ                                       =" + fullcheck);//Хотел утащить у кого-нибудь код в интернете,чтоб сделать слово "итог" большим,но подумал,что не надо,так как я сам пока не понял,как так сделать.
            Console.WriteLine("Наличными                                  =" + fullcheck);










        }
    }
}
