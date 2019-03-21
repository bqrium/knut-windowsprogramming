using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class RockPaperScissors : Form
    {
        enum RPS { 가위 = 1, 바위, 보 };
        enum GameResult { Win, Lose, Tie };
        enum Gamer { 당신, 나}
        private Gamer Winner, Loser;
        private RPS user, computer;
        private GameResult PlayResult;
        private int UserScore, ComputerScore;
        private Random rnd = new Random();

        public RockPaperScissors()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            if (!isBattingOver())
            {
                user = RPS.가위;
                computer = (RPS)(rnd.Next(3) + 1);
                switch (computer)
                {
                    case RPS.가위:
                        PlayResult = GameResult.Tie;
                        break;
                    case RPS.바위:
                        PlayResult = GameResult.Win;
                        break;
                    case RPS.보:
                        PlayResult = GameResult.Lose;
                        break;
                }
                WriteMessage();
            }
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            if (!isBattingOver())
            {
                user = RPS.바위;
                computer = (RPS)(rnd.Next(3) + 1);
                switch (computer)
                {
                    case RPS.가위:
                        PlayResult = GameResult.Lose;
                        break;
                    case RPS.바위:
                        PlayResult = GameResult.Tie;
                        break;
                    case RPS.보:
                        PlayResult = GameResult.Win;
                        break;
                }
                WriteMessage();
            }
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            if (!isBattingOver())
            {
                user = RPS.보;
                computer = (RPS)(rnd.Next(3) + 1);
                switch (computer)
                {
                    case RPS.가위:
                        PlayResult = GameResult.Win;
                        break;
                    case RPS.바위:
                        PlayResult = GameResult.Lose;
                        break;
                    case RPS.보:
                        PlayResult = GameResult.Tie;
                        break;
                }
                WriteMessage();
            }
        }

        private void hsBatting_Scroll(object sender, ScrollEventArgs e)
        {
            txtBatting.Text = hsBatting.Value.ToString();
        }

        private void WriteMessage()
        {
            txtUserPlayResult.Text = user.ToString();
            txtComputerPlayResult.Text = computer.ToString();
            switch (PlayResult)
            {
                case GameResult.Tie:
                    lblMessage.Text = "우리 비겼네요~~~\n"
                        + "나를 이기기 위해 분발하세요~~\n"
                        + "사실 난 주먹을 잘 낸답니다..\n"
                        + "잘 생각해서 내세요";
                    break;

                case GameResult.Win:
                    lblMessage.Text = "내가 이겼어 당신은 졌네요~~~\n"
                        + "내가 이겼어 당신은 졌네요~~~\n"
                        + "내가 이겼어 당신은 졌네요~~~\n"
                        + "내가 이겼어 당신은 졌네요~~~";
                    UserScore = int.Parse(txtUserScore.Text) - int.Parse(txtBatting.Text);
                    ComputerScore = int.Parse(txtComputerScore.Text) + int.Parse(txtBatting.Text);
                    break;
                case GameResult.Lose:
                    lblMessage.Text = "감히 나를 이기다니...\n"
                        + "나를 이기다니 개졸립네 ㄹㅇ\n"
                        + "나를 이기다니 개졸립네 ㄹㅇ\n"
                        + "나를 이기다니 개졸립네 ㄹㅇ";
                    UserScore = int.Parse(txtUserScore.Text) + int.Parse(txtBatting.Text);
                    ComputerScore = int.Parse(txtComputerScore.Text) - int.Parse(txtBatting.Text);
                    break;
            }
            if (ComputerScore <= 0)
            {
                Winner = Gamer.당신;
                Loser = Gamer.나;
                WriteGameOut();
            }
            else if(UserScore <= 0)
            {
                Winner = Gamer.나;
                Loser = Gamer.당신;
                WriteGameOut();
            }
            else
            {
                txtUserScore.Text = UserScore.ToString();
                txtComputerScore.Text = ComputerScore.ToString();
            }
        }

        private void WriteGameOut()
        {
            string strMessage = Loser.ToString() +"은" + Winner.ToString()+"에게 졌습니다.";
            DialogResult dlgResult = MessageBox.Show("게임을 종료할까요?", "게임종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.Yes)
            {
                btnExit.PerformClick();
            }
            else
            {
                ResetData();
            }
        }

        private void ResetData()
        {
            txtUserPlayResult.Text = "";
            txtComputerPlayResult.Text = "";
            txtUserScore.Text = "500";
            txtComputerScore.Text = "500";
            lblMessage.Text = "";            
            txtBatting.Text = "";
            hsBatting.Value = 500;
        }

        private Boolean isBattingOver()
        {
            if (int.Parse(txtUserScore.Text) < int.Parse(txtBatting.Text))
            {
                if (MessageBox.Show("당신의 점수가 배팅액보다 작습니다. 남은 돈을 다 걸까요?", "배팅액 부족", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtBatting.Text = txtUserScore.Text;
                }
                return true;
            }
            else if (int.Parse(txtComputerScore.Text) < int.Parse(txtBatting.Text))
            {
                if (MessageBox.Show("내 돈 보다 많이 걸었어 내 돈 남은 거 다 걸까요?", "배팅액 부족", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtBatting.Text = txtComputerScore.Text;
                    
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
