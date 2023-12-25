using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string calTotal;
        int num1;
        int num2;
        string option;
        int result;


        private void btn1_Click(object sender, EventArgs e)
        {
            display_window.Text = display_window.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            display_window.Text = display_window.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            display_window.Text = display_window.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            display_window.Text = display_window.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            display_window.Text = display_window.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            display_window.Text = display_window.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            display_window.Text = display_window.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            display_window.Text = display_window.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            display_window.Text = display_window.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            display_window.Text = display_window.Text + btn0.Text;
        }


        private void btn_plus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(display_window.Text);

            display_window.Clear();
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(display_window.Text);

            display_window.Clear();
        }

        private void btn_times_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(display_window.Text);

            display_window.Clear();
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(display_window.Text);

            display_window.Clear();
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(display_window.Text);

            if (option.Equals("+"))
            {
                result = num1 + num2;
            }
            else if (option.Equals("-")){
                result = num1 - num2;
            }
            else if (option.Equals("*"))
            {
                result = num1 * num2;
            }
            else if (option.Equals("/")){
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Error");
            }

            display_window.Text = result + "";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            display_window.Clear();
            result = 0;
            num1 = 0;
            num2 = 0;
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            display_window.Clear();
            result = 0;
            num1 = 0;
            num2 = 0;

            this.Close();
        }
    }
}
