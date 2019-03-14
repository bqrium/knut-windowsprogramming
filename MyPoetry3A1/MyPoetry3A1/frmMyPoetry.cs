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
        }

        private void btnChoHon_Click_1(object sender, EventArgs e)
        {
            lblTitle.Text = "초혼";
            lblPoet.Text = "김소월";
            lblPoetry.Text = "산산히 부서진 이름이여"
                + Environment.NewLine
                + "부르다가 내가 죽을 이름이여"
                + Environment.NewLine
                + "산산히 부서진 이름이여"
                + Environment.NewLine
                + "부르다가 내가 죽을 이름이여";
        }

        private void btnUmMa_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "진달래 꽃";
            lblPoet.Text = "김소월";
            lblPoetry.Text = "엄마야 누나야 강변살자"
                + Environment.NewLine
                + "엄마야 누나야 강변살자"
                + Environment.NewLine
                + "엄마야 누나야 강변살자"
                + Environment.NewLine
                + "엄마야 누나야 강변살자";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnComeOut_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Come out and Play";
            lblPoet.Text = "빌리 아일리시";
            lblPoetry.Text = "Wake up and smell the coffee"
                + Environment.NewLine
                + "Wake up and smell the coffee"
                + Environment.NewLine
                + "Wake up and smell the coffee";
        }

        private void btnBelleyache_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Belleyache";
            lblPoet.Text = "빌리 아일리시";
            lblPoetry.Text = "Where's my mind"
                + Environment.NewLine
                + "Where's my mind"
                + Environment.NewLine
                + "Where's my mind";
        }
    }
}
