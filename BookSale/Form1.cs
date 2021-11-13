using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double unitprice = Convert.ToDouble(tbUnitP.Text);
            double bookquantity = Convert.ToDouble(tbQuantity.Text);
            double finalprice = bookquantity * unitprice;

            if (bookquantity<20&&bookquantity>0)
            {
                double result = finalprice * 0.95;
                MessageBox.Show("The amount you have to pay is "+result.ToString()+"$");
            }
            else if(bookquantity>=20&&bookquantity<50)
            {
                double result = finalprice * 0.9;
                MessageBox.Show("The amount you have to pay is " + result.ToString()+"$");
            }
            else if(bookquantity>=50&&bookquantity<100)
            {
                double result = finalprice * 0.85;
                MessageBox.Show("The amount you have to pay is " + result.ToString()+"$");
            }
            else if(bookquantity>=100)
            {
                double result = finalprice * 0.75;
                MessageBox.Show("The amount you have to pay is " + result.ToString()+"$");
            }
            else
            {
                MessageBox.Show("Please enter a valid number. Thank you.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
