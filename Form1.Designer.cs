namespace Rock_paper_scissors_game
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Player = new System.Windows.Forms.Label();
            this.WinnerName = new System.Windows.Forms.Label();
            this.Rock = new System.Windows.Forms.Button();
            this.Scissors = new System.Windows.Forms.Button();
            this.Paper = new System.Windows.Forms.Button();
            this.ComputerWinnerCount = new System.Windows.Forms.Label();
            this.PlayerWinnerCount = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.CounterOfRounds = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PlayerName = new System.Windows.Forms.TextBox();
            this.NumberOfRounds = new System.Windows.Forms.NumericUpDown();
            this.Start_Game = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.RestartGame = new System.Windows.Forms.Button();
            this.FinalWinner = new System.Windows.Forms.Label();
            this.DrawTimes = new System.Windows.Forms.Label();
            this.ComputerWonTimes = new System.Windows.Forms.Label();
            this.PlayerWonTimes = new System.Windows.Forms.Label();
            this.GameRounds = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfRounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(250, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rock paper scissors game";
            // 
            // Player
            // 
            this.Player.AutoSize = true;
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Player.Location = new System.Drawing.Point(630, 118);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(82, 28);
            this.Player.TabIndex = 1;
            this.Player.Text = "              ";
            // 
            // WinnerName
            // 
            this.WinnerName.AutoSize = true;
            this.WinnerName.BackColor = System.Drawing.Color.Transparent;
            this.WinnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinnerName.ForeColor = System.Drawing.Color.Lime;
            this.WinnerName.Location = new System.Drawing.Point(329, 231);
            this.WinnerName.Name = "WinnerName";
            this.WinnerName.Size = new System.Drawing.Size(100, 24);
            this.WinnerName.TabIndex = 5;
            this.WinnerName.Text = "                  ";
            // 
            // Rock
            // 
            this.Rock.BackColor = System.Drawing.Color.Teal;
            this.Rock.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Rock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Rock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.Rock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rock.Location = new System.Drawing.Point(348, 356);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(82, 41);
            this.Rock.TabIndex = 8;
            this.Rock.Tag = "Rock";
            this.Rock.Text = "Rock";
            this.Rock.UseVisualStyleBackColor = false;
            this.Rock.Click += new System.EventHandler(this.Button_All);
            // 
            // Scissors
            // 
            this.Scissors.BackColor = System.Drawing.Color.Teal;
            this.Scissors.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Scissors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Scissors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.Scissors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scissors.Location = new System.Drawing.Point(485, 356);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(82, 41);
            this.Scissors.TabIndex = 9;
            this.Scissors.Tag = "Scissors";
            this.Scissors.Text = "Scissors";
            this.Scissors.UseVisualStyleBackColor = false;
            this.Scissors.Click += new System.EventHandler(this.Button_All);
            // 
            // Paper
            // 
            this.Paper.BackColor = System.Drawing.Color.Teal;
            this.Paper.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Paper.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Paper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.Paper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Paper.Location = new System.Drawing.Point(207, 356);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(82, 41);
            this.Paper.TabIndex = 10;
            this.Paper.Tag = "Paper";
            this.Paper.Text = "Paper";
            this.Paper.UseVisualStyleBackColor = false;
            this.Paper.Click += new System.EventHandler(this.Button_All);
            // 
            // ComputerWinnerCount
            // 
            this.ComputerWinnerCount.AutoSize = true;
            this.ComputerWinnerCount.BackColor = System.Drawing.Color.Transparent;
            this.ComputerWinnerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerWinnerCount.ForeColor = System.Drawing.Color.Red;
            this.ComputerWinnerCount.Location = new System.Drawing.Point(67, 285);
            this.ComputerWinnerCount.Name = "ComputerWinnerCount";
            this.ComputerWinnerCount.Size = new System.Drawing.Size(35, 24);
            this.ComputerWinnerCount.TabIndex = 11;
            this.ComputerWinnerCount.Text = "0   ";
            // 
            // PlayerWinnerCount
            // 
            this.PlayerWinnerCount.AutoSize = true;
            this.PlayerWinnerCount.BackColor = System.Drawing.Color.Transparent;
            this.PlayerWinnerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerWinnerCount.ForeColor = System.Drawing.Color.Red;
            this.PlayerWinnerCount.Location = new System.Drawing.Point(691, 285);
            this.PlayerWinnerCount.Name = "PlayerWinnerCount";
            this.PlayerWinnerCount.Size = new System.Drawing.Size(25, 24);
            this.PlayerWinnerCount.TabIndex = 12;
            this.PlayerWinnerCount.Text = "0 ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(16, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Computer Choise";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, -20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 470);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.CounterOfRounds);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.WinnerName);
            this.tabPage1.Controls.Add(this.PlayerWinnerCount);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Paper);
            this.tabPage1.Controls.Add(this.Player);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.ComputerWinnerCount);
            this.tabPage1.Controls.Add(this.Rock);
            this.tabPage1.Controls.Add(this.Scissors);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.OliveDrab;
            this.label8.Location = new System.Drawing.Point(311, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "Round Winner";
            // 
            // CounterOfRounds
            // 
            this.CounterOfRounds.AutoSize = true;
            this.CounterOfRounds.BackColor = System.Drawing.Color.Transparent;
            this.CounterOfRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CounterOfRounds.ForeColor = System.Drawing.Color.Red;
            this.CounterOfRounds.Location = new System.Drawing.Point(722, 68);
            this.CounterOfRounds.Name = "CounterOfRounds";
            this.CounterOfRounds.Size = new System.Drawing.Size(25, 24);
            this.CounterOfRounds.TabIndex = 14;
            this.CounterOfRounds.Text = "0 ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label7.Location = new System.Drawing.Point(567, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "RoundsCounter : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rock_paper_scissors_game.Properties.Resources.questionmark;
            this.pictureBox1.Location = new System.Drawing.Point(32, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Rock_paper_scissors_game.Properties.Resources.questionmark;
            this.pictureBox2.Location = new System.Drawing.Point(655, 169);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.PlayerName);
            this.tabPage2.Controls.Add(this.NumberOfRounds);
            this.tabPage2.Controls.Add(this.Start_Game);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Magenta;
            this.label5.Location = new System.Drawing.Point(349, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 36);
            this.label5.TabIndex = 5;
            this.label5.Text = "Number Of Rounds";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Ivory;
            this.label4.Location = new System.Drawing.Point(228, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 39);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rock paper scissors game";
            // 
            // PlayerName
            // 
            this.PlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerName.Location = new System.Drawing.Point(303, 111);
            this.PlayerName.MaxLength = 7;
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(143, 21);
            this.PlayerName.TabIndex = 3;
            // 
            // NumberOfRounds
            // 
            this.NumberOfRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfRounds.Location = new System.Drawing.Point(538, 216);
            this.NumberOfRounds.Name = "NumberOfRounds";
            this.NumberOfRounds.ReadOnly = true;
            this.NumberOfRounds.Size = new System.Drawing.Size(143, 21);
            this.NumberOfRounds.TabIndex = 2;
            // 
            // Start_Game
            // 
            this.Start_Game.BackColor = System.Drawing.Color.White;
            this.Start_Game.FlatAppearance.BorderSize = 2;
            this.Start_Game.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.Start_Game.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Start_Game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_Game.Location = new System.Drawing.Point(335, 387);
            this.Start_Game.Name = "Start_Game";
            this.Start_Game.Size = new System.Drawing.Size(96, 40);
            this.Start_Game.TabIndex = 1;
            this.Start_Game.Text = "Start Game";
            this.Start_Game.UseVisualStyleBackColor = false;
            this.Start_Game.Click += new System.EventHandler(this.Start_Game_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Magenta;
            this.label2.Location = new System.Drawing.Point(161, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Player Name";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Rock_paper_scissors_game.Properties.Resources.paperRockScissors;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(793, 444);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.Controls.Add(this.RestartGame);
            this.tabPage3.Controls.Add(this.FinalWinner);
            this.tabPage3.Controls.Add(this.DrawTimes);
            this.tabPage3.Controls.Add(this.ComputerWonTimes);
            this.tabPage3.Controls.Add(this.PlayerWonTimes);
            this.tabPage3.Controls.Add(this.GameRounds);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(793, 444);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // RestartGame
            // 
            this.RestartGame.BackColor = System.Drawing.Color.White;
            this.RestartGame.FlatAppearance.BorderSize = 2;
            this.RestartGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.RestartGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.RestartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartGame.Location = new System.Drawing.Point(358, 382);
            this.RestartGame.Name = "RestartGame";
            this.RestartGame.Size = new System.Drawing.Size(96, 40);
            this.RestartGame.TabIndex = 6;
            this.RestartGame.Text = "Restart Game";
            this.RestartGame.UseVisualStyleBackColor = false;
            this.RestartGame.Click += new System.EventHandler(this.RestartGame_Click);
            // 
            // FinalWinner
            // 
            this.FinalWinner.AutoSize = true;
            this.FinalWinner.BackColor = System.Drawing.Color.Transparent;
            this.FinalWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalWinner.ForeColor = System.Drawing.Color.Lime;
            this.FinalWinner.Location = new System.Drawing.Point(188, 327);
            this.FinalWinner.Name = "FinalWinner";
            this.FinalWinner.Size = new System.Drawing.Size(147, 24);
            this.FinalWinner.TabIndex = 5;
            this.FinalWinner.Text = "Final Winner :    ";
            // 
            // DrawTimes
            // 
            this.DrawTimes.AutoSize = true;
            this.DrawTimes.BackColor = System.Drawing.Color.Transparent;
            this.DrawTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawTimes.ForeColor = System.Drawing.Color.Lime;
            this.DrawTimes.Location = new System.Drawing.Point(188, 289);
            this.DrawTimes.Name = "DrawTimes";
            this.DrawTimes.Size = new System.Drawing.Size(135, 24);
            this.DrawTimes.TabIndex = 4;
            this.DrawTimes.Text = "Draw Times :   ";
            // 
            // ComputerWonTimes
            // 
            this.ComputerWonTimes.AutoSize = true;
            this.ComputerWonTimes.BackColor = System.Drawing.Color.Transparent;
            this.ComputerWonTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerWonTimes.ForeColor = System.Drawing.Color.Lime;
            this.ComputerWonTimes.Location = new System.Drawing.Point(188, 244);
            this.ComputerWonTimes.Name = "ComputerWonTimes";
            this.ComputerWonTimes.Size = new System.Drawing.Size(220, 24);
            this.ComputerWonTimes.TabIndex = 3;
            this.ComputerWonTimes.Text = "Computer Won Times :   ";
            // 
            // PlayerWonTimes
            // 
            this.PlayerWonTimes.AutoSize = true;
            this.PlayerWonTimes.BackColor = System.Drawing.Color.Transparent;
            this.PlayerWonTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerWonTimes.ForeColor = System.Drawing.Color.Lime;
            this.PlayerWonTimes.Location = new System.Drawing.Point(188, 198);
            this.PlayerWonTimes.Name = "PlayerWonTimes";
            this.PlayerWonTimes.Size = new System.Drawing.Size(189, 24);
            this.PlayerWonTimes.TabIndex = 2;
            this.PlayerWonTimes.Text = "Player Won Times :   ";
            // 
            // GameRounds
            // 
            this.GameRounds.AutoSize = true;
            this.GameRounds.BackColor = System.Drawing.Color.Transparent;
            this.GameRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameRounds.ForeColor = System.Drawing.Color.Lime;
            this.GameRounds.Location = new System.Drawing.Point(188, 161);
            this.GameRounds.Name = "GameRounds";
            this.GameRounds.Size = new System.Drawing.Size(157, 24);
            this.GameRounds.TabIndex = 1;
            this.GameRounds.Text = "Game Rounds :   ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MingLiU-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(308, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Game Over";
            // 
            // Form1
            // 
            this.AcceptButton = this.Start_Game;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfRounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Player;
        private System.Windows.Forms.Label WinnerName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Rock;
        private System.Windows.Forms.Button Scissors;
        private System.Windows.Forms.Button Paper;
        private System.Windows.Forms.Label ComputerWinnerCount;
        private System.Windows.Forms.Label PlayerWinnerCount;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox PlayerName;
        private System.Windows.Forms.NumericUpDown NumberOfRounds;
        private System.Windows.Forms.Button Start_Game;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label GameRounds;
        private System.Windows.Forms.Label PlayerWonTimes;
        private System.Windows.Forms.Label FinalWinner;
        private System.Windows.Forms.Label DrawTimes;
        private System.Windows.Forms.Label ComputerWonTimes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CounterOfRounds;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button RestartGame;
        private System.Windows.Forms.Label label8;
    }
}

