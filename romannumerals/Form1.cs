using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace romannumerals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InputTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string[] numerals = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };
                outputLB.Text = "The corasponding numeral is: " + numerals[int.Parse(InputTB.Text) - 1];
            }
            catch
            {
                outputLB.Text = "Please input a number between 1 and 10!";
            }
        }
    }
}
