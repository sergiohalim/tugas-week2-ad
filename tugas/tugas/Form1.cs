using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = textBox1.Text;
            string gmail = textBox2.Text;
            int age = Int32.Parse(textBox3.Text);
            string phone = textBox4.Text;

            if (age < 18)
            {
                MessageBox.Show($"name: {nama} gmail: {gmail} Phone number {phone}. sorry still underage");
            }
            else 
            {
                MessageBox.Show($"name: {nama} gmail: {gmail} Phone number {phone}. you are adult");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
