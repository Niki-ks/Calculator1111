using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1111
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void panel2_Resize(object sender, EventArgs e)
        {
            var newHeight = panel2.Height / 6;
            var newWidth = panel2.Width / 4;

            button1.Height = newHeight;
            button2.Height = newHeight;
            button3.Height = newHeight;
            button4.Height = newHeight;
            button5.Height = newHeight;
            button6.Height = newHeight;
            button7.Height = newHeight;
            button8.Height = newHeight;
            button9.Height = newHeight;
            button10.Height = newHeight;
            button11.Height = newHeight;
            button12.Height = newHeight;
            button13.Height = newHeight;
            button14.Height = newHeight;
            button15.Height = newHeight;
            button16.Height = newHeight;
            button17.Height = newHeight;
            button18.Height = newHeight;
            button19.Height = newHeight;
            button20.Height = newHeight;
            button21.Height = newHeight;
            button22.Height = newHeight;
            button23.Height = newHeight;
            button24.Height = newHeight;

            button1.Width = newWidth;
            button2.Width = newWidth;
            button3.Width = newWidth;
            button4.Width = newWidth;
            button5.Width = newWidth;
            button6.Width = newWidth;
            button7.Width = newWidth;
            button8.Width = newWidth;
            button9.Width = newWidth;
            button10.Width = newWidth;
            button11.Width = newWidth;
            button12.Width = newWidth;
            button13.Width = newWidth;
            button14.Width = newWidth;
            button15.Width = newWidth;
            button16.Width = newWidth;
            button17.Width = newWidth;
            button18.Width = newWidth;
            button19.Width = newWidth;
            button20.Width = newWidth;
            button21.Width = newWidth;
            button22.Width = newWidth;
            button23.Width = newWidth;
            button24.Width = newWidth;
            button1.Width = newWidth;

            button1.Top = 0;
            button2.Top = 0;
            button3.Top = 0;
            button4.Top = 0;

            button5.Top = newHeight;
            button6.Top = newHeight;
            button7.Top = newHeight;
            button8.Top = newHeight;

            var nh = panel2.Height * 2 / 6;
            button9.Top = nh;
            button10.Top = nh;
            button11.Top = nh;
            button12.Top = nh;

            
            button13.Top = panel2.Height * 3 / 6;
            button14.Top = panel2.Height * 3 / 6;
            button15.Top = panel2.Height * 3 / 6;
            button16.Top = panel2.Height * 3 / 6;

            button17.Top = panel2.Height * 4 / 6;
            button18.Top = panel2.Height * 4 / 6;
            button19.Top = panel2.Height * 4 / 6;
            button20.Top = panel2.Height * 4 / 6;

            button21.Top = panel2.Height * 5 / 6;
            button22.Top = panel2.Height * 5 / 6;
            button23.Top = panel2.Height * 5 / 6;
            button24.Top = panel2.Height * 5 / 6;



            button1.Left = 0;
            button5.Left = 0;
            button9.Left = 0;
            button13.Left = 0;
            button17.Left = 0;
            button21.Left = 0;

            button2.Left = panel2.Width / 4;
            button6.Left = panel2.Width / 4;
            button10.Left = panel2.Width / 4;
            button14.Left = panel2.Width / 4;
            button18.Left = panel2.Width / 4;
            button22.Left = panel2.Width / 4;

            button3.Left = panel2.Width / 2;
            button7.Left = panel2.Width / 2;
            button11.Left = panel2.Width / 2;
            button15.Left = panel2.Width / 2;
            button19.Left = panel2.Width / 2;
            button23.Left = panel2.Width / 2;

            button4.Left = panel2.Width * 3 / 4;
            button8.Left = panel2.Width * 3 / 4;
            button12.Left = panel2.Width * 3 / 4;
            button16.Left = panel2.Width * 3 / 4;
            button20.Left = panel2.Width * 3 / 4;
            button24.Left = panel2.Width * 3 / 4;








        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2_Resize(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            textBox1.Text = textBox1.Text + b.Text;

            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text.IndexOf(",") > 0 && b.Text == ",")
            {
                return;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length -1 == 0)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        string action;
        string number1;

        private void button12_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            action = b.Text;
            number1 = textBox1.Text;
            textBox1.Text = "";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (action == "+")
            {
                textBox1.Text = (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(number1)).ToString();
            }
            if (action == "-")
            {
                textBox1.Text = (Convert.ToDouble(number1) - Convert.ToDouble(textBox1.Text)).ToString();
            }
            if (action == "×")
            {
                textBox1.Text = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(number1)).ToString();
            }
            if (action == "÷")
            {
                textBox1.Text = (Convert.ToDouble(number1) / Convert.ToDouble(textBox1.Text)).ToString();
            }
            if (action == "%")
            {
                textBox1.Text = (Convert.ToDouble(number1) / 100 * Convert.ToDouble(textBox1.Text)).ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = (1 / Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Sqrt(Convert.ToDouble(textBox1.Text))).ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = (-Convert.ToDouble(textBox1.Text)).ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            action = "%";
            number1 = textBox1.Text;
            textBox1.Text = "";
        }
    }
}
