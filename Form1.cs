using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculetorNew
{
    public partial class Form1 : Form
    {
        string operat = "";
        double num1, num2;

        private void numberValue(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (textDisply.Text == "0")
                textDisply.Text = "";

            if (b.Text == ".")
            {
                if (!textDisply.Text.Contains("."))
                    textDisply.Text = textDisply.Text + b.Text;
            }

            else
                textDisply.Text = textDisply.Text + b.Text;
        }



        private void C_Button_Click(object sender, EventArgs e)
        {
            textDisply.Text = "0";
        }

        private void CE_Button_Click(object sender, EventArgs e)
        {
            textDisply.Text = "0";

            string f, s;
            f = Convert.ToString(num1);
            s = Convert.ToString(num2);

            s = "";
            f = "";
        }

        private void Operationals(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            num1 = double.Parse(textDisply.Text);
            operat = b.Text;
            textDisply.Text = "";
        }

        private void Del_Button_Click(object sender, EventArgs e)
        {
            if (textDisply.Text.Length > 0)
                textDisply.Text = textDisply.Text.Remove(textDisply.Text.Length - 1, 1);

            if (textDisply.Text == "")
                textDisply.Text = "0";
        }

        private void Equal_Button_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textDisply.Text);
            switch (operat)
            {
                case "+":
                    textDisply.Text = Convert.ToString(num1 + num2);
                    break;

                case "-":
                    textDisply.Text = Convert.ToString(num1 - num2);
                    break;

                case "*":
                    textDisply.Text = Convert.ToString(num1 * num2);
                    break;

                case "/":
                    textDisply.Text = Convert.ToString(num1 / num2);
                    break;

                default:
                    break;
            }
        }



        public Form1()
        {
            InitializeComponent();
        }
    }
}
