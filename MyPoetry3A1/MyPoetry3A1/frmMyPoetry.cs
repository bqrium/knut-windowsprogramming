using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPoetry3A1
{
    public partial class frmMyPoetry : Form
    {
        public frmMyPoetry()
        {
            InitializeComponent();
        }

        private void btnJinDalRae_Click_1(object sender, EventArgs e)
        {
            lblPoetry.Top = this.Bottom;
            lblPoetry.Height = 0;
            this.BackgroundImage = Image.FromFile(@"C:\\Users\\Com315\\Desktop\\진달래꽃.jpg");
            lblTitle.Text = "진달래 꽃";
            lblPoet.Text = "김소월";
            lblPoetry.Text = "나보기가 역겨워 가실 때에는 "
               + Environment.NewLine
               + "말 없이 고이 보내 드리우리라"
               + Environment.NewLine
               + "나보기가 역겨워 가실 때에는 "
               + Environment.NewLine
               + "나보기가 역겨워 가실 때에는 "
               + Environment.NewLine
               + "말 없이 고이 보내 드리우리라"
               + Environment.NewLine
               + "나보기가 역겨워 가실 때에는 "
               + Environment.NewLine
               + "말 없이 고이 보내 드리우리라"
               + Environment.NewLine;
            Button_hide();
            tmrUp.Start();
        }

        private void btnChoHon_Click_1(object sender, EventArgs e)
        {
            lblPoetry.Top = this.Bottom;
            lblPoetry.Height = 0;
            this.BackgroundImage = Image.FromFile(@"C:\\Users\\Com315\\Desktop\\초혼.jpg");
            lblTitle.Text = "초혼";
            lblPoet.Text = "김소월";
            lblPoetry.Text = "산산히 부서진 이름이여"
                + Environment.NewLine
                + "부르다가 내가 죽을 이름이여"
                + Environment.NewLine
                + "산산히 부서진 이름이여"
                + Environment.NewLine
                + "부르다가 내가 죽을 이름이여";
            Button_hide();
            tmrUp.Start();
        }

        private void btnUmMa_Click(object sender, EventArgs e)
        {
            lblPoetry.Top = this.Bottom;
            lblPoetry.Height = 0;
            this.BackgroundImage = Image.FromFile(@"C:\\Users\\Com315\\Desktop\\엄마야누나야.jpg");
            lblTitle.Text = "진달래 꽃";
            lblPoet.Text = "김소월";
            lblPoetry.Text = "엄마야 누나야 강변살자"
                + Environment.NewLine
                + "엄마야 누나야 강변살자"
                + Environment.NewLine
                + "엄마야 누나야 강변살자"
                + Environment.NewLine
                + "엄마야 누나야 강변살자";
            Button_hide();
            tmrUp.Start();
        }

        private void btnComeOut_Click(object sender, EventArgs e)
        {
            lblPoetry.Top = this.Bottom;
            lblPoetry.Height = 0;
            this.BackgroundImage = Image.FromFile(@"C:\\Users\\Com315\\Desktop\\컴아웃앤플레이.jpg");
            lblTitle.Text = "Come out and Play";
            lblPoet.Text = "빌리 아일리시";
            lblPoetry.Text = "Wake up and smell the coffee"
                + Environment.NewLine
                + "Wake up and smell the coffee"
                + Environment.NewLine
                + "Wake up and smell the coffee";
            Button_hide();
            tmrUp.Start();
        }

        private void btnBellyache_Click(object sender, EventArgs e)
        {
            lblPoetry.Top = this.Bottom;
            lblPoetry.Height = 0;
            this.BackgroundImage = Image.FromFile(@"C:\\Users\\Com315\\Desktop\\bellyache.png");
            lblTitle.Text = "Bellyache";
            lblPoet.Text = "빌리 아일리시";
            lblPoetry.Text = "Where's my mind"
                + Environment.NewLine
                + "Where's my mind"
                + Environment.NewLine
                + "Where's my mind";
            Button_hide();
            tmrUp.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tmrUp_Tick(object sender, EventArgs e)
        {
            if (lblPoetry.Top > btnChoHon.Bottom)
            {
                lblPoetry.Top -= 10;
                lblPoetry.Height += 10;
            }
            else
            {
                btnReturn.Show();
                tmrUp.Stop();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            btnJinDalRae.Show();
            btnChoHon.Show();
            btnUmMa.Show();
            btnExit.Show();
            btnComeOut.Show();
            btnBellyache.Show();
            btnReturn.Hide();
        }

        private void Button_hide()
        {
            btnJinDalRae.Hide();
            btnChoHon.Hide();
            btnUmMa.Hide();
            btnComeOut.Hide();
            btnBellyache.Hide();
        }
    }
}
