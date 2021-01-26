using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int factorial = 1, a;
            for (a = 1; a <= 10; a++)
            {
                factorial = factorial * a;
            }
            listBox1.Items.Add(factorial);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int a = 1, b = 1;
            while (a <= 10)
            {
                b = b * a;
                a++;
            }
            listBox1.Items.Add(b);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Ta 1ees hed hurtelh toonii niilber oloh we oruulna uu");
            }
            else
            {
                int a = 1, b, c = 0;
                b = Int32.Parse(textBox1.Text);
                do
                {
                    c = c + a;
                    a++;
                }
                while (a <= b);
                listBox1.Items.Add(c);
                textBox1.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int a = 2, c;
            Boolean ankhni;
            while (a <= 200)
            {
                ankhni = true;
                c = 2;
                while (c <= a - 1)
                {
                    if (a % c == 0)
                    {
                        ankhni = false;
                    }
                    c++;
                }
                if (ankhni == true)
                {
                    listBox1.Items.Add(a);
                }
                a = a + 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int a, c;
            Boolean ankhni;
            for(a=2;a<=200; a++)
            {
                ankhni = true;
                for(c=2; c<=a-1; c++)
                {
                    if (a % c == 0)
                    {
                        ankhni = false;
                    }
                }
                if (ankhni == true)
                {
                    listBox1.Items.Add(a);
                }
            }
        }
    }
}
