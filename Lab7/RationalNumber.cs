using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7LR
{
    class RationalNumber : IComparable<RationalNumber>
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public RationalNumber(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }
        private static int NOD(int a, int b) => b == 0 ? a : NOD(b, a % b);
        private static int NOK(int a, int b) => Math.Abs(a) * Math.Abs(b) / NOD(a, b);

        public int CompareTo(RationalNumber y)
        {
            int nok = NOK(this.Denominator, y.Denominator);
            if ((this.Numerator * nok / this.Denominator) > (y.Numerator * nok / y.Denominator))
                return 1;
            if ((this.Numerator * nok / this.Denominator) < (y.Numerator * nok / y.Denominator))
                return -1;
            else
                return 0;
        }
        public string ToDoubleString()
        {
            double doubleNumber = (double)Numerator / (double)Denominator;
            return String.Format("{0}", doubleNumber);
        }
        public override string ToString()
        {
            int nod = NOD(Numerator, Denominator);
            Numerator = Numerator / nod;
            Denominator = Denominator / nod;
            if (Numerator != 0 && Denominator != 1)
            {
                if (Denominator < 0)
                {
                    Numerator = -1 * Numerator;
                    Denominator = Math.Abs(Denominator);
                }
                return String.Format("{0}/{1}", Numerator, Denominator);
            }
            else
            {
                return String.Format(Numerator.ToString());
            }
        }
        public static RationalNumber operator +(RationalNumber num1, RationalNumber num2)
        {
            if (num1.Denominator != num2.Denominator)
            {
                int nok = NOK(num1.Denominator, num2.Denominator);
                return new RationalNumber((num1.Numerator * nok / num1.Denominator) + (num2.Numerator * nok / num2.Denominator), nok);
            }
            else
                return new RationalNumber(num1.Numerator + num2.Numerator, num1.Denominator);
        }
        public static RationalNumber operator -(RationalNumber num1, RationalNumber num2)
        {
            if (num1.Denominator != num2.Denominator)
            {
                int nok = NOK(num1.Denominator, num2.Denominator);
                return new RationalNumber((num1.Numerator * nok / num1.Denominator) - (num2.Numerator * nok / num2.Denominator), nok);
            }
            else
                return new RationalNumber(num1.Numerator - num2.Numerator, num1.Denominator);
        }
        public static RationalNumber operator *(RationalNumber num1, RationalNumber num2) => new RationalNumber(num1.Numerator * num2.Numerator, num1.Denominator * num2.Denominator);
        public static RationalNumber operator /(RationalNumber num1, RationalNumber num2) => new RationalNumber(num1.Numerator * num2.Denominator, num1.Denominator * num2.Numerator);

        public static bool operator <(RationalNumber num1, RationalNumber num2)
        {
            int nok = NOK(num1.Denominator, num2.Denominator);
            return (num1.Numerator * nok / num1.Denominator) < (num2.Numerator * nok / num2.Denominator);

        }
        public static bool operator >(RationalNumber num1, RationalNumber num2)
        {
            int nok = NOK(num1.Denominator, num2.Denominator);
            return (num1.Numerator * nok / num1.Denominator) > (num2.Numerator * nok / num2.Denominator);

        }
        public static bool operator <=(RationalNumber num1, RationalNumber num2)
        {
            int nok = NOK(num1.Denominator, num2.Denominator);
            return (num1.Numerator * nok / num1.Denominator) >= (num2.Numerator * nok / num2.Denominator);
        }
        public static bool operator >=(RationalNumber num1, RationalNumber num2)
        {
            int nok = NOK(num1.Denominator, num2.Denominator);
            return (num1.Numerator * nok / num1.Denominator) >= (num2.Numerator * nok / num2.Denominator);
        }

        public static explicit operator double(RationalNumber data)
        {
            return (double)data.Numerator / data.Denominator;
        }
        public static implicit operator RationalNumber(double value)
        {
            int i = 0;
            for (i = 0; value * Math.Pow(10, 1 + i) % 10 != 0; i++) ;

            int denominator = (int)Math.Pow(10, i);
            int numerator = (int)(value * denominator);
            int nod = NOD((int)(value * Math.Pow(10, i)), denominator);
            return new RationalNumber(numerator / nod, denominator / nod);
        }
    }
}