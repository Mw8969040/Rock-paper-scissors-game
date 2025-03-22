using Rock_paper_scissors_game.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rock_paper_scissors_game
{
    public partial class Form1 : Form
    {
        private string computerChoice;
        private string playerChoice;
        private int playerCount = 0;
        private int computerCount = 0;
        private int DrawCounter = 0;
        private Random rand = new Random();
        private int timerSeconds = 3;
        private int RoundCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void CheckWinner()
        {
            if (computerChoice == playerChoice)
            {
                WinnerName.Text = "Draw";
                DrawCounter++;
                WinnerName.ForeColor = Color.Yellow;
                return;
            }

            bool playerWins = (computerChoice == "Paper" && playerChoice == "Rock") ||
                              (computerChoice == "Rock" && playerChoice == "Scissors") ||
                              (computerChoice == "Scissors" && playerChoice == "Paper");

            if (playerWins)
            {
                computerCount++;
                WinnerName.Text = "Computer";
                WinnerName.ForeColor = Color.Red;
            }
            else
            {
                playerCount++;
                WinnerName.Text = PlayerName.Text;
                WinnerName.ForeColor = Color.Lime;
            }

            ComputerWinnerCount.Text = computerCount.ToString();
            PlayerWinnerCount.Text = playerCount.ToString();
        }

        private void EndGame()
        {
            if(RoundCounter==NumberOfRounds.Value)
            {
               MessageBox.Show("Number of rounded has ended", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timer1.Enabled = false;
                Rock.Enabled = Paper.Enabled = Scissors.Enabled = false;
                tabControl1.SelectedTab = tabPage3;

                GameRounds.Text = "Game Rounds  :  " +NumberOfRounds.Value.ToString() + " Rounds .";
                PlayerWonTimes.Text ="Player Won Times  :  " +playerCount.ToString() + " Times .";
                ComputerWonTimes.Text= "Computer Won Times  :  " + computerCount.ToString() + " Times .";
                DrawTimes.Text = "Draw Times  :  " + DrawCounter.ToString() + " Times .";
                FinalWinner.Text = playerCount == computerCount
                  ? "Final Winner  :  It's a tie!"
                  : playerCount > computerCount
                     ? "Final Winner  :  " + PlayerName.Text
                    : "Final Winner  :  Computer.";

            }
        }

        private void ExecutePlayerChoice(Button button)
        {
            playerChoice = button.Tag.ToString();
            pictureBox2.Image = GetImageForChoice(playerChoice);
            timerSeconds = 3; // Reset timer for next round
            timer1.Enabled = true;
            EndGame();
        }

        private void ExecuteComputerChoice()
        {
            string[] choices = { "Rock", "Paper", "Scissors" };
            computerChoice = choices[rand.Next(choices.Length)];
            pictureBox1.Image = GetImageForChoice(computerChoice);
            CheckWinner();
            RoundCounter++;
            CounterOfRounds.Text = RoundCounter.ToString();
            EndGame();
        }

        private Image GetImageForChoice(string choice)
        {
            switch (choice)
            {
                case "Rock":
                    return Resources.Rock;
                case "Paper":
                    return Resources.Paper;
                case "Scissors":
                    return Resources.Scissors;
                default:
                    throw new ArgumentException("Invalid choice");
            }
        }

        private void ChoiceOfComputer()
        {
            ExecuteComputerChoice();
        }

        private void Button_All(object sender, EventArgs e)
        {
            ExecutePlayerChoice((Button)sender);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerSeconds--;
            if (timerSeconds <= 0)
            {
                timer1.Enabled = false;
                ChoiceOfComputer();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void Start_Game_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(PlayerName.Text) || NumberOfRounds.Value==0)
            {
                MessageBox.Show("please enter Player Name , Number of rounds", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tabControl1.SelectedTab = tabPage1;
            Player.Text = PlayerName.Text + " Choise";
        }

        private void RestartGame_Click(object sender, EventArgs e)
        {
            Rock.Enabled = Paper.Enabled = Scissors.Enabled = true;
            PlayerName.Clear();
            NumberOfRounds.Value = 0;
            PlayerName.Focus();
            playerCount = 0;
            computerCount = 0;
            DrawCounter = 0;
            RoundCounter = 0;
            pictureBox1.Image = pictureBox2.Image = Resources.questionmark;
            PlayerWinnerCount.Text = ComputerWinnerCount.Text = CounterOfRounds.Text= "0";
            WinnerName.Text = "   ";
            tabControl1.SelectedTab = tabPage2;
        }
    }
}