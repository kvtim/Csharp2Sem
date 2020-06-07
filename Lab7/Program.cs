using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7LR
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerator;
            int denominator;
            RationalNumber number2, number1;

            while (true)
            {
                try
                {
                    Console.Write(" Enter the numerator of the first number:");
                    numerator = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" Enter the deniminator of the first number:");
                    denominator = Convert.ToInt32(Console.ReadLine());
                    if (denominator != 0)
                    {
                        break;
                    }
                    else
                    {
                        throw new Exception("Denumerator must be > 0!");
                    }
                }
                catch (Exception exeption)
                {
                    Console.WriteLine(" " + exeption.Message);
                }
            }

            number1 = new RationalNumber(numerator, denominator);

            while (true)
            {
                try
                {
                    Console.Write(" Enter the numerator of the second number:");
                    numerator = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" Enter the deniminator of the second number:");
                    denominator = Convert.ToInt32(Console.ReadLine());
                    if (denominator != 0)
                    {
                        break;
                    }
                    else
                    {
                        throw new Exception("Denumerator must be > 0!");
                    }
                }
                catch (Exception exeption)
                {
                    Console.WriteLine(" " + exeption.Message);
                }
            }

            number2 = new RationalNumber(numerator, denominator);

            RationalNumber result;
            Console.Write(" The sum of two numbers: ");
            result = number1 + number2;
            Console.WriteLine(result.ToString());

            Console.Write(" The substraction of two numbers: ");
            result = number1 - number2;
            Console.WriteLine(result.ToString());

            Console.Write(" The multiplication of two numbers: ");
            result = number1 * number2;
            Console.WriteLine(result.ToString());

            Console.Write(" The division of two numbers: ");
            result = number1 / number2;
            Console.WriteLine(result.ToString());

            if (number1 > number2)
                Console.WriteLine(" Bigger is " + number1);
            if (number1 < number2)
                Console.WriteLine(" Bigger is " + number2);
            if (number1 == number2)
                Console.WriteLine(" They Equals");
            if (number1 != number2)
                Console.WriteLine(" They don't Equals");


            Console.Write(" The first number in other format: ");
            Console.WriteLine(number1.ToDoubleString());

            double double1 = (double)number1;
            Console.WriteLine(" {0} = {1}", number1, double1);

            number1 = (RationalNumber)double1;
            Console.WriteLine(" {0} = {1}", double1, number1);

            Console.Write(" The second number in other format: ");
            Console.WriteLine(number2.ToDoubleString());

            double double2 = (double)number2;
            Console.WriteLine(" {0} = {1}", number2, double2);

            number2 = (RationalNumber)double2;
            Console.WriteLine(" {0} = {1}", double2, number2);
        }
    }
}