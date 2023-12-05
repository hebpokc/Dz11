using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Lab14
{
    [DeveloperInfo("Андрей")]
    class RationalNumber
    {
        int numerator;
        int denominator;
        public int Numerator
        {
            get
            {
                return numerator;
            }
            set
            {
                numerator = value;
            }
        }
        public int Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                denominator = value;
            }
        }
        public RationalNumber(int n, int d)
        {
            numerator = n;
            if (d == 0)
            {
                throw new Exception("Знаменатель не должен быть равен нулю");
            }
            else
            {
                denominator = d;
            }

            if (denominator < 0)
            {
                numerator = -n;
                denominator = -d;
            }
        }
        public int gcd(int a, int b)
        {
            int nod;
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            nod = a + b;
            return nod;
        }
        public void Reduce()
        {
            int gcdVal = gcd(numerator, denominator);
            numerator /= gcdVal;
            denominator /= gcdVal;
            if (denominator < 0 && numerator < 0)
            {
                denominator *= -1;
                numerator *= -1;
            }
        }
        public static explicit operator float(RationalNumber a)
        {
            return (float)a.numerator / a.denominator;
        }
        public static explicit operator int(RationalNumber a)
        {
            return a.numerator / a.denominator;
        }
        public override bool Equals(object obj)
        {
            RationalNumber rn = obj as RationalNumber;
            if (rn == null)
                return false;
            else
            {
                Reduce();
                rn.Reduce();
                return this.numerator == rn.numerator && this.denominator == rn.denominator;
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static bool operator ==(RationalNumber a, RationalNumber b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(RationalNumber a, RationalNumber b)
        {
            return !(a == b);
        }
        public static bool operator >(RationalNumber a, RationalNumber b)
        {
            return (float)a > (float)b;
        }
        public static bool operator <(RationalNumber a, RationalNumber b)
        {
            return (float)a < (float)b;
        }
        public static bool operator >=(RationalNumber a, RationalNumber b)
        {
            return (float)a >= (float)b;
        }
        public static bool operator <=(RationalNumber a, RationalNumber b)
        {
            return (float)a <= (float)b;
        }
        public static RationalNumber operator ++(RationalNumber a)
        {
            a.numerator++;
            return a;
        }
        public static RationalNumber operator --(RationalNumber a)
        {
            a.numerator--;
            return a;
        }
        public static RationalNumber operator +(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a.numerator * b.denominator + b.numerator * a.denominator, a.denominator * b.denominator);
        }
        public static RationalNumber operator +(RationalNumber a, int b)
        {
            return new RationalNumber(b * a.denominator + a.numerator, a.denominator);
        }
        public static RationalNumber operator -(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a.numerator * b.denominator - b.numerator * a.denominator, a.denominator * b.denominator);
        }
        public static RationalNumber operator -(RationalNumber a, int b)
        {
            return new RationalNumber(a.numerator - b * a.denominator, a.denominator);
        }
        public static RationalNumber operator *(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a.numerator * b.numerator, a.denominator * b.denominator);
        }
        public static RationalNumber operator *(RationalNumber a, int b)
        {
            return new RationalNumber(a.numerator * b, a.denominator);
        }
        public static RationalNumber operator /(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a.numerator * b.denominator, a.denominator * b.numerator);
        }
        public static RationalNumber operator /(RationalNumber a, int b)
        {
            return new RationalNumber(a.numerator, a.denominator * b);
        }
        public static float operator %(RationalNumber a, RationalNumber b)
        {
            return (float)a % (float)b;
        }
        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }
    }
}
