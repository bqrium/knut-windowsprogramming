using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 인사하기1
{
    public partial class frmInSa : Form
    {
        public frmInSa()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInsa_Click(object sender, EventArgs e)
        {
            int intHour = DateTime.Now.Hour;
            int intMinute = DateTime.Now.Minute;
            int intSecond = DateTime.Now.Second;
            string strHourMessage = lblName.Text + "님!!"+ Environment.NewLine;
            strHourMessage += "안녕하세요~~" + Environment.NewLine;
            if (intHour<6)
            {
                strHourMessage += "일어나세요~~~"+Environment.NewLine;
                strHourMessage += "지금은"+ intHour+"시"+intMinute+"분"+intSecond+"초";
            } else if(intHour <8)
            {
                strHourMessage += "학교가세요~~~" + Environment.NewLine;
                strHourMessage += "지금은" + intHour + "시" + intMinute + "분" + intSecond + "초";
            }
            else if (intHour < 12)
            {
                strHourMessage += "밥먹으세요~~~" + Environment.NewLine;
                strHourMessage += "지금은" + intHour + "시" + intMinute + "분" + intSecond + "초";
            }
            else if (intHour < 18)
            {
                strHourMessage += "집에가세요~~~" + Environment.NewLine;
                strHourMessage += "지금은" + intHour + "시" + intMinute + "분" + intSecond + "초";
            }
            else if (intHour < 20)
            {
                strHourMessage += "꿀잠자세요~~~" + Environment.NewLine;
                strHourMessage += "지금은" + intHour + "시" + intMinute + "분" + intSecond + "초";
            }
            else
            {
                strHourMessage += "꿀잠자세요~~~" + Environment.NewLine;
                strHourMessage += "지금은" + intHour + "시" + intMinute + "분" + intSecond + "초";
            }
            lblMessage.Text = strHourMessage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblHour.Text = DateTime.Now.Hour+":";
            lblMinute.Text = DateTime.Now.Minute + ":";
            lblSecond.Text = DateTime.Now.Second + ":";
          
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void lblSecond_Click(object sender, EventArgs e)
        {

        }
    }
}
