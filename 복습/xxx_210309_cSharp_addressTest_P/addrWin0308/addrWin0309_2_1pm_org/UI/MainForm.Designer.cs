
namespace addrWin0302
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.addrAdd = new CxFlatUI.CxFlatRoundButton();
            this.addrView = new CxFlatUI.CxFlatRoundButton();
            this.addrAddRand = new CxFlatUI.CxFlatRoundButton();
            this.addrUpdate = new CxFlatUI.CxFlatRoundButton();
            this.addrDelAll = new CxFlatUI.CxFlatRoundButton();
            this.addrDel = new CxFlatUI.CxFlatRoundButton();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            this.addrHelp = new Sunny.UI.UISymbolButton();
            this.addrExit = new Sunny.UI.UISymbolButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addrAdd
            // 
            this.addrAdd.BackColor = System.Drawing.Color.White;
            this.addrAdd.ButtonType = CxFlatUI.ButtonType.Waring;
            this.addrAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.addrAdd.Location = new System.Drawing.Point(474, 153);
            this.addrAdd.Margin = new System.Windows.Forms.Padding(40, 8, 40, 8);
            this.addrAdd.Name = "addrAdd";
            this.addrAdd.Size = new System.Drawing.Size(200, 44);
            this.addrAdd.TabIndex = 4;
            this.addrAdd.Text = "주소록 추가";
            this.addrAdd.TextColor = System.Drawing.Color.White;
            this.addrAdd.Click += new System.EventHandler(this.addrAdd_Click);
            // 
            // addrView
            // 
            this.addrView.BackColor = System.Drawing.Color.White;
            this.addrView.ButtonType = CxFlatUI.ButtonType.Waring;
            this.addrView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.addrView.Location = new System.Drawing.Point(474, 213);
            this.addrView.Margin = new System.Windows.Forms.Padding(40, 8, 40, 8);
            this.addrView.Name = "addrView";
            this.addrView.Size = new System.Drawing.Size(200, 44);
            this.addrView.TabIndex = 5;
            this.addrView.Text = "주소록 보기";
            this.addrView.TextColor = System.Drawing.Color.White;
            this.addrView.Click += new System.EventHandler(this.addrView_Click);
            // 
            // addrAddRand
            // 
            this.addrAddRand.BackColor = System.Drawing.Color.White;
            this.addrAddRand.ButtonType = CxFlatUI.ButtonType.Waring;
            this.addrAddRand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.addrAddRand.Location = new System.Drawing.Point(474, 273);
            this.addrAddRand.Margin = new System.Windows.Forms.Padding(40, 8, 40, 8);
            this.addrAddRand.Name = "addrAddRand";
            this.addrAddRand.Size = new System.Drawing.Size(200, 44);
            this.addrAddRand.TabIndex = 6;
            this.addrAddRand.Text = "랜덤 데이터 추가";
            this.addrAddRand.TextColor = System.Drawing.Color.White;
            this.addrAddRand.Click += new System.EventHandler(this.addrAddRand_Click);
            // 
            // addrUpdate
            // 
            this.addrUpdate.BackColor = System.Drawing.Color.White;
            this.addrUpdate.ButtonType = CxFlatUI.ButtonType.Waring;
            this.addrUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.addrUpdate.Location = new System.Drawing.Point(474, 453);
            this.addrUpdate.Margin = new System.Windows.Forms.Padding(40, 8, 40, 8);
            this.addrUpdate.Name = "addrUpdate";
            this.addrUpdate.Size = new System.Drawing.Size(200, 44);
            this.addrUpdate.TabIndex = 9;
            this.addrUpdate.Text = "주소록 수정";
            this.addrUpdate.TextColor = System.Drawing.Color.White;
            this.addrUpdate.Click += new System.EventHandler(this.addrUpdate_Click);
            // 
            // addrDelAll
            // 
            this.addrDelAll.BackColor = System.Drawing.Color.White;
            this.addrDelAll.ButtonType = CxFlatUI.ButtonType.Waring;
            this.addrDelAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.addrDelAll.Location = new System.Drawing.Point(474, 393);
            this.addrDelAll.Margin = new System.Windows.Forms.Padding(40, 8, 40, 8);
            this.addrDelAll.Name = "addrDelAll";
            this.addrDelAll.Size = new System.Drawing.Size(200, 44);
            this.addrDelAll.TabIndex = 8;
            this.addrDelAll.Text = "주소록 전체 삭제";
            this.addrDelAll.TextColor = System.Drawing.Color.White;
            this.addrDelAll.Click += new System.EventHandler(this.addrDelAll_Click);
            // 
            // addrDel
            // 
            this.addrDel.BackColor = System.Drawing.Color.White;
            this.addrDel.ButtonType = CxFlatUI.ButtonType.Waring;
            this.addrDel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.addrDel.Location = new System.Drawing.Point(474, 333);
            this.addrDel.Margin = new System.Windows.Forms.Padding(40, 8, 40, 8);
            this.addrDel.Name = "addrDel";
            this.addrDel.Size = new System.Drawing.Size(200, 44);
            this.addrDel.TabIndex = 7;
            this.addrDel.Text = "주소록 삭제";
            this.addrDel.TextColor = System.Drawing.Color.White;
            this.addrDel.Click += new System.EventHandler(this.addrDel_Click);
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(12, 30);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(239, 29);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 62137;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.TabIndex = 10;
            this.uiSymbolLabel1.Text = "주소록 관리 프로그램 1.0";
            this.uiSymbolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.cxFlatPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cxFlatPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("cxFlatPictureBox1.Image")));
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(91, 518);
            this.cxFlatPictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(172, 70);
            this.cxFlatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.cxFlatPictureBox1.TabIndex = 11;
            this.cxFlatPictureBox1.TabStop = false;
            // 
            // addrHelp
            // 
            this.addrHelp.BackColor = System.Drawing.Color.Transparent;
            this.addrHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addrHelp.FillColor = System.Drawing.Color.Gray;
            this.addrHelp.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.addrHelp.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.addrHelp.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.addrHelp.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addrHelp.IsCircle = true;
            this.addrHelp.Location = new System.Drawing.Point(565, 45);
            this.addrHelp.MinimumSize = new System.Drawing.Size(1, 1);
            this.addrHelp.Name = "addrHelp";
            this.addrHelp.RectColor = System.Drawing.Color.Gray;
            this.addrHelp.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.addrHelp.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.addrHelp.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.addrHelp.Size = new System.Drawing.Size(50, 50);
            this.addrHelp.Style = Sunny.UI.UIStyle.Custom;
            this.addrHelp.Symbol = 61736;
            this.addrHelp.SymbolSize = 26;
            this.addrHelp.TabIndex = 12;
            this.addrHelp.Click += new System.EventHandler(this.addrHelp_Click);
            // 
            // addrExit
            // 
            this.addrExit.BackColor = System.Drawing.Color.Transparent;
            this.addrExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addrExit.FillColor = System.Drawing.Color.Gray;
            this.addrExit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.addrExit.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(103)))));
            this.addrExit.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(103)))));
            this.addrExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addrExit.IsCircle = true;
            this.addrExit.Location = new System.Drawing.Point(624, 45);
            this.addrExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.addrExit.Name = "addrExit";
            this.addrExit.RectColor = System.Drawing.Color.Gray;
            this.addrExit.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.addrExit.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(103)))));
            this.addrExit.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(103)))));
            this.addrExit.Size = new System.Drawing.Size(50, 50);
            this.addrExit.Style = Sunny.UI.UIStyle.Custom;
            this.addrExit.Symbol = 61457;
            this.addrExit.SymbolSize = 26;
            this.addrExit.TabIndex = 13;
            this.addrExit.Click += new System.EventHandler(this.addrExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 64);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 467);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 530);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addrExit);
            this.Controls.Add(this.addrHelp);
            this.Controls.Add(this.cxFlatPictureBox1);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.addrUpdate);
            this.Controls.Add(this.addrDelAll);
            this.Controls.Add(this.addrDel);
            this.Controls.Add(this.addrAddRand);
            this.Controls.Add(this.addrView);
            this.Controls.Add(this.addrAdd);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CxFlatUI.CxFlatRoundButton addrAdd;
        private CxFlatUI.CxFlatRoundButton addrView;
        private CxFlatUI.CxFlatRoundButton addrAddRand;
        private CxFlatUI.CxFlatRoundButton addrUpdate;
        private CxFlatUI.CxFlatRoundButton addrDelAll;
        private CxFlatUI.CxFlatRoundButton addrDel;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private Sunny.UI.UISymbolButton addrHelp;
        private Sunny.UI.UISymbolButton addrExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

