using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitRacingGame
{
    public partial class Form1 : Form
    {
        int y = 0,z=10;
        LogicAction logic = new LogicAction();
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            y++;
            if (logic.chk(y) == 1)
            {
                label1.Hide();
            }
            else {
                label1.Show();
            }

            if (z == 100)
            {
                timer1.Stop();
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();

            }
            else {
                progressBar1.Value = z;
                z = z + 10;
            }
        }
    }
}
