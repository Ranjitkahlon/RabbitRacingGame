
namespace RabbitRacingGame
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pujara_player = new System.Windows.Forms.RadioButton();
            this.dhawan_player = new System.Windows.Forms.RadioButton();
            this.ranjit_player = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rabbit_one = new System.Windows.Forms.RadioButton();
            this.rabbit_two = new System.Windows.Forms.RadioButton();
            this.rabbit_three = new System.Windows.Forms.RadioButton();
            this.rabbit_four = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Bet_box = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pic_rabbit2 = new System.Windows.Forms.PictureBox();
            this.pic_rabbit3 = new System.Windows.Forms.PictureBox();
            this.pic_rabbit4 = new System.Windows.Forms.PictureBox();
            this.pic_rabbit1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clear_bet_button = new System.Windows.Forms.Button();
            this.race_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.exit_race = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rabbit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rabbit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rabbit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rabbit1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exit_race);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Bet_box);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(304, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 204);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Bet Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pujara_player);
            this.groupBox4.Controls.Add(this.dhawan_player);
            this.groupBox4.Controls.Add(this.ranjit_player);
            this.groupBox4.Location = new System.Drawing.Point(468, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(260, 169);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Player Selection";
            // 
            // pujara_player
            // 
            this.pujara_player.AutoSize = true;
            this.pujara_player.Font = new System.Drawing.Font("Myriad Pro Cond", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pujara_player.Location = new System.Drawing.Point(16, 19);
            this.pujara_player.Name = "pujara_player";
            this.pujara_player.Size = new System.Drawing.Size(97, 20);
            this.pujara_player.TabIndex = 0;
            this.pujara_player.TabStop = true;
            this.pujara_player.Text = "Pujara has $50 ";
            this.pujara_player.UseVisualStyleBackColor = true;
            this.pujara_player.CheckedChanged += new System.EventHandler(this.pujara_player_CheckedChanged);
            // 
            // dhawan_player
            // 
            this.dhawan_player.AutoSize = true;
            this.dhawan_player.Font = new System.Drawing.Font("Myriad Pro Cond", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dhawan_player.Location = new System.Drawing.Point(16, 59);
            this.dhawan_player.Name = "dhawan_player";
            this.dhawan_player.Size = new System.Drawing.Size(104, 20);
            this.dhawan_player.TabIndex = 1;
            this.dhawan_player.TabStop = true;
            this.dhawan_player.Text = "Dhawan has $50 ";
            this.dhawan_player.UseVisualStyleBackColor = true;
            this.dhawan_player.CheckedChanged += new System.EventHandler(this.dhawan_player_CheckedChanged);
            // 
            // ranjit_player
            // 
            this.ranjit_player.AutoSize = true;
            this.ranjit_player.Font = new System.Drawing.Font("Myriad Pro Cond", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ranjit_player.Location = new System.Drawing.Point(16, 106);
            this.ranjit_player.Name = "ranjit_player";
            this.ranjit_player.Size = new System.Drawing.Size(94, 20);
            this.ranjit_player.TabIndex = 3;
            this.ranjit_player.TabStop = true;
            this.ranjit_player.Text = "Ranjit has $50 ";
            this.ranjit_player.UseVisualStyleBackColor = true;
            this.ranjit_player.CheckedChanged += new System.EventHandler(this.ranjit_player_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rabbit_one);
            this.groupBox3.Controls.Add(this.rabbit_two);
            this.groupBox3.Controls.Add(this.rabbit_three);
            this.groupBox3.Controls.Add(this.rabbit_four);
            this.groupBox3.Location = new System.Drawing.Point(291, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 170);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rabbit Selection";
            // 
            // rabbit_one
            // 
            this.rabbit_one.AutoSize = true;
            this.rabbit_one.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabbit_one.Location = new System.Drawing.Point(23, 19);
            this.rabbit_one.Name = "rabbit_one";
            this.rabbit_one.Size = new System.Drawing.Size(97, 27);
            this.rabbit_one.TabIndex = 4;
            this.rabbit_one.TabStop = true;
            this.rabbit_one.Text = "Rabbit One";
            this.rabbit_one.UseVisualStyleBackColor = true;
            this.rabbit_one.CheckedChanged += new System.EventHandler(this.rabbit_one_CheckedChanged);
            // 
            // rabbit_two
            // 
            this.rabbit_two.AutoSize = true;
            this.rabbit_two.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabbit_two.Location = new System.Drawing.Point(23, 52);
            this.rabbit_two.Name = "rabbit_two";
            this.rabbit_two.Size = new System.Drawing.Size(99, 27);
            this.rabbit_two.TabIndex = 5;
            this.rabbit_two.TabStop = true;
            this.rabbit_two.Text = "Rabbit Two";
            this.rabbit_two.UseVisualStyleBackColor = true;
            this.rabbit_two.CheckedChanged += new System.EventHandler(this.rabbit_two_CheckedChanged);
            // 
            // rabbit_three
            // 
            this.rabbit_three.AutoSize = true;
            this.rabbit_three.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabbit_three.Location = new System.Drawing.Point(23, 85);
            this.rabbit_three.Name = "rabbit_three";
            this.rabbit_three.Size = new System.Drawing.Size(108, 27);
            this.rabbit_three.TabIndex = 6;
            this.rabbit_three.TabStop = true;
            this.rabbit_three.Text = "Rabbit Three";
            this.rabbit_three.UseVisualStyleBackColor = true;
            this.rabbit_three.CheckedChanged += new System.EventHandler(this.rabbit_three_CheckedChanged);
            // 
            // rabbit_four
            // 
            this.rabbit_four.AutoSize = true;
            this.rabbit_four.Font = new System.Drawing.Font("Myriad Pro Cond", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabbit_four.Location = new System.Drawing.Point(20, 121);
            this.rabbit_four.Name = "rabbit_four";
            this.rabbit_four.Size = new System.Drawing.Size(102, 27);
            this.rabbit_four.TabIndex = 7;
            this.rabbit_four.TabStop = true;
            this.rabbit_four.Text = "Rabbit Four";
            this.rabbit_four.UseVisualStyleBackColor = true;
            this.rabbit_four.CheckedChanged += new System.EventHandler(this.rabbit_four_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(382, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select Rabbit &  Betters from RadioButtons";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Bet from ComboBox";
            // 
            // Bet_box
            // 
            this.Bet_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Bet_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bet_box.ForeColor = System.Drawing.SystemColors.Info;
            this.Bet_box.FormattingEnabled = true;
            this.Bet_box.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50"});
            this.Bet_box.Location = new System.Drawing.Point(84, 77);
            this.Bet_box.Name = "Bet_box";
            this.Bet_box.Size = new System.Drawing.Size(121, 26);
            this.Bet_box.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Chocolate;
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pictureBox5);
            this.groupBox2.Controls.Add(this.pic_rabbit2);
            this.groupBox2.Controls.Add(this.pic_rabbit3);
            this.groupBox2.Controls.Add(this.pic_rabbit4);
            this.groupBox2.Controls.Add(this.pic_rabbit1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(12, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1005, 423);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Racing Track";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(846, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 26);
            this.label10.TabIndex = 20;
            this.label10.Text = "Race Finished";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(846, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 26);
            this.label9.TabIndex = 19;
            this.label9.Text = "Race Finished";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(846, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 26);
            this.label8.TabIndex = 18;
            this.label8.Text = "Race Finished";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(475, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 26);
            this.label7.TabIndex = 17;
            this.label7.Text = "Rabbit 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(475, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Rabbit 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(475, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Rabbit 4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(475, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Rabbit 1";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.SaddleBrown;
            this.pictureBox5.Location = new System.Drawing.Point(934, 10);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(71, 413);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pic_rabbit2
            // 
            this.pic_rabbit2.Image = global::RabbitRacingGame.Properties.Resources.rabbit3;
            this.pic_rabbit2.Location = new System.Drawing.Point(6, 135);
            this.pic_rabbit2.Name = "pic_rabbit2";
            this.pic_rabbit2.Size = new System.Drawing.Size(147, 86);
            this.pic_rabbit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_rabbit2.TabIndex = 3;
            this.pic_rabbit2.TabStop = false;
            // 
            // pic_rabbit3
            // 
            this.pic_rabbit3.Image = global::RabbitRacingGame.Properties.Resources.rabbit5;
            this.pic_rabbit3.Location = new System.Drawing.Point(6, 236);
            this.pic_rabbit3.Name = "pic_rabbit3";
            this.pic_rabbit3.Size = new System.Drawing.Size(147, 86);
            this.pic_rabbit3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_rabbit3.TabIndex = 2;
            this.pic_rabbit3.TabStop = false;
            // 
            // pic_rabbit4
            // 
            this.pic_rabbit4.Image = global::RabbitRacingGame.Properties.Resources.rabbit4;
            this.pic_rabbit4.Location = new System.Drawing.Point(6, 337);
            this.pic_rabbit4.Name = "pic_rabbit4";
            this.pic_rabbit4.Size = new System.Drawing.Size(147, 86);
            this.pic_rabbit4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_rabbit4.TabIndex = 1;
            this.pic_rabbit4.TabStop = false;
            // 
            // pic_rabbit1
            // 
            this.pic_rabbit1.Image = global::RabbitRacingGame.Properties.Resources.rabbit2;
            this.pic_rabbit1.Location = new System.Drawing.Point(6, 29);
            this.pic_rabbit1.Name = "pic_rabbit1";
            this.pic_rabbit1.Size = new System.Drawing.Size(147, 86);
            this.pic_rabbit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_rabbit1.TabIndex = 0;
            this.pic_rabbit1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Controling Buttons";
            // 
            // clear_bet_button
            // 
            this.clear_bet_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.clear_bet_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_bet_button.ForeColor = System.Drawing.SystemColors.Control;
            this.clear_bet_button.Location = new System.Drawing.Point(46, 75);
            this.clear_bet_button.Name = "clear_bet_button";
            this.clear_bet_button.Size = new System.Drawing.Size(178, 40);
            this.clear_bet_button.TabIndex = 12;
            this.clear_bet_button.Text = "Fix Bet";
            this.clear_bet_button.UseVisualStyleBackColor = false;
            this.clear_bet_button.Click += new System.EventHandler(this.clear_bet_button_Click);
            // 
            // race_button
            // 
            this.race_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.race_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race_button.ForeColor = System.Drawing.SystemColors.Control;
            this.race_button.Location = new System.Drawing.Point(46, 132);
            this.race_button.Name = "race_button";
            this.race_button.Size = new System.Drawing.Size(178, 40);
            this.race_button.TabIndex = 13;
            this.race_button.Text = "Race !!";
            this.race_button.UseVisualStyleBackColor = false;
            this.race_button.Click += new System.EventHandler(this.race_button_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // exit_race
            // 
            this.exit_race.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.exit_race.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_race.ForeColor = System.Drawing.SystemColors.Control;
            this.exit_race.Location = new System.Drawing.Point(0, 158);
            this.exit_race.Name = "exit_race";
            this.exit_race.Size = new System.Drawing.Size(178, 40);
            this.exit_race.TabIndex = 14;
            this.exit_race.Text = "Exit Racing";
            this.exit_race.UseVisualStyleBackColor = false;
            this.exit_race.Click += new System.EventHandler(this.exit_race_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1060, 657);
            this.Controls.Add(this.race_button);
            this.Controls.Add(this.clear_bet_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rabbit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rabbit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rabbit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rabbit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pic_rabbit1;
        private System.Windows.Forms.PictureBox pic_rabbit2;
        private System.Windows.Forms.PictureBox pic_rabbit3;
        private System.Windows.Forms.PictureBox pic_rabbit4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Bet_box;
        private System.Windows.Forms.RadioButton rabbit_four;
        private System.Windows.Forms.RadioButton rabbit_three;
        private System.Windows.Forms.RadioButton rabbit_two;
        private System.Windows.Forms.RadioButton rabbit_one;
        private System.Windows.Forms.RadioButton ranjit_player;
        private System.Windows.Forms.RadioButton dhawan_player;
        private System.Windows.Forms.RadioButton pujara_player;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clear_bet_button;
        private System.Windows.Forms.Button race_button;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button exit_race;
    }
}