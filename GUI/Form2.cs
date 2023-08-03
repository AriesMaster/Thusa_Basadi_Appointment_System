using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label10.Hide();
            label1.Hide();
            label2.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            button2.Hide();
            textBox1.Hide();
           textBox2.Hide();
            radioButton2.Hide();
            radioButton3.Hide();
            radioButton4.Hide();
            radioButton5.Hide();
            label6.Hide();
            label7.Hide();
            textBox3.Hide();
            label9.Hide();
            button6.Hide();
            textBox4.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label10.Show();
            label1.Show();
            label2.Show(); ;
            checkBox1.Show();
            checkBox2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            button2.Show();
            textBox1.Show();
            textBox2.Show();
            radioButton2.Show();
            radioButton3.Show();
            radioButton4.Show();
            radioButton5.Show();
            label6.Hide();
            label7.Hide();
            textBox3.Hide();
            label9.Hide();
            button6.Hide();
            textBox4.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Victicm successfully registered to be a visitor ,an Active case has been added to DR Hlongwane");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label6.Show();
            label10.Hide();
            label1.Hide();
            label2.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            button2.Hide();
            textBox1.Hide();
            textBox2.Hide();
            radioButton2.Hide();
            radioButton3.Hide();
            radioButton4.Hide();
            radioButton5.Hide();
            label7.Show();
            textBox3.Show();
            label9.Show();
            button6.Show();
            textBox4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successufully inactive victim and database is updated");
        }
    }
}
