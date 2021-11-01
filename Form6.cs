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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        string binaryValue, bit, adder, adder1, adder2, hexi, hexi1, hexi2;

        private void button4_Click(object sender, EventArgs e)
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
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        double numOfBits, numOfBits1, numofbits, total, total1, bitNumber, i = 7, num3;
        private void button1_Click(object sender, EventArgs e)
        {
            
            binaryValue = textBox1.Text;
            if (binaryValue == "")
            {
                binaryValue = "0";

            }
            numOfBits = binaryValue.Length;
            numOfBits1 = numOfBits;
            for (int q = 0; q < numOfBits; q++)
            {

                total1 = (1 * (Math.Pow(2, numOfBits1 - 1)));
                bit = binaryValue.Substring(q, 1);
                if (bit == "1")
                {
                    total += total1;
                }
                numOfBits1--;
                
            }

            if (true)
            {
                numofbits = total;

                if (numofbits <= 255)
                {

                    bitNumber = 7;
                    i = 7;
                    while (i >= 0)
                    {

                        num3 = Math.Pow(2, bitNumber);
                        if (numofbits >= num3)
                        {

                            if (bitNumber <= 7 && bitNumber > 3)
                            {
                                adder += "1";

                            }
                            if (bitNumber <= 3)
                            {
                                adder1 += "1";
                            }

                            numofbits -= num3;
                            bitNumber--;

                        }
                        else
                        {

                            if (bitNumber <= 7 && bitNumber > 3)
                            {
                                adder += "0";

                            }
                            if (bitNumber <= 3)
                            {
                                adder1 += "0";
                            }
                            bitNumber--;

                        }
                        i--;



                    }
                    if (true)
                    {
                        if (adder == "0000")
                        {
                            hexi = "0";
                        }
                        else if (adder == "0001")
                        {
                            hexi = "1";
                        }
                        else if (adder == "0010")
                        {
                            hexi = "2";
                        }
                        else if (adder == "0011")
                        {
                            hexi = "3";
                        }
                        else if (adder == "0100")
                        {
                            hexi = "4";
                        }
                        else if (adder == "0101")
                        {
                            hexi = "5";
                        }
                        else if (adder == "0110")
                        {
                            hexi = "6";
                        }
                        else if (adder == "0111")
                        {
                            hexi = "7";
                        }
                        else if (adder == "1000")
                        {
                            hexi = "8";
                        }
                        else if (adder == "1001")
                        {
                            hexi = "9";
                        }
                        else if (adder == "1010")
                        {
                            hexi = "A";
                        }
                        else if (adder == "1011")
                        {
                            hexi = "B";
                        }
                        else if (adder == "1100")
                        {
                            hexi = "C";
                        }
                        else if (adder == "1101")
                        {
                            hexi = "D";
                        }
                        else if (adder == "1110")
                        {
                            hexi = "E";
                        }
                        else if (adder == "1111")
                        {
                            hexi = "F";
                        }

                        if (adder1 == "0000")
                        {
                            hexi1 = "0";
                        }
                        else if (adder1 == "0001")
                        {
                            hexi1 = "1";
                        }
                        else if (adder1 == "0010")
                        {
                            hexi1 = "2";
                        }
                        else if (adder1 == "0011")
                        {
                            hexi1 = "3";
                        }
                        else if (adder1 == "0100")
                        {
                            hexi1 = "4";
                        }
                        else if (adder1 == "0101")
                        {
                            hexi1 = "5";
                        }
                        else if (adder1 == "0110")
                        {
                            hexi1 = "6";
                        }
                        else if (adder1 == "0111")
                        {
                            hexi1 = "7";
                        }
                        else if (adder1 == "1000")
                        {
                            hexi1 = "8";
                        }
                        else if (adder1 == "1001")
                        {
                            hexi1 = "9";
                        }
                        else if (adder1 == "1010")
                        {
                            hexi1 = "A";
                        }
                        else if (adder1 == "1011")
                        {
                            hexi1 = "B";
                        }
                        else if (adder1 == "1100")
                        {
                            hexi1 = "C";
                        }
                        else if (adder1 == "1101")
                        {
                            hexi1 = "D";
                        }
                        else if (adder1 == "1110")
                        {
                            hexi1 = "E";
                        }
                        else if (adder1 == "1111")
                        {
                            hexi1 = "F";
                        }
                    }

                }

                else
                {
                    bitNumber = 11;
                    i = 11;
                    while (i >= 0)
                    {

                        num3 = Math.Pow(2, bitNumber);
                        if (numofbits >= num3)
                        {

                            if (bitNumber <= 7 && bitNumber > 3)
                            {
                                adder += "1";

                            }
                            if (bitNumber <= 3)
                            {
                                adder1 += "1";
                            }
                            if (bitNumber > 7 || bitNumber >= 12)
                            {
                                adder2 += "1";
                            }

                            numofbits -= num3;
                            bitNumber--;

                        }
                        else
                        {

                            if (bitNumber <= 7 && bitNumber > 3)
                            {
                                adder += "0";

                            }
                            if (bitNumber <= 3)
                            {
                                adder1 += "0";
                            }
                            if (bitNumber > 7 || bitNumber >= 12)
                            {
                                adder2 += "0";
                            }
                            bitNumber--;

                        }
                        i--;



                    }
                    if (true)
                    {
                        if (adder == "0000")
                        {
                            hexi = "0";
                        }
                        else if (adder == "0001")
                        {
                            hexi = "1";
                        }
                        else if (adder == "0010")
                        {
                            hexi = "2";
                        }
                        else if (adder == "0011")
                        {
                            hexi = "3";
                        }
                        else if (adder == "0100")
                        {
                            hexi = "4";
                        }
                        else if (adder == "0101")
                        {
                            hexi = "5";
                        }
                        else if (adder == "0110")
                        {
                            hexi = "6";
                        }
                        else if (adder == "0111")
                        {
                            hexi = "7";
                        }
                        else if (adder == "1000")
                        {
                            hexi = "8";
                        }
                        else if (adder == "1001")
                        {
                            hexi = "9";
                        }
                        else if (adder == "1010")
                        {
                            hexi = "A";
                        }
                        else if (adder == "1011")
                        {
                            hexi = "B";
                        }
                        else if (adder == "1100")
                        {
                            hexi = "C";
                        }
                        else if (adder == "1101")
                        {
                            hexi = "D";
                        }
                        else if (adder == "1110")
                        {
                            hexi = "E";
                        }
                        else if (adder == "1111")
                        {
                            hexi = "F";
                        }

                        if (adder1 == "0000")
                        {
                            hexi1 = "0";
                        }
                        else if (adder1 == "0001")
                        {
                            hexi1 = "1";
                        }
                        else if (adder1 == "0010")
                        {
                            hexi1 = "2";
                        }
                        else if (adder1 == "0011")
                        {
                            hexi1 = "3";
                        }
                        else if (adder1 == "0100")
                        {
                            hexi1 = "4";
                        }
                        else if (adder1 == "0101")
                        {
                            hexi1 = "5";
                        }
                        else if (adder1 == "0110")
                        {
                            hexi1 = "6";
                        }
                        else if (adder1 == "0111")
                        {
                            hexi1 = "7";
                        }
                        else if (adder1 == "1000")
                        {
                            hexi1 = "8";
                        }
                        else if (adder1 == "1001")
                        {
                            hexi1 = "9";
                        }
                        else if (adder1 == "1010")
                        {
                            hexi1 = "A";
                        }
                        else if (adder1 == "1011")
                        {
                            hexi1 = "B";
                        }
                        else if (adder1 == "1100")
                        {
                            hexi1 = "C";
                        }
                        else if (adder1 == "1101")
                        {
                            hexi1 = "D";
                        }
                        else if (adder1 == "1110")
                        {
                            hexi1 = "E";
                        }
                        else if (adder1 == "1111")
                        {
                            hexi1 = "F";
                        }

                        if (adder2 == "0000")
                        {
                            hexi2 = "0";
                        }
                        else if (adder2 == "0001")
                        {
                            hexi2 = "1";
                        }
                        else if (adder2 == "0010")
                        {
                            hexi2 = "2";
                        }
                        else if (adder2 == "0011")
                        {
                            hexi2 = "3";
                        }
                        else if (adder2 == "0100")
                        {
                            hexi2 = "4";
                        }
                        else if (adder2 == "0101")
                        {
                            hexi2 = "5";
                        }
                        else if (adder2 == "0110")
                        {
                            hexi2 = "6";
                        }
                        else if (adder2 == "0111")
                        {
                            hexi2 = "7";
                        }
                        else if (adder2 == "1000")
                        {
                            hexi2 = "8";
                        }
                        else if (adder2 == "1001")
                        {
                            hexi2 = "9";
                        }
                        else if (adder2 == "1010")
                        {
                            hexi2 = "A";
                        }
                        else if (adder2 == "1011")
                        {
                            hexi2 = "B";
                        }
                        else if (adder2 == "1100")
                        {
                            hexi2 = "C";
                        }
                        else if (adder2 == "1101")
                        {
                            hexi2 = "D";
                        }
                        else if (adder2 == "1110")
                        {
                            hexi2 = "E";
                        }
                        else if (adder2 == "1111")
                        {
                            hexi2 = "F";
                        }


                    }


                }
            }
            textBox3.Text = total.ToString();
            textBox2.Text = hexi2 + hexi + hexi1;
            adder = "";
            adder1 = "";
            adder2 = "";
            hexi = "";
            hexi1 = "";
            hexi2 = "";
            total = 0;
        }
    }
}
