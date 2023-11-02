using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcolatrice
{
    internal class Calc : ICloneable
    {
        private double _num1;
        private double _num2;


        public double Num1 { set { _num1 = value; } get { return _num1; } }
        public double Num2 { set { _num2 = value; } get { return _num2; } }


        public Calc()
        {
            Num1 = 0;
            Num2 = 0;
        }

        public Calc(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public Calc(Calc calc)
        {
            Num1 = calc.Num1;
            Num2 = calc.Num2;
        }

        public Object Clone()
        {
            return this.MemberwiseClone();
        }


        public double Somma()
        {
            return Num1 + Num2;
        }

        public double Sottrazione()
        {
            return Num1 - Num2;
        }
        public double Moltiplicazione()
        {
            return Num1 * Num2;
        }

        public double Divisione()
        {
            return Num1 / Num2;
        }

        public string SempFrazione(int num1, int num2) 
        {
            double gcd = GCD(num1, num2);
            return (num1/gcd).ToString() + "/" + (num2 / gcd).ToString();

        }

        public double GCD(double a, double b)
        {
            while (b > 0)
            {
                double rem = a % b;
                a = b;
                b = rem;
            }
            return a;
        }

    }
}
