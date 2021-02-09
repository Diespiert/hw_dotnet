using System;

namespace hw_02.Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion:

            byte b = 33;
            short s = 22;

            s = b;

            short s1 = 25;
            int i = 564;

            i = s1;

            byte b1 = 230;
            int i1 = 355;

            i1 = b1;
            Console.WriteLine(i);

            //explicit conversion:

            sbyte b2 = 53;
            double d = 54.25;

            b2 = (sbyte)d;

            int i2 = 568768;
            byte b3 = 25;

            b3 = (byte)i2;

            uint ui = 2567;
            decimal d1 = 343437437;

            ui = (uint)d1;
            Console.WriteLine(ui);


            //boxing:

            byte b5 = 56;
            int i5 = 4562;
            decimal d5 = 34566;
            Object obj1 = b5;
            Object obj2 = i5;
            Object obj3 = d5;
            Console.WriteLine(obj1);

            //UnBoxing:

            byte b7;
            int i7;
            decimal d7;

            b7 = (byte)obj1;
            i7 = (int)obj2;
            d7 = (decimal)obj3;
            Console.WriteLine(b7);







        }
    }
}
