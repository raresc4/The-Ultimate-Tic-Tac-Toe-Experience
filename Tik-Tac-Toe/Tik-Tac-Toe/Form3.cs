using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tik_Tac_Toe
{
    public partial class Form3 : Form
    {
        Jucator jucator1;
        Jucator jucator2;
        List<Button> buttons;
        int sw = 0;
        int nrmutari = 0;

        public Form3(Jucator jucator1, Jucator jucator2)
        {
            InitializeComponent();
            this.jucator1 = jucator1;
            this.jucator2 = jucator2;
            label1.Text = jucator1.nume + ": " + Convert.ToString(jucator1.nrvictorii);
            label2.Text = jucator2.nume + ": " + Convert.ToString(jucator2.nrvictorii);
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (Button button in buttons)
            {
                button.Click += new EventHandler(ClickCasuta);
            }
            Restart();
        }
        public void ClickCasuta(object? sender, EventArgs e)
        {
            if (sender != null)
            {
                Button btn = (Button)sender;
                if (!btn.Enabled)
                {
                    return;
                }
                if (sw == 0)
                {
                    btn.Text = "X";
                    sw = 1;
                }
                else
                {
                    btn.Text = "O";
                    sw = 0;
                }
                btn.Enabled = false;
            }
            nrmutari++;
            CheckGame();
        }
        public void CheckGame()
        {
            if (nrmutari <= 3)
            {
                return;
            }
            if ((button1.Text == "O" && button2.Text == "O" && button3.Text == "O") || (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") || (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") || (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") || (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") || (button3.Text == "O" && button6.Text == "O" && button9.Text == "O") || (button1.Text == "O" && button5.Text=="O" && button9.Text=="O") || (button3.Text=="O" && button5.Text=="O" && button7.Text=="O"))
            {
                MessageBox.Show(jucator1.nume + " wins!");
                jucator1.nrvictorii++;
                Restart();
            }
            else if ((button1.Text == "X" && button2.Text == "X" && button3.Text == "X") || (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") || (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") || (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") || (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") || (button3.Text == "X" && button6.Text == "X" && button9.Text == "X") || (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") || (button3.Text == "X" && button5.Text == "X" && button7.Text == "X"))
            {
                MessageBox.Show(jucator2.nume + " wins!");
                jucator2.nrvictorii++;
                Restart();
            }
            else
            {
                if (nrmutari == 9) {
                    MessageBox.Show("Game ended in a draw!");
                    jucator1.nrvictorii += 0.5;
                    jucator2.nrvictorii += 0.5;
                    Restart();
                }
            }
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Restart()
        {

            foreach (Button button in buttons)
            {
                button.Enabled = true;
                button.Text = "X/O";
            }
            nrmutari = 0;
            label1.Text = jucator1.nume + ": " + Convert.ToString(jucator1.nrvictorii);
            label2.Text = jucator2.nume + ": " + Convert.ToString(jucator2.nrvictorii);
            if (nrmutari == 0)
            {
                if (sw == 0) {
                    System.Windows.Forms.MessageBox.Show(jucator2.nume + " to play as X and to move first\n" + jucator1.nume + " to play as O");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(jucator1.nume + " to play as O and to move first\n" + jucator2.nume + " to play as X");
                }
                
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Thanks for playing\nGame created by Rares-Alexandru Catana\nFirst year student at the Faculty of Automation and Computer Science, UPT\n");
            Application.Exit();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Restart();
        }
    }
}
