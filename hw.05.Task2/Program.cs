using System;

namespace hw._05.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = GetNumberFromConsole("Введите число от 1 до 100");
            DrawPyramid(number);
        }
        static int GetNumberFromConsole(string text)
        {
            int number = default;
            bool isNumber = false;
            Console.WriteLine(text); while (!isNumber)
            {
                if (int.TryParse(Console.ReadLine(), out number) && number > 0 && number <= 100)
                {
                    isNumber = true;
                }
                else
                {
                    Console.WriteLine("Некорректное число");
                }
            }
            return number;
        }
        static void DrawPyramid(int number)
        {
            int count = 1;
            for (int i = number; i != 0; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(count + " ");
                }
                Console.WriteLine(count);
                Console.Write(new String(' ', number - i + 1));
                if (++count == 10) count = 0;
            }
        }
    }
}
