using System;

namespace hw._05.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int b = Convert.ToInt16(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <= b; i++)
            {
                sum += i;
            }
            Console.WriteLine("Сумма чисел от " + 1 + " до " + b + ": " + sum);
            Console.ReadKey();
        }
    }
}
