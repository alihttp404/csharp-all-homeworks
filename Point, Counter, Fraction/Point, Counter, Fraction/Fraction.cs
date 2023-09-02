using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point__Counter__Fraction
{
    internal class Fraction
    {
        public double? Num { get; set; }
        public double? Denum { get; set; }

        public Fraction() { Num = 1; Denum = 1; }

        public Fraction(double? num, double? denum)
        {
            Num = num;
            Denum = denum;
        }

        public Fraction Add(Fraction other)
        {
            if (other.Denum == Denum) return new Fraction(Num + other.Num, Denum);
            return new Fraction(other.Num*Denum + Num*other.Denum, other.Denum*Denum);
        }

        public Fraction Subtract(Fraction other)
        {
            if (other.Denum == Denum) return new Fraction(Num - other.Num, Denum);
            return new Fraction(other.Num * Denum - Num * other.Denum, other.Denum * Denum);
        }

        public Fraction Multiply(Fraction other) => new Fraction(Num * other.Num, Denum * other.Denum);

        public Fraction Divide(Fraction other)
        {
            try
            {
                other.Denum *= other.Num;
                other.Num /= other.Denum;
                other.Denum /= other.Num;

                return this.Multiply(other);
            }
            catch (DivideByZeroException ex) { throw ex; }
        }

        public override string ToString()
        {
            return $"{Num} / {Denum}";
        }
    }
}
