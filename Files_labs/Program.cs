using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_labs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Вывести на экран число e (основание натурального логарифма) с точностью до десятых.
            double e = 2.7;
            Console.WriteLine(e);
            //2. Вывести на экран числа 50 и 10 одно под другим
            Console.WriteLine(50);
            Console.WriteLine(10);
            //3. Составить программу вывода на экран «столбиком» четырех любых чисел.
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);
            Console.WriteLine(4);
            //4. Пользователь вводит число. Выведите на экран число, которое больше введенного на 10.
            Console.WriteLine("Введите число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + 10);
            //5. Дана сторона квадрата. Найти его периметр.
            Console.WriteLine("Введите сторону квадрата");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Периметр квадрата равен {4*b}");
            //6. Дан радиус окружности. Найти длину окружности и площадь круга.
            Console.WriteLine("Введите радиус окружности:");
            int r = Convert.ToInt32(Console.ReadLine());
            double pi = 3.14;
            Console.WriteLine(2 * pi * r);
            Console.WriteLine(pi * r*r);
            //7. Найти значение y=cos(x) 
            Console.WriteLine("Введите значение гипотенузы:");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение прилежащего катета:");
            int m= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"y=cos(x)={(double) m/d}");
            Console.ReadKey();
        }
    }
}
