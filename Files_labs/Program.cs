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
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Число, которое больше введенного на 10 равно {a+10}");
            //5. Дана сторона квадрата. Найти его периметр.
            Console.Write("Введите сторону квадрата ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Периметр квадрата равен {4*b}");
            //6. Дан радиус окружности. Найти длину окружности и площадь круга.
            Console.Write("Введите радиус окружности: ");
            int r = Convert.ToInt32(Console.ReadLine());
            double pi = 3.14;
            Console.WriteLine($"Длина окружности: {2 * pi * r}");
            Console.WriteLine($"Площадь круга:{pi * r * r}");
            //7. Найти значение y=cos(x) 
            Console.WriteLine("Введите значение x: ");
            int gradyci = Convert.ToInt32(Console.ReadLine());
            double radians = gradyci * (Math.PI / 180);
            double cos = Math.Cos(radians);
            Console.WriteLine($"y=cos(x)={cos}");
            /* Console.WriteLine("Введите значение гипотенузы:");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение прилежащего катета:");
            int m= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"y=cos(x)={(double) m/d}");*/
            //8. Даны основания и высота равнобедренной трапеции. Найти ее периметр
            Console.Write("Введите длину меньшего основания: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите длину большего основания: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите длину высоты: ");
            int h = Convert.ToInt32(Console.ReadLine());
            var bok = Math.Sqrt(((c - n) / 2) * ((c - n) / 2) + h * h);
            Console.WriteLine($"Периметр трапеции равен {2*bok + n + c}");
            //9. Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки, если купили x кг конфет, у кг печенья и z кг яблок.
            Console.Write("Введите стоимость 1 кг конфет: ");
            int konfeti = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите стоимость 1 кг печенья: ");
            int pechenki = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите стоимость 1 кг яблок: ");
            int yabloki = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сколько кг конфет купили: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сколько кг печенья купили: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сколько кг яблок купили: ");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Стоимость всей покупки составляет: {konfeti*x+pechenki*y+yabloki*z}");
            /* 10. Напишите программу, выводит на экран три строки "Мир", "Труд" и "Май" (кавычки не нужны).Причём сделайте, чтобы выводилось сначала так:
            Мир Труд Май
            Затем так:
            Мир
                  Труд
                         Май */
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир");
            Console.WriteLine("      Труд");
            Console.WriteLine("             Май");
            //11. Программа просит пользователя ввести 2 числовые переменные. А после она меняет их местами и выводит результат на экран. Но, так как пользователь может ошибиться, необходимо предусмотреть тот факт, что пользователь может ввести, например, букву или строку, а так же учесть, что число может быть дробным, и для выделения её дробной части одни используют точку, другие – запятую.
            Console.Write("Введите первую числовую переменную ");
            var peremen_1 = Console.ReadLine();
            Console.Write("Введите вторую числовую переменную ");
            var peremen_2 = Console.ReadLine();
            Console.WriteLine(peremen_2);
            Console.WriteLine(peremen_1);
            //12. Программа для подсчета периметра и площади фигур (треугольник, четырехугольник, круг). Пользователь выбирает фигуру, указывает, что программа будет считать – площадь или периметр.Задаётся все необходимые значения, а на основе полученных результатов, программа должна подсчитать, какими могли бы быть периметры или площади остальных фигур.
            Console.Write("Выберите фигуру: 1. Треугольник; 2. Четырехугольник; 3. Круг. Введите цифру: ");
            int num_f = Convert.ToInt32(Console.ReadLine());
            Console.Write("Выберите то, что хотите посчитать: 1 - Площадь, 2 - Периметр). Введите цифру: ");
            int per_plo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите длину стороны: ");
            int storona = Convert.ToInt32(Console.ReadLine());
            int per_treug = 3 * storona;
            int per_chet = 4 * storona;
            double per_kruga = 2 * 3.14 * storona;
            double plo_treug = (double)((storona * storona * Math.Sqrt(3)) / 4);
            int plo_chet=storona*storona;
            double plo_kruga = 3.14 * storona * storona;
            if (num_f == 1) 
            {
                if (per_plo == 1) 
                {                 
                    Console.WriteLine($"Площадь четырехугольника равна {plo_chet}");
                    Console.WriteLine($"Площадь круга равна {plo_kruga}");
                }
                else
                {
                    Console.WriteLine($"Периметр четырехугольника равен {per_chet}");
                    Console.WriteLine($"Периметр круга равен {per_kruga}");
                }
            }
            else if (num_f == 2)
            {           
                if (per_plo == 1) 
                {
                    Console.WriteLine($"Площадь треугольника равна {plo_treug}");
                    Console.WriteLine($"Площадь круга равна {plo_kruga}");
                }
                else 
                {
                    Console.WriteLine($"Периметр треугольника равен {per_treug}");
                    Console.WriteLine($"Периметр круга равен {per_kruga}");
                }
            }
            else if (num_f == 3) 
            {              
                if (per_plo == 1)
                {
                    Console.WriteLine($"Площадь четырехугольника равна {plo_chet}");
                    Console.WriteLine($"Площадь треугольника равна {plo_treug}");
                }
                else 
                {
                    Console.WriteLine($"Периметр четырехугольника равен {per_chet}");
                    Console.WriteLine($"Периметр треугольника равен {per_treug}");
                }
            }
            //13. Составить программу вывода на экран числа, вводимого с клавиатуры. Вводимому числу должно предшествовать сообщение «Вы ввели число».
            Console.Write("Введите любое число ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вы ввели число {num}");
            /* 14. Составить программу вывода на экран следующей информации:
            2 кг
            13 17 */
            Console.WriteLine("2 кг");
            Console.WriteLine("13 17");
            //15. Составить программу вывода на экран «столбиком» четырех случайных чисел.
            Console.Write("Введите любое число ");
            double chislo_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите любое число ");
            double chislo_2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите любое число ");
            double chislo_3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите любое число ");
            double chislo_4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(chislo_1);
            Console.WriteLine(chislo_2);
            Console.WriteLine(chislo_3);
            Console.WriteLine(chislo_4);
            //16. Найти корни квадратного уравнения(коэффициента задаются пользователем с клавиатуры)
            Console.Write("a*x^2+b*x+c=0");
            Console.Write("Введите коэффициент a ");
            int k_a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите коэффициент b ");
            int k_b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите коэффициент c ");
            int k_c = Convert.ToInt32(Console.ReadLine());
            var D=(k_b*k_b)-(4*k_a*k_c);
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
                    Console.WriteLine($"x1={(-k_b - Math.Sqrt(D)) / (2 * k_a)}");
                }
            }
            //17. Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее геометрическое.
            Console.Write("Введите число ");
            int a_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число ");
            int a_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Convert.ToDouble((a_1 + a_2) / 2));
            Console.WriteLine(Math.Sqrt(a_1 * a_2));
            //18. Известны координаты на плоскости двух точек. Составить программу вычисления расстояния между ними.
            Console.Write("Введите x1 ");
            int x_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите y1 ");
            int y_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите x2 ");
            int x_2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите y2 ");
            int y_2 = Convert.ToInt32(Console.ReadLine());
            double rasstoyanie = Math.Sqrt(((x_2 - x_1)*(x_2 - x_1))+((y_2-y_1)*(y_2-y_1)));
            Console.WriteLine($"Расстояние между 2 точками с координатами ({x_1}, {y_1}) и ({x_2}, {y_2}) равно {rasstoyanie}");
            //19(а).Составить программу обмена значениями трех переменных величин а, b, c по следующим двум схемам: b присвоить значение c, а присвоить значение b, с присвоить значение а;
            Console.Write("Введите a ");
            var per_a1 = Console.ReadLine();
            Console.Write("Введите b ");
            var per_b1 = Console.ReadLine();
            Console.Write("Введите c ");
            var per_c1 = Console.ReadLine();
            var per_11 = per_a1;
            var per_21 = per_b1;
            var per_31 = per_c1;
            per_b1 = per_31;
            per_a1 = per_21;
            per_c1 = per_11;
            Console.WriteLine($"a={per_a1}, b={per_b1}, c={per_c1}");
            //б) b присвоить значение а, с присвоить значение b, а присвоить значение с.
            Console.Write("Введите a ");
            var per_a = Console.ReadLine();
            Console.Write("Введите b ");
            var per_b = Console.ReadLine();
            Console.Write("Введите c ");
            var per_c = Console.ReadLine();
            var per_1 = per_a;
            var per_2 = per_b;
            var per_3 = per_c;
            per_b = per_1;
            per_a = per_3;
            per_c = per_2;
            Console.WriteLine($"a={per_a}, b={per_b}, c={per_c}");
            /*20. С начала суток прошло n секунд. Определить:
            а) сколько полных часов прошло с начала суток;
            б) сколько полных минут прошло с начала очередного часа;
            в) сколько полных секунд прошло с начала очередной минуты.*/
            Console.Write("Введите сколько секунд прошло с начала суток: ");
            int time_n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{time_n / 3600} полных часов прошло с начала суток");
            Console.WriteLine($"{(time_n%3600)/60} полных минут прошло с начала очередного часа");
            Console.WriteLine($"{(time_n % 3600)%60} полных секунд прошло с начала очередной минуты.");
            // 21.Дан прямоугольник с размерами 543 х 130 мм.Сколько квадратов со стороной 130 мм можно отрезать от него?
            Console.WriteLine($"{543 / 130} квадрата со стороной 130 мм можно отрезать от прямоугольника с размерами 543 х 130 мм");
            //22. Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали ее в начале.Найти полученное число.
            Console.Write("Введите трехзначное число: ");
            int chislo = Convert.ToInt32(Console.ReadLine());
            var result_22 = Convert.ToString(chislo % 10) + Convert.ToString(chislo / 10);
            Console.WriteLine(result_22);
            /* 23.Дано натуральное число n(n > 999).Найти:
            а) число сотен в нем;
            б) число тысяч в нем.*/
            Console.Write("Введите число n(n > 999): ");
            int chislo_n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(chislo_n / 100);
            Console.WriteLine(chislo_n / 1000);
            /* 24.Дано четырехзначное число. Найти:
            а) число, полученное при прочтении его цифр справа налево;
            б) число, образуемое при перестановке первой и второй, третьей и четвертой цифр
            заданного числа.Например, из числа 5434 получить 4543, из числа 7048 — 784;
            в) число, образуемое при перестановке второй и третьей цифр заданного числа.
            Например, из числа 5084 получить 5804;
            г) число, образуемое при перестановке двух первых и двух последних цифр
            заданного числа.Например, из числа 4566 получить 6645, из числа 7304 — 473. */
            Console.Write("Введите четырехзначное число: ");
            int chislo_24z = Convert.ToInt32(Console.ReadLine());
            int n1 = chislo_24z / 1000; 
            int n2 = (chislo_24z / 100) % 10; 
            int n3 = (chislo_24z / 10) % 10;
            int n4 = chislo_24z % 10;
            Console.WriteLine($"Число, полученное при прочтении его цифр справа налево: {n4 * 1000 + n3 * 100 + n2 * 10 + n1}");
            Console.WriteLine($"Число, образуемое при перестановке первой и второй, третьей и четвертой цифр заданного числа: {n2 * 1000 + n1 * 100 + n4 * 10 + n3}");
            Console.WriteLine($"Число, образуемое при перестановке второй и третьей цифр заданного числа: {n1 * 1000 + n3 * 100 + n2 * 10 + n4}");
            Console.WriteLine($"Число, образуемое при перестановке двух первых и двух последних цифр заданного числа: {n3 * 1000 + n4 * 100 + n1 * 10 + n2}");
            // 25. Из трехзначного числа x вычли его последнюю цифру. Когда результат разделили на 10, а к частному слева приписали последнюю цифру числа x, то получилось число n. Найти число x.Значение n вводится с клавиатуры, 100 ≤ n ≤ 999 и при этом число десятков в n не равно нулю.
            Console.Write("Введите трехзначное число n, у которого число десятков не равно нулю: ");
            int n_25 = Convert.ToInt32(Console.ReadLine());
            while (n_25<100 || n_25>999 || (n_25 / 10) == 0)
            {
                Console.WriteLine("Ошибка: нужно ввести трехзначное число n, у которого число десятков не равно нулю ");
                break;
            }
            string x_25 = Convert.ToString(n_25%100)+Convert.ToString(n_25/100);
            Console.WriteLine(x_25);
            // 26. Даны целые числа h, m, s (0 ≤ h ≤ 23, 0 ≤ m ≤ 59, 0 ≤ s ≤ 59), указывающие момент времени: «h часов, m минут, s секунд». Определить угол(в градусах) между положением часовой стрелки в начале суток и в указанный момент времени.
            Console.Write("Введите сколько часов: ");
            int h_26 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сколько минут: ");
            int m_26 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сколько секунд: ");
            int s_26 = Convert.ToInt32(Console.ReadLine());
            double ugol = (360/12) * h_26 +(360/(12*60)) * m_26 + (360/(12*60*60)) * s_26;
            Console.WriteLine($"Угол между началом суток и заданным временем: {ugol} градусов");
            //27. Часовая стрелка образует угол y с лучом, проходящим через центр и через точку, соответствующую 12 часам на циферблате, 0 ≤ y ≤ 2.Определить значение угла для минутной стрелки, а также количество полных часов и полных минут.
            // 28. Создать программу, которая будет выводить на экран меньшее по модулю из трёх введённых пользователем вещественных чисел
            Console.Write("Введите вещественное число: ");
            double a_28 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вещественное число: ");
            double b_28 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вещественное число: ");
            double c_28 = Convert.ToDouble(Console.ReadLine());
            double abs_a_28 = Math.Abs(a_28);
            double abs_b_28 = Math.Abs(b_28);
            double abs_c_28 = Math.Abs(c_28);
            if (abs_a_28<abs_b_28)
            {
                if (abs_a_28<abs_c_28)
                {
                    Console.WriteLine($"Меньшее по модулю из трёх введённых вещественных чисел: {abs_a_28}");
                }
                else
                {
                    Console.WriteLine($"Меньшее по модулю из трёх введённых вещественных чисел: {abs_c_28}");
                }
            }
            else
            {
                if (abs_b_28 < abs_c_28)
                {
                    Console.WriteLine($"Меньшее по модулю из трёх введённых вещественных чисел: {abs_b_28}");
                }
                else
                {
                    Console.WriteLine($"Меньшее по модулю из трёх введённых вещественных чисел: {abs_c_28}");
                }
            }
            // 29.Найти сумму большего и меньшего из трёх заданных чисел
            Console.Write("Введите число: ");
            double a_29 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число: ");
            double b_29 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число: ");
            double c_29 = Convert.ToDouble(Console.ReadLine());
            double max_29 = Math.Max(a_29, Math.Max(b_29, c_29));
            double min_29 = Math.Min(a_29, Math.Min(b_29, c_29));
            double sum_29 = max_29 + min_29;
            Console.WriteLine($"Сумма большего и меньшего: {sum_29}");
            // 30. Подсчитать общее количество делителей натурального числа
            Console.WriteLine("Введите натуральное число:");
            int chislo_30 = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Общее количество делителей числа равно {count+1}");
            /* 31. Вася в школе изучил квадратные уравнения и понял, как они легко решаются путем
            вычисления дискриминанта. Но Петя поведал ему о методе решения кубических
            уравнений вида A* X3 +B * X2 + C * X + D = 0.На факультативе по математике Васе
            задали решить около ста уравнений как раз такого вида.Но, к сожалению, Вася
            забыл формулы, о которых рассказывал ему Петя. Но Васе было известно, что все
            корни уравнений – целые числа и находятся на отрезке[-100, 100]. Поэтому у Васи
            есть шанс найти их методом перебора, но для этого ему придется затратить уйму
            времени, т.к.возможно необходимо будет осуществить перебор нескольких тысяч
            значений.Помогите Васе написать программу, которая поможет ему найти корни
            кубических уравнений!*/
            Console.WriteLine("A*X^3 + B*X^2 + C*X + D = 0");
            Console.Write("Введите коэффициент A: ");
            int A_31 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите коэффициент B: ");
            int B_31 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите коэффициент C: ");
            int C_31 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите коэффициент D: ");
            int D_31 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Целые корни уравнения:");
            for (int x_31 = -100; x_31 <= 100; x_31++)
            {
                if (A_31 * x_31 * x_31 * x_31 + B_31 * x_31 * x_31 + C_31 * x_31 + D_31 == 0)
                {
                    Console.WriteLine(x);
                }
            }
            // 32.Заданы первый и второй элементы арифметической прогрессии. Требуется написать программу, которая вычислит элемент прогрессии по ее номеру.
            Console.Write("Введите первый элемент арифметической прогрессии: ");
            double a1_32 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второй элемент арифметической прогрессии: ");
            double a2_32 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите номер элемента прогрессии: ");
            int n_32 = Convert.ToInt32(Console.ReadLine());
            double a_n = a1_32 + (n_32 - 1) * (a2_32-a1_32);
            Console.WriteLine($"a({n_32}) элемент прогрессии равен {a_n}");
            /* 33. Если я пенсионер или студент и не трудоустроен, то получаю кредит, а если
            трудоустроен не получаю кредит. Ну а если я, и пенсионер и
            студент,(трудоустройство тут не имеет значения) то не должен получить.
            Необходимо вводить строки, содержащие информацию о том, студент, пенсионер
            или кто-то ещё.Вывести информацию: дадут кредит или нет. */
            Console.WriteLine("Вы студент, пенсионер или и студент, и пенсионер? (Пожалуйста, введите информацию маленькими буквами)");
            string human = Console.ReadLine();
            Console.WriteLine("Вы трудоустроены или не трудоустроены? (Пожалуйста, введите информацию маленькими буквами)");
            string trudoustr = Console.ReadLine();
            if (( human == "студент" || human== "пенсионер") && (trudoustr=="не трудоустроен"))
            {
                Console.WriteLine("Кредит дадут");
            }
            else if (((human == "студент" || human == "пенсионер") && (trudoustr == "трудоустроен")) || (human=="и студент, и пенсионер"))
            {
                Console.WriteLine("Кредит не дадут");
            }
            else 
            {
                Console.WriteLine("Ошибка: некорректная информация!");
            }
            /* 34. Составить программу, которая:
            а) запрашивает имя человека и повторяет его на экране;
            б) запрашивает имя человека и повторяет его на экране с приветствием. */
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine($"Привет, {name}");
            Console.ReadKey();
        }
    }
}
