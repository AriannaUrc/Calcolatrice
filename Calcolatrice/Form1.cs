using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Calc_ex calc = new Calc_ex();
            MessageBox.Show(calc.Double_to_fraction(0.25));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
