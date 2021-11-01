using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary_Converter3._0
{
    public partial class Form3 : Form
    {
        string textbox, adder, fq;
        double bitNumber, num3;
        double textboxnum, numofbits, i;

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Form1 f2 = new Form1();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textbox = textBox1.Text;
            if (textbox == "")
            {
                textbox = "0";
            }
            textboxnum = int.Parse(textbox);
            numofbits = textboxnum;
            i = 7;
            if (numofbits <= 255)
            {
                bitNumber = 7;
                while (i >= 0)
                {

                    num3 = Math.Pow(2, bitNumber);
                    //Console.Write(num3 + "\t");
                    if (numofbits >= num3)
                    {
                        //Console.Write("1");
                        adder = adder + "1";
                        numofbits -= num3;
                        bitNumber--;
                        //bin = bin + "1";
                        if (bitNumber == 8 || bitNumber == 3)
                        {
                            //Console.Write("  ");
                            adder = adder + "  ";
                            //bin += "  ";
                        }

                    }
                    else
                    {
                        //Console.Write("0");
                        adder = adder + "0";
                        bitNumber--;
                        //bin = bin + "0";
                        if (bitNumber == 8 || bitNumber == 3)
                        {
                            //Console.Write("  ");
                            adder = adder + "  ";

                            //bin = bin + "0";
                        }
                    }
                    i--;
                }
            }
            else if (numofbits < 7936)
            {
                bitNumber = 11;
                i = 12;
                while (i >= 1)
                {

                    num3 = Math.Pow(2, bitNumber);
                    if (numofbits >= num3)
                    {
                        //Console.Write("1");
                        adder = adder + "1";

                        numofbits -= num3;
                        bitNumber--;
                        if (bitNumber == 3 || bitNumber == 7 || bitNumber == 12)
                        {
                            //Console.Write("  ");
                            adder = adder + "  ";

                        }
                    }
                    else
                    {
                        //Console.Write("0");
                        adder = adder + "0";
                        bitNumber--;
                        if (bitNumber == 3 || bitNumber == 7 || bitNumber == 12)
                        {
                            //Console.Write("  ");
                            adder = adder + "  ";

                        }

                    }

                    i--;
                }
            }
            else if (numofbits > 7936 && numofbits <= 122880)
            {
                bitNumber = 16;
                i = 17;
                while (i >= 1)
                {

                    num3 = Math.Pow(2, bitNumber);
                    if (numofbits >= num3)
                    {
                        //Console.Write("1");
                        adder = adder + "1";
                        numofbits -= num3;
                        bitNumber--;
                        if (bitNumber == 7 || bitNumber == 3 || bitNumber == 12 || bitNumber == 16)
                        {
                            Console.Write("  ");
                            adder = adder + "  ";

                        }
                    }
                    else
                    {
                        //Console.Write("0");
                        adder = adder + "0";
                        bitNumber--;
                        if (bitNumber == 7 || bitNumber == 3 || bitNumber == 12 || bitNumber == 16)
                        {
                            //Console.Write("  ");
                            adder = adder + "  ";

                        }

                    }

                    i--;
                }
            }
            textBox2.Text = adder;
            adder = "";
        }
    }
}
