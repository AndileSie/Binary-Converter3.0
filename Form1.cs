using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Topshelf.Runtime.Windows;

namespace Binary_Converter3._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f1 = new Form2();
            f1.ShowDialog();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            NormalPathOfExectution();
            
        }
        static void NormalPathOfExectution()
        {
            Console.WriteLine("Doing something here");
            //need one of these for each additional console window
            //System.Diagnostics.Process.Start("Proof of Concept 2.exe", "1");
            Console.ReadLine();

        }
        private static void AlternatePathOfExecution()
        {
            Console.WriteLine("Write something different on other Console");
            Console.ReadLine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f2 = new Form3();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f2 = new Form4();
            f2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f2 = new Form6();
            f2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f2 = new Form5();
            f2.ShowDialog();
        }
    }
}
