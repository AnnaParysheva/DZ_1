using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Упражнение 2.1 Написать программу, которая спрашивает имя пользователя, и затем приветствует пользователя по имени. (Создать консольное приложение.)
            Console.WriteLine("Как вас зовут?");
            string name=Console.ReadLine();
            Console.WriteLine($"Привет, {name}");
            //Упражнение 2.2 Написать программу, которой на вход подается два целых числа, на выходе – результат деления одного числа на другое. Предусмотреть обработку исключительной ситуации, возникающей при делении числа на ноль.
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (b!=0)
            {
                Console.WriteLine((double) a/b);
            }
            else
            {
                Console.WriteLine("Делить на 0 нельзя!");
            }
            //Домашнее задание 2.1 Прочитать букву с экрана и вывести на печать следующую за ней букву в алфавитном порядке.
            string alfavit = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            Console.Write("Введите букву: ");
            char bukva1 = Convert.ToChar(Console.ReadLine());
            if (bukva1=='я')
            {
                Console.WriteLine("а");
            }
            else
            {
                for (int i=0;i<alfavit.Length;i++)
                {
                    if (alfavit[i]==bukva1)
                    {
                        int ind = i;
                        Console.WriteLine(alfavit[ind+1]);
                        break;
                    }
                }
            }
            //Домашнее задание 2.2 Написать программу, которая решает квадратное уравнение.Входные данные – коэффициенты уравнения, выходные –найденные корни.
            Console.Write("a*x^2+b*x+c=0");
            Console.Write("Введите коэффициент a ");
            int k_a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите коэффициент b ");
            int k_b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите коэффициент c ");
            int k_c = Convert.ToInt32(Console.ReadLine());
            var D = (k_b * k_b) - (4 * k_a * k_c);
            if (D < 0)
            {
                Console.WriteLine("Корней нет!");
            }
            else
            {
                if (D == 0)
                {
                    Console.WriteLine($"x1={(k_b * k_b) / (2 * k_a)}");
                }
                else
                {
                    Console.WriteLine($"x1={(-k_b + Math.Sqrt(D)) / (2 * k_a)}");
                    Console.WriteLine($"x2={(-k_b - Math.Sqrt(D)) / (2 * k_a)}");
                }
            }
            Console.ReadKey();
        }
    }
}
