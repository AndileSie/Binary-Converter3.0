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
    public partial class Form5 : Form
    {
        string text, txt, adder, hexi, hexi121, hexiValue1 = "", bit;

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; 
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Form1 f2 = new Form1();
            f2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        double textlength, textNum, hexi12, total1, hexi122, numOfBits1, total;
        int i = 0;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            text = textBox1.Text;
            if (text == "")
            {
                text = "0";

            }
            textlength = text.Length;
            
            for (int r = 0; r < textlength; r++)
            {
                adder = text.Substring(r, 1);
               
                if (true)
                {
                    if (adder == "0")
                    {
                        hexi = "0000";
                    }
                    else if (adder == "1")
                    {
                        hexi = "0001";
                    }
                    else if (adder == "2")
                    {
                        hexi = "0010";
                    }
                    else if (adder == "3")
                    {
                        hexi = "0011";
                    }
                    else if (adder == "4")
                    {
                        hexi = "0100";
                    }
                    else if (adder == "5")
                    {
                        hexi = "0101";
                    }
                    else if (adder == "6")
                    {
                        hexi = "0110";
                    }
                    else if (adder == "7")
                    {
                        hexi = "0111";
                    }
                    else if (adder == "8")
                    {
                        hexi = "1000";
                    }
                    else if (adder == "9")
                    {
                        hexi = "1001";
                    }
                    else if (adder == "A")
                    {
                        hexi = "1010";
                    }
                    else if (adder == "B")
                    {
                        hexi = "1011";
                    }
                    else if (adder == "C")
                    {
                        hexi = "1100";
                    }
                    else if (adder == "D")
                    {
                        hexi = "1101";
                    }
                    else if (adder == "E")
                    {
                        hexi = "1110";
                    }
                    else if (adder == "F")
                    {
                        hexi = "1111";
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Valid Values." + "\n Now Closing.");
                        Application.Exit();
                    }
                    
                    
                }
                hexi121 = hexi121 + hexi;
                
            }
            hexi12 = hexi121.Length;
            numOfBits1 = hexi12;
            for (int i = 0; i < hexi12; i++)
            {
                total1 = Math.Pow(2, numOfBits1 - 1);
                bit = hexi121.Substring(i, 1);
                if (bit == "1")
                {
                    total += total1;

                }
                numOfBits1--;
                
            }
            hexi = total.ToString();
            textBox2.Text = hexi121;
            textBox3.Text = hexi;

            hexi121 = "";
            total = 0;


        }
    }
}
