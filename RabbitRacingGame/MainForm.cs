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
    public partial class MainForm : Form
    {
        Instruction pujara = new Instruction();
        Instruction dhawan = new Instruction();
        Instruction ranjit = new Instruction();
        int rabit = 0;
        int plyer = 0;
        public MainForm()
        {
            InitializeComponent();

            pujara.budget = 50;
            pujara.Name = "";
            dhawan.budget = 50;
            dhawan.Name = "";
            ranjit.budget = 50;
            ranjit.Name = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // changing var value according to rabbit selected

        private void rabbit_one_CheckedChanged(object sender, EventArgs e)
        {
            if (rabbit_one.Checked==true) {
                rabit = 1;
            }
        }

        // changing var value according to rabbit selected

        private void rabbit_two_CheckedChanged(object sender, EventArgs e)
        {
            if (rabbit_two.Checked == true)
            {
                rabit = 2;
            }
        }

        // changing var value according to rabbit selected

        private void rabbit_three_CheckedChanged(object sender, EventArgs e)
        {
            if (rabbit_three.Checked == true)
            {
                rabit = 3;
            }
        }

        // changing var value according to rabbit selected 

        private void rabbit_four_CheckedChanged(object sender, EventArgs e)
        {
            if (rabbit_four.Checked == true)
            {
                rabit = 4;
            }
        }

        // changing var value according to player selected 

        private void pujara_player_CheckedChanged(object sender, EventArgs e)
        {
            if (pujara_player.Checked==true) {
                plyer = 1;
            }
        }

        // changing var value according to player selected 

        private void dhawan_player_CheckedChanged(object sender, EventArgs e)
        {
            if (dhawan_player.Checked == true)
            {
                plyer = 2;
            }
        }

        // changing var value according to player selected 

        private void ranjit_player_CheckedChanged(object sender, EventArgs e)
        {
            if (ranjit_player.Checked == true)
            {
                plyer = 3;
            }
        }

        // function displaying according to the conditions selected

        private void clear_bet_button_Click(object sender, EventArgs e)
        {
            switch (plyer) {
                case 1:
                    if (Bet_box.SelectedIndex >= 1 && Convert.ToInt32(Bet_box.SelectedIndex.ToString())<=pujara.budget)
                    {
                        if (rabit>0) {
                            pujara.Name = "Pujara";
                            pujara.bet = Convert.ToInt32(Bet_box.SelectedItem.ToString());
                            pujara.rabit = rabit;
                            pujara_player.Text = "Pujara selected Rabbit " + pujara.rabit + "with" + pujara.bet;
                            plyer = 0;
                            rabit = 0;
                            Bet_box.SelectedIndex = -1;
                            race_button.Enabled = true;
                            rabbit_one.Checked = false; rabbit_two.Checked = false; rabbit_three.Checked = false; rabbit_four.Checked = false;
                            pujara_player.Checked = false; dhawan_player.Checked = false; ranjit_player.Checked = false;
                            Bet_box.SelectedIndex = -1;

                        }
                        else {
                            MessageBox.Show("You need to select the rabit for the bet ");
                        }
                    }
                    else {
                        MessageBox.Show("we need to select the bet amount or need to check the budget ");
                    }
                    

                break;
                case 2:
                    if (Bet_box.SelectedIndex >= 1 && Convert.ToInt32(Bet_box.SelectedIndex.ToString()) <= dhawan.budget)
                    {
                        if (rabit > 0)
                        {
                            dhawan.Name = "Dhawan";
                            dhawan.bet = Convert.ToInt32(Bet_box.SelectedItem.ToString());
                            dhawan.rabit = rabit;
                            dhawan_player.Text = "Dhawan selected Rabbit " + dhawan.rabit + "with" + dhawan.bet;
                            plyer = 0;
                            rabit = 0;
                            Bet_box.SelectedIndex = -1;
                            race_button.Enabled = true;

                            rabbit_one.Checked = false; rabbit_two.Checked = false; rabbit_three.Checked = false; rabbit_four.Checked = false;
                            pujara_player.Checked = false;dhawan_player.Checked = false;ranjit_player.Checked = false;
                            Bet_box.SelectedIndex = -1;



                        }
                        else
                        {
                            MessageBox.Show("You need to select the rabit for the bet ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("we need to select the bet amount or need to check the budget ");
                    }


                    break;
                case 3:
                    if (Bet_box.SelectedIndex >= 1 && Convert.ToInt32(Bet_box.SelectedIndex.ToString()) <= ranjit.budget)
                    {
                        if (rabit > 0)
                        {
                            ranjit.Name = "Ranjit";
                            ranjit.bet = Convert.ToInt32(Bet_box.SelectedItem.ToString());
                            ranjit.rabit = rabit;
                            ranjit_player.Text = "Ranjit selected Rabbit " + ranjit.rabit + "with " + ranjit.bet;
                            plyer = 0;
                            rabit = 0;
                            Bet_box.SelectedIndex = -1;
                            race_button.Enabled = true;
                            rabbit_one.Checked = false; rabbit_two.Checked = false; rabbit_three.Checked = false; rabbit_four.Checked = false;
                            pujara_player.Checked = false; dhawan_player.Checked = false; ranjit_player.Checked = false;
                            Bet_box.SelectedIndex = -1;

                        }
                        else
                        {
                            MessageBox.Show("You need to select the rabit for the bet ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("we need to select the bet amount or need to check the budget ");
                    }
                    break;
                default:
                    MessageBox.Show("You need to select the player first ");
                    break;
            }
        }

        private void race_button_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pic_rabbit1.Left += pujara.Jump();
            pic_rabbit2.Left += ranjit.Jump();
            pic_rabbit3.Left += dhawan.Jump();
            pic_rabbit4.Left += pujara.Jump();


            if (pic_rabbit1.Left>810) {
                timer1.Stop();
                MessageBox.Show("First rabit won the Race");
                pujara.winner = 1;
                result(1);

            }

            if (pic_rabbit2.Left > 810)
            {
                timer1.Stop();
                MessageBox.Show("2nd rabit won the Race");
                pujara.winner = 2;
                result(2);
            }
            if (pic_rabbit3.Left > 810)
            {
                timer1.Stop();
                MessageBox.Show("3rd rabit won the Race");
                pujara.winner = 3;
                result(3);
            }
            if (pic_rabbit4.Left > 800)
            {
                timer1.Stop();
                MessageBox.Show("4th rabit won the Race");
                pujara.winner = 4;
                result(4);
            }


        }

        // result function displaying player names

        public void result(int winner) {
            if (!pujara.Name.Equals("")) {
                pujara.winner = winner;
                pujara.budget = pujara.working();
                pujara_player.Text = "Pujara has $" + pujara.budget;
            }
            
            if (!dhawan.Name.Equals(""))
            {
                dhawan.winner = winner;
                dhawan.budget = dhawan.working();
                dhawan_player.Text = "dhawan has $" + dhawan.budget;
            }


            if (!ranjit.Name.Equals(""))
            {
                ranjit.winner = winner;
                ranjit.budget = ranjit.working();
                ranjit_player.Text = "Ranjit has $" + ranjit.budget;
            }

            race_button.Enabled = false;
            
            pic_rabbit1.Left=0; pic_rabbit2.Left = 0; pic_rabbit3.Left = 0; pic_rabbit4.Left = 0;

            rabbit_one.Checked = false; rabbit_two.Checked = false; rabbit_three.Checked = false; rabbit_four.Checked = false;
            pujara_player.Checked = false; dhawan_player.Checked = false; ranjit_player.Checked = false;
            Bet_box.SelectedIndex = -1;

            
            pujara.Name = "";
            
            dhawan.Name = "";
            
            ranjit.Name = "";

        }

        private void exit_race_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
