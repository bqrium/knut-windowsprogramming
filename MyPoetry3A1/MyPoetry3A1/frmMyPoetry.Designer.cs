namespace MyPoetry3A1
{
    partial class frmMyPoetry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMyPoetry));
            this.lblPoetry = new System.Windows.Forms.Label();
            this.btnJinDalRae = new System.Windows.Forms.Button();
            this.btnChoHon = new System.Windows.Forms.Button();
            this.btnUmMa = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPoet = new System.Windows.Forms.Label();
            this.btnComeOut = new System.Windows.Forms.Button();
            this.btnBelleyache = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPoetry
            // 
            this.lblPoetry.BackColor = System.Drawing.Color.Transparent;
            this.lblPoetry.Font = new System.Drawing.Font("굴림", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPoetry.ForeColor = System.Drawing.Color.Yellow;
            this.lblPoetry.Location = new System.Drawing.Point(12, 77);
            this.lblPoetry.Name = "lblPoetry";
            this.lblPoetry.Size = new System.Drawing.Size(234, 474);
            this.lblPoetry.TabIndex = 0;
            this.lblPoetry.Text = "내용";
            // 
            // btnJinDalRae
            // 
            this.btnJinDalRae.Location = new System.Drawing.Point(325, 19);
            this.btnJinDalRae.Name = "btnJinDalRae";
            this.btnJinDalRae.Size = new System.Drawing.Size(123, 23);
            this.btnJinDalRae.TabIndex = 1;
            this.btnJinDalRae.Text = "진달래 꽃";
            this.btnJinDalRae.UseVisualStyleBackColor = true;
            this.btnJinDalRae.Click += new System.EventHandler(this.btnJinDalRae_Click_1);
            // 
            // btnChoHon
            // 
            this.btnChoHon.Location = new System.Drawing.Point(325, 48);
            this.btnChoHon.Name = "btnChoHon";
            this.btnChoHon.Size = new System.Drawing.Size(123, 23);
            this.btnChoHon.TabIndex = 2;
            this.btnChoHon.Text = "초혼";
            this.btnChoHon.UseVisualStyleBackColor = true;
            this.btnChoHon.Click += new System.EventHandler(this.btnChoHon_Click_1);
            // 
            // btnUmMa
            // 
            this.btnUmMa.Location = new System.Drawing.Point(325, 77);
            this.btnUmMa.Name = "btnUmMa";
            this.btnUmMa.Size = new System.Drawing.Size(123, 23);
            this.btnUmMa.TabIndex = 3;
            this.btnUmMa.Text = "엄마야 누나야";
            this.btnUmMa.UseVisualStyleBackColor = true;
            this.btnUmMa.Click += new System.EventHandler(this.btnUmMa_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(325, 164);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "종료(&X)";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("굴림", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.ForeColor = System.Drawing.Color.Aqua;
            this.lblTitle.Location = new System.Drawing.Point(112, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(42, 16);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "제목";
            // 
            // lblPoet
            // 
            this.lblPoet.AutoSize = true;
            this.lblPoet.BackColor = System.Drawing.Color.Transparent;
            this.lblPoet.Font = new System.Drawing.Font("굴림", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPoet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPoet.Location = new System.Drawing.Point(204, 48);
            this.lblPoet.Name = "lblPoet";
            this.lblPoet.Size = new System.Drawing.Size(42, 16);
            this.lblPoet.TabIndex = 6;
            this.lblPoet.Text = "시인";
            // 
            // btnComeOut
            // 
            this.btnComeOut.Location = new System.Drawing.Point(325, 106);
            this.btnComeOut.Name = "btnComeOut";
            this.btnComeOut.Size = new System.Drawing.Size(123, 23);
            this.btnComeOut.TabIndex = 7;
            this.btnComeOut.Text = "Come out and play";
            this.btnComeOut.UseVisualStyleBackColor = true;
            this.btnComeOut.Click += new System.EventHandler(this.btnComeOut_Click);
            // 
            // btnBelleyache
            // 
            this.btnBelleyache.Location = new System.Drawing.Point(325, 135);
            this.btnBelleyache.Name = "btnBelleyache";
            this.btnBelleyache.Size = new System.Drawing.Size(123, 23);
            this.btnBelleyache.TabIndex = 8;
            this.btnBelleyache.Text = "Belleyache";
            this.btnBelleyache.UseVisualStyleBackColor = true;
            this.btnBelleyache.Click += new System.EventHandler(this.btnBelleyache_Click);
            // 
            // frmMyPoetry
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(460, 575);
            this.Controls.Add(this.btnBelleyache);
            this.Controls.Add(this.btnComeOut);
            this.Controls.Add(this.lblPoet);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUmMa);
            this.Controls.Add(this.btnChoHon);
            this.Controls.Add(this.btnJinDalRae);
            this.Controls.Add(this.lblPoetry);
            this.Name = "frmMyPoetry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPoetry;
        private System.Windows.Forms.Button btnJinDalRae;
        private System.Windows.Forms.Button btnChoHon;
        private System.Windows.Forms.Button btnUmMa;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPoet;
        private System.Windows.Forms.Button btnComeOut;
        private System.Windows.Forms.Button btnBelleyache;
    }
}

