using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcolatrice
{
    internal class Calc_ex : Calc
    {
        public Calc_ex() : base() { }

        public Calc_ex(double num1, double num2) : base(num1, num2) { }


        public double Esegui_frazione()
        {
            return Num1/ Num2;
        }

        public string Double_to_fraction(double num)
        {
            return "";
        }

        public string Power_of_fraction(int numer, int denom, int pow)
        {
            int temp1 = numer, temp2 = denom;

            for (int i = 0; i < pow; i++)
            {
                temp1= temp1 * numer;
                temp2 = temp2 * denom;
            }
            return SempFrazione(temp1, temp2);
        }

    }
}
