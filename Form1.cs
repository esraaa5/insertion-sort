using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_task
{
    public partial class Form1 : Form
    {
        public int num1;
        public int num2;
        public int num3;
        public int num4;
        public int num5;
        public int num6;
        public int num7;
        public int num8;



        int[] array = new int[8];

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            num3 = int.Parse(textBox3.Text);
            num4 = int.Parse(textBox4.Text);
            num5 = int.Parse(textBox5.Text);
            num6 = int.Parse(textBox6.Text);
            num7 = int.Parse(textBox7.Text);
            num8 = int.Parse(textBox8.Text);
            array = new int[] { num1, num2, num3, num4, num5, num6, num7, num8 };
            for (int i = 1; i < array.Length; i++)
            {
                var key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > key)
                {


                    array[j + 1] = array[j];
                    j--;
                    array[j + 1] = key;


                }


            }
            string sorted_array = string.Join(",", array);
            lbl2.Text = "insertion sort result :" + sorted_array;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            num3 = int.Parse(textBox3.Text);
            num4 = int.Parse(textBox4.Text);
            num5 = int.Parse(textBox5.Text);
            num6 = int.Parse(textBox6.Text);
            num7 = int.Parse(textBox7.Text);
            num8 = int.Parse(textBox8.Text);
            array = new int[] { num1, num2, num3, num4, num5, num6, num7, num8 };

            

            }
        }
    }

