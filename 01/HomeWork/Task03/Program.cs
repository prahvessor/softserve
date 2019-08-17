using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = null;
            Fraction fraction2 = null;

            try
            {
                fraction1 = new Fraction(2, 27);
                fraction2 = new Fraction(3, 27);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Denomenator is equal to 0");
                Console.ReadKey();
                return;
            }
            
            Fraction fraction3 = fraction1 * fraction2;
            Console.WriteLine("{0} * {1} = {2}", fraction1, fraction2, fraction3);
            //Console.ReadKey();

            Fraction fraction4 = fraction1 / fraction2;
            Console.WriteLine("{0} / {1} = {2}", fraction1, fraction2, fraction4);
            //Console.ReadKey();

            Fraction fraction5 = fraction1 + fraction2;
            Console.WriteLine("{0} + {1} = {2}", fraction1, fraction2, fraction5);
            //Console.ReadKey();

            Fraction fraction6 = fraction1 - fraction2;
            Console.WriteLine("{0} - {1} = {2}", fraction1, fraction2, fraction6);
            //Console.ReadKey();

            Console.WriteLine("{0} > {1} is {2}", fraction1, fraction2, fraction1 > fraction2);
            //Console.ReadKey();

            Console.WriteLine("{0} < {1} is {2}", fraction1, fraction2, fraction1 < fraction2);
            //Console.ReadKey();

            Console.WriteLine("{0} == {1} is {2}", fraction1, fraction2, fraction1 == fraction2);
            //Console.ReadKey();

            Console.WriteLine("{0} != {1} is {2}", fraction1, fraction2, fraction1 != fraction2);
            //Console.ReadKey();

            Console.WriteLine("{0} >= {1} is {2}", fraction1, fraction2, fraction1 >= fraction2);
            //Console.ReadKey();

            Console.WriteLine("{0} <= {1} is {2}", fraction1, fraction2, fraction1 <= fraction2);
            Console.ReadKey();

            Fraction fraction7 = new Fraction(0.5);
            Fraction fraction8 = new Fraction(1.5);

            Fraction fraction9 = fraction7 * fraction8;
            Console.WriteLine("{0} * {1} = {2}", fraction7, fraction8, fraction9);
            //Console.ReadKey();

            Fraction fraction10 = fraction7 / fraction8;
            Console.WriteLine("{0} / {1} = {2}", fraction7, fraction8, fraction10);
            //Console.ReadKey();

            Fraction fraction11 = fraction7 + fraction8;
            Console.WriteLine("{0} + {1} = {2}", fraction7, fraction8, fraction11);
            //Console.ReadKey();

            Fraction fraction12 = fraction7 - fraction8;
            Console.WriteLine("{0} - {1} = {2}", fraction7, fraction8, fraction12);
            //Console.ReadKey();

            Console.WriteLine("{0} > {1} is {2}", fraction7, fraction8, fraction7 > fraction8);
            //Console.ReadKey();

            Console.WriteLine("{0} < {1} is {2}", fraction7, fraction8, fraction7 < fraction8);
            //Console.ReadKey();

            Console.WriteLine("{0} == {1} is {2}", fraction7, fraction8, fraction7 == fraction8);
            //Console.ReadKey();

            Console.WriteLine("{0} != {1} is {2}", fraction7, fraction8, fraction7 != fraction8);
            //Console.ReadKey();

            Console.WriteLine("{0} >= {1} is {2}", fraction7, fraction8, fraction7 >= fraction8);
            //Console.ReadKey();

            Console.WriteLine("{0} <= {1} is {2}", fraction7, fraction8, fraction7 <= fraction8);
            Console.ReadKey();
        }
    }
}
