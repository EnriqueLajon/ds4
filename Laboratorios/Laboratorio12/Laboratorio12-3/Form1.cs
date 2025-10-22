using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio12_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // SEMIPERÍMETRO
        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, semiperimetro;

            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);

            semiperimetro = (a + b + c) / 2;

            textBox4.Text = semiperimetro.ToString();
        }

        // ÁREA
        private void button2_Click(object sender, EventArgs e)
        {
            double a, b, c, s, area;

            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);

            s = (a + b + c) / 2;
            area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            textBox5.Text = area.ToString();
        }

        // RESET
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        // SALIDA
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }
    }
}