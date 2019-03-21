namespace RockPaperScissors
{
    partial class RockPaperScissors
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpUser = new System.Windows.Forms.GroupBox();
            this.txtUserScore = new System.Windows.Forms.TextBox();
            this.txtUserPlayResult = new System.Windows.Forms.TextBox();
            this.lblUserScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpComputer = new System.Windows.Forms.GroupBox();
            this.txtComputerScore = new System.Windows.Forms.TextBox();
            this.txtComputerPlayResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblComputerPlayResult = new System.Windows.Forms.Label();
            this.grpMessage = new System.Windows.Forms.GroupBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.grpBatting = new System.Windows.Forms.GroupBox();
            this.hsBatting = new System.Windows.Forms.HScrollBar();
            this.txtBatting = new System.Windows.Forms.TextBox();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpUser.SuspendLayout();
            this.grpComputer.SuspendLayout();
            this.grpMessage.SuspendLayout();
            this.grpBatting.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUser
            // 
            this.grpUser.Controls.Add(this.txtUserScore);
            this.grpUser.Controls.Add(this.txtUserPlayResult);
            this.grpUser.Controls.Add(this.lblUserScore);
            this.grpUser.Controls.Add(this.label1);
            this.grpUser.Location = new System.Drawing.Point(21, 29);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(200, 187);
            this.grpUser.TabIndex = 0;
            this.grpUser.TabStop = false;
            this.grpUser.Text = "사용자";
            // 
            // txtUserScore
            // 
            this.txtUserScore.Enabled = false;
            this.txtUserScore.Location = new System.Drawing.Point(49, 45);
            this.txtUserScore.Name = "txtUserScore";
            this.txtUserScore.Size = new System.Drawing.Size(100, 21);
            this.txtUserScore.TabIndex = 5;
            this.txtUserScore.Text = "500";
            this.txtUserScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUserPlayResult
            // 
            this.txtUserPlayResult.Enabled = false;
            this.txtUserPlayResult.Location = new System.Drawing.Point(49, 18);
            this.txtUserPlayResult.Name = "txtUserPlayResult";
            this.txtUserPlayResult.Size = new System.Drawing.Size(100, 21);
            this.txtUserPlayResult.TabIndex = 4;
            this.txtUserPlayResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUserScore
            // 
            this.lblUserScore.AutoSize = true;
            this.lblUserScore.Location = new System.Drawing.Point(7, 44);
            this.lblUserScore.Name = "lblUserScore";
            this.lblUserScore.Size = new System.Drawing.Size(29, 12);
            this.lblUserScore.TabIndex = 2;
            this.lblUserScore.Text = "점수";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "낸 거";
            // 
            // grpComputer
            // 
            this.grpComputer.Controls.Add(this.txtComputerScore);
            this.grpComputer.Controls.Add(this.txtComputerPlayResult);
            this.grpComputer.Controls.Add(this.label3);
            this.grpComputer.Controls.Add(this.lblComputerPlayResult);
            this.grpComputer.Location = new System.Drawing.Point(227, 29);
            this.grpComputer.Name = "grpComputer";
            this.grpComputer.Size = new System.Drawing.Size(200, 187);
            this.grpComputer.TabIndex = 4;
            this.grpComputer.TabStop = false;
            this.grpComputer.Text = "사용자";
            // 
            // txtComputerScore
            // 
            this.txtComputerScore.Enabled = false;
            this.txtComputerScore.Location = new System.Drawing.Point(49, 44);
            this.txtComputerScore.Name = "txtComputerScore";
            this.txtComputerScore.Size = new System.Drawing.Size(100, 21);
            this.txtComputerScore.TabIndex = 7;
            this.txtComputerScore.Text = "500";
            this.txtComputerScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtComputerPlayResult
            // 
            this.txtComputerPlayResult.Enabled = false;
            this.txtComputerPlayResult.Location = new System.Drawing.Point(49, 18);
            this.txtComputerPlayResult.Name = "txtComputerPlayResult";
            this.txtComputerPlayResult.Size = new System.Drawing.Size(100, 21);
            this.txtComputerPlayResult.TabIndex = 6;
            this.txtComputerPlayResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "점수";
            // 
            // lblComputerPlayResult
            // 
            this.lblComputerPlayResult.AutoSize = true;
            this.lblComputerPlayResult.Location = new System.Drawing.Point(7, 21);
            this.lblComputerPlayResult.Name = "lblComputerPlayResult";
            this.lblComputerPlayResult.Size = new System.Drawing.Size(33, 12);
            this.lblComputerPlayResult.TabIndex = 0;
            this.lblComputerPlayResult.Text = "낸 거";
            // 
            // grpMessage
            // 
            this.grpMessage.Controls.Add(this.lblMessage);
            this.grpMessage.Location = new System.Drawing.Point(12, 222);
            this.grpMessage.Name = "grpMessage";
            this.grpMessage.Size = new System.Drawing.Size(415, 131);
            this.grpMessage.TabIndex = 4;
            this.grpMessage.TabStop = false;
            this.grpMessage.Text = "게임 결과";
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Location = new System.Drawing.Point(7, 21);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(392, 92);
            this.lblMessage.TabIndex = 0;
            // 
            // grpBatting
            // 
            this.grpBatting.Controls.Add(this.hsBatting);
            this.grpBatting.Controls.Add(this.txtBatting);
            this.grpBatting.Location = new System.Drawing.Point(12, 359);
            this.grpBatting.Name = "grpBatting";
            this.grpBatting.Size = new System.Drawing.Size(415, 125);
            this.grpBatting.TabIndex = 5;
            this.grpBatting.TabStop = false;
            this.grpBatting.Text = "돈을 거세요!!";
            // 
            // hsBatting
            // 
            this.hsBatting.Location = new System.Drawing.Point(151, 79);
            this.hsBatting.Name = "hsBatting";
            this.hsBatting.Size = new System.Drawing.Size(100, 17);
            this.hsBatting.TabIndex = 1;
            this.hsBatting.Value = 50;
            this.hsBatting.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsBatting_Scroll);
            // 
            // txtBatting
            // 
            this.txtBatting.Enabled = false;
            this.txtBatting.Location = new System.Drawing.Point(151, 51);
            this.txtBatting.Name = "txtBatting";
            this.txtBatting.Size = new System.Drawing.Size(100, 21);
            this.txtBatting.TabIndex = 0;
            // 
            // btnScissors
            // 
            this.btnScissors.Location = new System.Drawing.Point(433, 39);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(75, 23);
            this.btnScissors.TabIndex = 6;
            this.btnScissors.Text = "가위";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(433, 68);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(75, 23);
            this.btnRock.TabIndex = 7;
            this.btnRock.Text = "바위";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(433, 97);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(75, 23);
            this.btnPaper.TabIndex = 8;
            this.btnPaper.Text = "보";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(433, 239);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "종료";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // RockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 548);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.grpBatting);
            this.Controls.Add(this.grpMessage);
            this.Controls.Add(this.grpComputer);
            this.Controls.Add(this.grpUser);
            this.Name = "RockPaperScissors";
            this.Text = "가위바위보를 합시다.";
            this.grpUser.ResumeLayout(false);
            this.grpUser.PerformLayout();
            this.grpComputer.ResumeLayout(false);
            this.grpComputer.PerformLayout();
            this.grpMessage.ResumeLayout(false);
            this.grpBatting.ResumeLayout(false);
            this.grpBatting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUser;
        private System.Windows.Forms.TextBox txtComputerPlayResult;
        private System.Windows.Forms.TextBox txtUserScore;
        private System.Windows.Forms.TextBox txtUserPlayResult;
        private System.Windows.Forms.Label lblUserScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpComputer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblComputerPlayResult;
        private System.Windows.Forms.GroupBox grpMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.GroupBox grpBatting;
        private System.Windows.Forms.HScrollBar hsBatting;
        private System.Windows.Forms.TextBox txtBatting;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtComputerScore;
    }
}

