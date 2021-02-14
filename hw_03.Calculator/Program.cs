using System;

namespace Calculator
{
    class Program
    {
         static void Main(string[] args)
        {
            string str;
            int a, b, a1, b1, a2, b2;

            Console.WriteLine("Сложение");
            Console.WriteLine("Введите число 1");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);

            Console.WriteLine("Введите число 2");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);

            int result = a + b;
            Console.WriteLine(" = " + result);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Вычитание");
            Console.WriteLine("Введите число 1");
            str = Console.ReadLine();
            a1 = Convert.ToInt32(str);

            Console.WriteLine("Введите число 2");
            str = Console.ReadLine();
            b1 = Convert.ToInt32(str);

            int result1 = a1 - b1;
            Console.WriteLine(" = " + result1);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Умножение");
            Console.WriteLine("Введите число 1");
            str = Console.ReadLine();
            a2 = Convert.ToInt32(str);

            Console.WriteLine("Введите число 2");
            str = Console.ReadLine();
            b2 = Convert.ToInt32(str);

            int result2 = a2 * b2;
            Console.WriteLine(" = " + result2);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Деление");
            Console.WriteLine("Введите число 1");
            str = Console.ReadLine();
            double a3 = double.Parse(str);
            
            Console.WriteLine("Введите число 2");
            str = Console.ReadLine();
            double a4 = double.Parse(str);

            double result3 = a3 / a4;
            Console.WriteLine(" = " + result3);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Остаток от деления");
            Console.WriteLine("Введите число 1");
            str = Console.ReadLine();
            float f = float.Parse(str);

            Console.WriteLine("Введите число 2");
            str = Console.ReadLine();
            float f1 = float.Parse(str);

            float result4 = f % f1;
            Console.WriteLine(" = " + result4);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Площадь круга через радиус");
            Console.WriteLine("Введите число");
            str = Console.ReadLine();
            double S = double.Parse(str);

            const double p = 3.14;
            double result5 = S * S * p;

            Console.WriteLine(" = " + result5);
        }
    }
}
