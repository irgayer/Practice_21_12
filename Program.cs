using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_21_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
            Exercise5();
            Exercise6();
            Exercise7();
            Exercise8();
        }
        static void Exercise1() {
            Console.WriteLine("\nЗадача 1:\n");

            Console.WriteLine("Введите значение x:");
            double x, y;

            if(double.TryParse(Console.ReadLine(), out x))
            {
                y = x * x;
                Console.WriteLine($"x = {x}");
                Console.WriteLine($"y = {y}");
            }
        }
        static void Exercise2() {
            Console.WriteLine("\nЗадача 2:\n");

            const double PI = 3.14;
            double r, i, S; //радиус, длина, площадь

            Console.WriteLine("Введите радиус окружности");
            if(double.TryParse(Console.ReadLine(), out r))
            {
                i = 2 * PI * r;
                S = r * r;
                Console.WriteLine($"Длина окружности : {i}");
                Console.WriteLine($"Площадь          : {S}");
            }
        }
        static void Exercise3() {
            Console.WriteLine("\nЗадача 3:\n");

            Console.WriteLine("Введите длину в сантиметрах:");
            int cm, m = 0;

            if (int.TryParse(Console.ReadLine(), out cm))
            {
                if(cm > 0)
                    m = cm / 100;
            }
            Console.WriteLine($"Полных метров: {m}");
        }
        static void Exercise4() {
            Console.WriteLine("\nЗадача 4:\n");

            const int DAYS = 234;

            Console.WriteLine($"Недель прошло: {DAYS / 7}");
        }
        static void Exercise5() {
            Console.WriteLine("\nЗадача 5:\n");

            Console.WriteLine("Введите двузначное число:");
            int number, cntDec = 0, cntUnit = 0, sum = 0, op = 0;

            if(int.TryParse(Console.ReadLine(), out number))
            {
                if(number > -100 && number < 100)
                {
                    cntDec = number / 10;
                    cntUnit = number % 10;
                    sum = cntDec + cntUnit;
                    op = cntUnit * cntDec;
                }
            }
            Console.WriteLine($"Десятков     : {cntDec}");
            Console.WriteLine($"Единиц       : {cntUnit} ");
            Console.WriteLine($"Сумма        : {sum}");
            Console.WriteLine($"Произведение : {op}");

        }
        static void Exercise6() {
            Console.WriteLine("\nЗадача 6:\n");

            Console.WriteLine("Введите четырехзначное число:");
            int number, cntThousand, cntHundred, cntDec, cntUnit, sum = 0, op = 0;
            if(int.TryParse(Console.ReadLine(), out number))
            {
                if(number > 999 && number < 10000)
                {
                    cntThousand = number / 1000;
                    cntHundred = (number % 1000) / 100;
                    cntDec = (number % 100) / 10;
                    cntUnit = number % 10;

                    sum = cntThousand + cntHundred + cntDec + cntUnit;
                    op = cntThousand * cntHundred * cntDec * cntUnit;
                }
            }
            Console.WriteLine($"Сумма чисел  : {sum}");
            Console.WriteLine($"Произведение : {op}");

        }
        static void Exercise7() {
            Console.WriteLine("\nЗадача 7:\n");

            int x;
            const int RESULT = 456;

            x = ((RESULT % 10) * 10) + (RESULT - RESULT % 100) + (RESULT % 100) / 10;
            Console.WriteLine($"Изначально : {RESULT}");
            Console.WriteLine($"Число х    : {x}");
        }
        static void Exercise8() {
            Console.WriteLine("\nЗадача 8:\n");

            bool x = true, y = true;
            if(!x && !y)
            {
                Console.WriteLine("!x и !y");
            }
            if(x || (!x && y))
            {
                Console.WriteLine("x или (!x и y)");
            }
            if((!x && y) || y)
            {
                Console.WriteLine("(!x и y) или y");
            }
        }
    }
}
