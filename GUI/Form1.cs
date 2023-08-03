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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sucessefully Uploaded");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Case has been assigned to Dr T.M. Hlongwane with 5 active cases");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 formview = new Form2();

            formview.Show();
        }
    }
}
