using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        
        

        private void Button1_Click(object sender, EventArgs e)
        {
            double radius;

            try
            {
                radius = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                radius = 0.0;
            }
            
            double cir = 2 * Math.PI * radius;

            label1.Text = "Circumference = " + cir ;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double radius;

            try
            {
                radius = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                radius = 0.0;
            }
            double area = Math.PI * (radius * radius);

            label2.Text = "Area = " + area;

        }
    }
}
