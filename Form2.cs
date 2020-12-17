using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form2 : Form
    {
        CalcUI cl;
        public Form2(CalcUI cl1)
        {

            InitializeComponent();
            cl = cl1;
        }
       
           
        
        public void button1_Click(object sender, EventArgs e)
        {
            cl.a = double.Parse(textBox1.Text);
            cl.b = double.Parse(textBox2.Text);
            cl.c = double.Parse(textBox3.Text);


            double d = cl.b * cl.b - 4 * cl.a * cl.c;
            if (d < 0)
            {
                cl.textBox1.Text = "d<0. Корней нет.";
            }
            if (d == 0)
            {
                double x = (-cl.b / 2 * cl.a);
                cl.textBox1.Text = "d=0. x = " + Math.Round(x, 2) + ".";
            }
            if (d > 0)
            {

                double x1 = ((-cl.b - Math.Sqrt(d)) / 2 * cl.a);
                double x2 = ((-cl.b + Math.Sqrt(d)) / 2 * cl.a);
                cl.textBox1.Text = "d= " + Math.Round(d, 2) + ",x1= " + Math.Round(x1, 2) + ",x2= " + Math.Round(x2, 2) + ".";
            }
            Close();
          
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
