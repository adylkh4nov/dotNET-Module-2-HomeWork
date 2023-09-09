using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_Module_2_HomeWork
{
    internal class HomeWork
    {
        public void example1()
        {
            String str = "";
            while (true)
            {
                Console.WriteLine("Вводите строку, точку чтобы остоновиться");
                String s = Console.ReadLine();

                if (s == ".")
                {
                    break;
                }
                str += s;
            }
            int count = 0;
            foreach (char item in str)
            {
                if (item == '_')
                {
                    count++;
                }
            }
            Console.WriteLine("Количество нижних подчеркиваний = " + count);
        }
        public void example2()
        {
            int x;
            Console.WriteLine("Введите 6х число");
            while (!int.TryParse(Console.ReadLine(), out x) || (x / 100000 >= 10 || x / 100000 <= 0))
            {
                Console.WriteLine("Введите целое и 6 значное число");

            }
            //123456
            int sum1 = x / 100000 + (x / 10000) % 10 + (x / 1000) % 10;
            int sum2 = x % 10 + (x / 10) % 10 + (x / 100) % 10;
            if (sum1 == sum2)
            {
                Console.WriteLine("Счастливое число: " + sum1 + " = " + sum2);
            }
            else Console.WriteLine("Несчастливое число: " + sum1 + " != " + sum2);

            Console.ReadLine();
        }
        public void example3()
        {
            Console.WriteLine("Input a string");
            string str = Console.ReadLine();
            str.ToLower();
            int newInt = 0;
            bool isUpper = false;
            char newChar;
            string result = "";
            foreach (char ch in str)
            {
                if (ch >= 'A' && ch <= 'Z')
                {
                    isUpper = true;
                }
                else if (ch >= 'a' && ch <= 'z')
                {
                    isUpper = false;
                }
                if (isUpper)
                {
                    newInt = (ch + 32);
                }
                else
                {
                    newInt = (ch - 32);
                }
                newChar = (char)newInt;
                result += newChar;
            }

            Console.WriteLine(result);
        }
        public void example4()
        {
            byte A = byte.Parse(Console.ReadLine());
            byte B = byte.Parse(Console.ReadLine());
            for (byte i = A; i <= B; i++)
            {
                for (byte j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
        public void example5()
        {
            int A = int.Parse(Console.ReadLine());
            string B = "";
            do
            {
                B += A % 10;
                A /= 10;
            }
            while (A > 0);
            Console.WriteLine(B);
            Console.ReadLine();
        }
        public void example6()
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 100);
            int b = rnd.Next(0, 100);
            int c = rnd.Next(0, 100);
            Console.WriteLine(a + " " + b + " " + c);
            Console.ReadLine();
        }
        public void example7()
        {
            Console.WriteLine(5 + "\n" + 10 + "\n" + 21);
        }
        public void example8()
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a / 100 + " метра");
        }
        public void example9()
        {
            int days = 234;
            Console.WriteLine(234 / 7);
        }
        public void example10()
        {
            int a = new Random().Next(10, 100);
            int desatki = a / 10;
            int edinitsy = a % 10;
            int sum = (desatki + edinitsy);
            int proizv = (desatki * edinitsy);
            Console.WriteLine("Число: " + a);
            Console.WriteLine("Десятки: " + desatki);
            Console.WriteLine("Единицы: " + edinitsy);
            Console.WriteLine("Сумма: " + sum);
            Console.WriteLine("Произведение " + proizv);
        }
        public void example11()
        {
            bool a = true;
            bool b = false;
            bool c = false;
            Console.WriteLine(a || b);
            Console.WriteLine(a && b);
            Console.WriteLine(b || c);
        }
        public void example12()
        {
            int radius;
            Console.WriteLine("Введите радиус:");
            while (!int.TryParse(Console.ReadLine(), out radius))
            {
                Console.WriteLine("Нужно ввести тип значения int");
            }
            int storona;
            Console.WriteLine("Введите сторону квадрата:");
            while (!int.TryParse(Console.ReadLine(), out storona))
            {
                Console.WriteLine("Нужно ввести тип значения int");
            }
            if (Math.Pow(storona, 2) > Math.PI * Math.Pow(radius, 2))
            {
                Console.WriteLine("Площадь квадрата:" + Math.Pow(storona, 2));
                Console.WriteLine("Площадь круга:" + Math.PI * Math.Pow(radius, 2));
                Console.WriteLine("Площадь квадрата больше");
            }
            else if (Math.Pow(storona, 2) < Math.PI * Math.Pow(radius, 2))
            {
                Console.WriteLine("Площадь квадрата:" + Math.Pow(storona, 2));
                Console.WriteLine("Площадь круга:" + Math.PI * Math.Pow(radius, 2));
                Console.WriteLine("Площадь круга больше");
            }
            else Console.WriteLine("они равны");
            Console.ReadLine();
        }
        public void example13()
        {
            double v1, v2, m1, m2;
            Console.WriteLine("v1: ");
            while (!double.TryParse(Console.ReadLine(), out v1))
            {
                Console.WriteLine("Не правильный ввод");
            }

            Console.WriteLine("v2: ");
            while (!double.TryParse(Console.ReadLine(), out v2))
            {
                Console.WriteLine("Не правильный ввод");
            }
            Console.WriteLine("m1: ");
            while (!double.TryParse(Console.ReadLine(), out m1))
            {
                Console.WriteLine("Не правильный ввод");
            }
            Console.WriteLine("m2: ");
            while (!double.TryParse(Console.ReadLine(), out m2))
            {
                Console.WriteLine("Не правильный ввод");
            }

            Console.WriteLine("Материал 1: " + v1 * m1 + "; Материал 2: " + v2 * m2);
            if (v1 * m1 > v2 * m2) Console.WriteLine("Материал 1 плотнее");
            else if (v1 * m1 == v2 * m2) Console.WriteLine("Они идентичны");
            else Console.WriteLine("Материал 2 плотнее");
        }
        public void example14()
        {
            Console.WriteLine("r1: ");
            int r1 = int.Parse(Console.ReadLine());
            Console.WriteLine("r2: ");
            int r2 = int.Parse(Console.ReadLine());
            Console.WriteLine("u1: ");
            int u1 = int.Parse(Console.ReadLine());
            Console.WriteLine("u2: ");
            int u2 = int.Parse(Console.ReadLine());
            int i1 = u1 / r1;
            int i2 = u2 / r2;
            if (i1 > i2) Console.WriteLine(i1 + " > " + i2);
            else if (i2 > i1) Console.WriteLine(i2 + " > " + i1);
            else Console.WriteLine(i1 + " = " + i2);
        }
        public void example15()
        {
            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("вверхняя граница b: ");
            int b = int.Parse(Console.ReadLine());
            for (int i = 10; i <= b; i++)
            {
                Console.WriteLine(i * i);
            }
            Console.WriteLine("input a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("input b: ");
            b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void example16()
        {
            Console.WriteLine("input x: ");
            double x = double.Parse(Console.ReadLine());
            double y = 7 * x * x - 3 * x + 6;
            Console.WriteLine("y=7x^2 - 3x + 6 = " + y);
        }
        public void example17()
        {
            Console.WriteLine("input a: ");
            int a = int.Parse((Console.ReadLine()));
            int x = 12 * a * a + 7 * a - 16;
            Console.WriteLine("x= 12a^2+7a-16 = " + x);
        }
        public void example18()
        {
            Console.WriteLine("введите сторону квадрата: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Периметр: " + a * 4);

        }
        public void example19()
        {
            int radius = int.Parse(Console.ReadLine());
            int diametr = radius * 2;
            Console.WriteLine("диаметр: " + diametr);
        }
        public void example20()
        {
            double radius = 6350;
            double height = double.Parse(Console.ReadLine());
            double a = radius + height;
            double horizonDistance = (a * a - radius * radius);
            Console.WriteLine(horizonDistance);
        }
    }
}
