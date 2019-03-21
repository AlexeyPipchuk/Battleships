using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolmagorov
{
    public partial class Kolmagorov_Battleships : Form
    {
        public Kolmagorov_Battleships()
        {
            InitializeComponent();
            SetShips(1);
            SetShips(2);
            SetLabel();
            SetlinkOnField();
            button3.Enabled = false;
            for (int i = 0; i < 49; i++)
            {
                MyButton.MBtns[i].Enabled = false;
                MyButton.Btns[i].Enabled = false;
            }
        }

        private void Kolmagorov_Battleships_Load(object sender, EventArgs e)
        {

        }

        private void battlefield1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Kolmagorov_Battleships_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)  // start
        {
            for (int i = 0; i < 49; i++)
            {
                MyButton.MBtns[i].Enabled = true;
                MyButton.Btns[i].Enabled = true;
            }
            button2.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e) // random
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e) // restart
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 49; i++)
            {
                if (MyButton.Btns[i].state == States.ship && MyButton.Btns[i].BackColor == System.Drawing.SystemColors.Highlight)
                    MyButton.Btns[i].BackColor = System.Drawing.Color.Yellow;
            }
        }
    }
}
