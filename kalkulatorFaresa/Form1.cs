using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulatorFaresa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = double.Parse(this.angkaPertama.Text);
            b = double.Parse(this.angkaKedua.Text);
  
            c = a + b;
            
            this.hasil.Text = c.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            angkaKedua.Clear();
            angkaPertama.Clear();
            hasil.Text = " ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            angkaKedua.Clear();
            angkaPertama.Clear();
            hasil.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = double.Parse(this.angkaPertama.Text);
            b = double.Parse(this.angkaKedua.Text);

            c = a - b;

            this.hasil.Text = c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = double.Parse(this.angkaPertama.Text);
            b = double.Parse(this.angkaKedua.Text);

            c = a / b;

            this.hasil.Text = c.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = double.Parse(this.angkaPertama.Text);
            b = double.Parse(this.angkaKedua.Text);

            c = a * b;

            this.hasil.Text = c.ToString();
        }
    }
}
