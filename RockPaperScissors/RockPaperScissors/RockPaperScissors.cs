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
            txtUserPlayResult.Text = "가위";
            Random rnd = new Random();
            int computer = rnd.Next(3)+1;
            switch(computer)
            {
                case 1:
                    txtComputerPlayResult.Text = "가위";
                    lblMessage.Text = "우리 비겼네요~~~";
                    break;
                case 2:
                    txtComputerPlayResult.Text = "바위";
                    lblMessage.Text = "내가 이겼어 당신은 졌네요~~~";
                    break;
                case 3:
                    txtComputerPlayResult.Text = "가위";
                    lblMessage.Text = "감히 나를 이기다니...";
                    break;
            }
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            txtUserPlayResult.Text = "바위";
            Random rnd = new Random();
            int computer = rnd.Next(3) + 1;
            switch (computer)
            {
                case 1:
                    txtComputerPlayResult.Text = "바위";
                    lblMessage.Text = "우리 비겼네요~~~";
                    break;
                case 2:
                    txtComputerPlayResult.Text = "가위";
                    lblMessage.Text = "내가 이겼어 당신은 졌네요~~~";
                    break;
                case 3:
                    txtComputerPlayResult.Text = "보";
                    lblMessage.Text = "감히 나를 이기다니...";
                    break;
            }
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            txtUserPlayResult.Text = "보";
            Random rnd = new Random();
            int computer = rnd.Next(3) + 1;
            switch (computer)
            {
                case 1:
                    txtComputerPlayResult.Text = "보";
                    lblMessage.Text = "우리 비겼네요~~~";
                    break;
                case 2:
                    txtComputerPlayResult.Text = "바위";
                    lblMessage.Text = "내가 이겼어 당신은 졌네요~~~";
                    break;
                case 3:
                    txtComputerPlayResult.Text = "가위";
                    lblMessage.Text = "감히 나를 이기다니...ㅈ";
                    break;
            }
        }
    }
}
