using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        List<char> operatii;
        double nr1;
        double nr2;
        char operation;
        public Form1()
        {
            operatii = new List<char>();
            operatii.Add('+');
            operatii.Add('-');
            operatii.Add('/');
            operatii.Add('*');
            InitializeComponent();
            this.KeyPreview = true;
            this.ActiveControl = textBox1;
        }
        private void inserareOp(char op)
        {
            if (textBox1.Text.Length == 0)
            {
                if (op == '+' || op == '-')
                {
                    textBox1.Text += op;
                }
                return;
            }
            if (operatii.Contains(textBox1.Text[textBox1.TextLength - 1]))
            {
                MessageBox.Show("Nu poti sa adaugi 2 operatii/semne una/unul dupa cealalta");
                return;
            }
            nr1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
            operation = op;
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            inserareOp('+');
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {

            inserareOp('-');
        }

        private void buttonInmultire_Click(object sender, EventArgs e)
        {
            inserareOp('*');
        }

        private void buttonImpartire_Click(object sender, EventArgs e)
        {
            inserareOp('/');
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("Un numar nu poate incepe cu virgula.");
                return;
            }
            if (textBox1.Text.Contains(","))
            {
                MessageBox.Show("Un numar poate sa contina maxim o virgula.");
                return;
            }
            textBox1.Text += ".";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nr2 = double.Parse(textBox1.Text);

            if (operation == '+')
            {
                textBox1.Text = (nr1 + nr2).ToString();
            }
            else if (operation == '-')
            {
                textBox1.Text = (nr1 + nr2).ToString();
            }
            else if (operation == '*')
            {
                textBox1.Text = (nr1 * nr2).ToString();
            }
            else
            {
                textBox1.Text = (nr1 / nr2).ToString();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || (e.KeyCode == Keys.Oemplus && !e.Shift))
            {
                button2_Click(sender, e);
                //MessageBox.Show("Enter");
            }
            else if (e.KeyCode == Keys.D0)
            {
                button7_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D1)
            {
                button6_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D2)
            {
                button5_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D3)
            {
                button4_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D4)
            {
                button3_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D5)
            {
                button12_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D6)
            {
                button11_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D7)
            {
                button10_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D8)
            {
                if (e.Shift)
                {
                    buttonInmultire_Click(sender, e);
                    return;
                }

                button9_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D9)
            {
                button8_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Oemplus & e.Shift)
            {
                buttonPlus_Click(sender, e);
            }
            else if (e.KeyCode == Keys.OemMinus)
            {
                buttonMinus_Click(sender, e);
            }
            else if (e.KeyCode == Keys.OemQuestion)
            {
                buttonImpartire_Click(sender, e);
            }
            else if (e.KeyData == Keys.O)
            {
                buttonInmultire_Click(sender, e);
            }
            else if(e.KeyData == Keys.Oemcomma)
            {
                button1_Click(sender, e);
            }
          
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

    }
}
