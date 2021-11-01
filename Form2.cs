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
    public partial class Form2 : Form
    {
        string binaryValue, bit;
        double bitNumber, numOfBits1, total1, total;

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();
            this.Hide();
            //Application.Exit();

            Form1 f2 = new Form1();
            f2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        int u;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            binaryValue = textBox1.Text;
            if (binaryValue == "")
            {
                binaryValue = "0";

            }
            bitNumber = binaryValue.Length;
            numOfBits1 = bitNumber;
            u = 0;
            for (int q = 0; q < bitNumber; q++)
            {

                total1 = Math.Pow(2, numOfBits1 - 1);
                bit = binaryValue.Substring(u, 1);
                if (bit == "1")
                {
                    total += total1;
                    
                }
                numOfBits1--;
                u++;
            }
            textBox2.Text = total.ToString();
            total = 0;
        }
    }
}
