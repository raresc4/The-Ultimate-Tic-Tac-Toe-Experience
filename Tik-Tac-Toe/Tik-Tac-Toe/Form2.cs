using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tik_Tac_Toe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numejucator1 = textBox2.Text;
            Jucator jucator1 = new Jucator(numejucator1, 0);
            string numejucator2 = textBox3.Text;
            Jucator jucator2 = new Jucator(numejucator2, 0);
            System.Windows.Forms.MessageBox.Show("Get ready\nThe game is about to being\n");
            Form3 form3 = new Form3(jucator1, jucator2);
            form3.Show();
            Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
