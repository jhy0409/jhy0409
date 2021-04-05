
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
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            this.addrView = new CxFlatUI.CxFlatRoundButton();
            this.addrAddRand = new CxFlatUI.CxFlatRoundButton();
            this.addDel = new CxFlatUI.CxFlatRoundButton();
            this.addrDelAll = new CxFlatUI.CxFlatRoundButton();
            this.addrUpdate = new CxFlatUI.CxFlatRoundButton();
            this.addrHelp = new Sunny.UI.UISymbolButton();
            this.addrExit = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addrAdd
            // 
            this.addrAdd.ButtonType = CxFlatUI.ButtonType.Primary;
            this.addrAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addrAdd.Location = new System.Drawing.Point(292, 106);
            this.addrAdd.Name = "addrAdd";
            this.addrAdd.Size = new System.Drawing.Size(200, 45);
            this.addrAdd.TabIndex = 4;
            this.addrAdd.Text = "주소록 추가";
            this.addrAdd.TextColor = System.Drawing.Color.White;
            this.addrAdd.Click += new System.EventHandler(this.addrAdd_Click);
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(13, 9);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(263, 35);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 62138;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiSymbolLabel1.TabIndex = 10;
            this.uiSymbolLabel1.Text = "주소록 관리 프로그램 1.0";
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.BackColor = System.Drawing.Color.White;
            this.cxFlatPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("cxFlatPictureBox1.Image")));
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(0, 66);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(275, 515);
            this.cxFlatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.cxFlatPictureBox1.TabIndex = 11;
            this.cxFlatPictureBox1.TabStop = false;
            // 
            // addrView
            // 
            this.addrView.ButtonType = CxFlatUI.ButtonType.Primary;
            this.addrView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addrView.Location = new System.Drawing.Point(364, 172);
            this.addrView.Name = "addrView";
            this.addrView.Size = new System.Drawing.Size(200, 45);
            this.addrView.TabIndex = 12;
            this.addrView.Text = "주소록 보기";
            this.addrView.TextColor = System.Drawing.Color.White;
            this.addrView.Click += new System.EventHandler(this.addrView_Click);
            // 
            // addrAddRand
            // 
            this.addrAddRand.ButtonType = CxFlatUI.ButtonType.Primary;
            this.addrAddRand.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addrAddRand.Location = new System.Drawing.Point(427, 253);
            this.addrAddRand.Name = "addrAddRand";
            this.addrAddRand.Size = new System.Drawing.Size(200, 45);
            this.addrAddRand.TabIndex = 13;
            this.addrAddRand.Text = "랜덤 데이터 추가";
            this.addrAddRand.TextColor = System.Drawing.Color.White;
            this.addrAddRand.Click += new System.EventHandler(this.addrAddRand_Click);
            // 
            // addDel
            // 
            this.addDel.ButtonType = CxFlatUI.ButtonType.Primary;
            this.addDel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addDel.Location = new System.Drawing.Point(427, 326);
            this.addDel.Name = "addDel";
            this.addDel.Size = new System.Drawing.Size(200, 45);
            this.addDel.TabIndex = 14;
            this.addDel.Text = "주소록 삭제";
            this.addDel.TextColor = System.Drawing.Color.White;
            this.addDel.Click += new System.EventHandler(this.addDel_Click);
            // 
            // addrDelAll
            // 
            this.addrDelAll.ButtonType = CxFlatUI.ButtonType.Primary;
            this.addrDelAll.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addrDelAll.Location = new System.Drawing.Point(364, 409);
            this.addrDelAll.Name = "addrDelAll";
            this.addrDelAll.Size = new System.Drawing.Size(200, 45);
            this.addrDelAll.TabIndex = 15;
            this.addrDelAll.Text = "주소록 전체 삭제";
            this.addrDelAll.TextColor = System.Drawing.Color.White;
            this.addrDelAll.Click += new System.EventHandler(this.addrDelAll_Click);
            // 
            // addrUpdate
            // 
            this.addrUpdate.ButtonType = CxFlatUI.ButtonType.Primary;
            this.addrUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addrUpdate.Location = new System.Drawing.Point(292, 490);
            this.addrUpdate.Name = "addrUpdate";
            this.addrUpdate.Size = new System.Drawing.Size(200, 45);
            this.addrUpdate.TabIndex = 16;
            this.addrUpdate.Text = "주소록 수정";
            this.addrUpdate.TextColor = System.Drawing.Color.White;
            this.addrUpdate.Click += new System.EventHandler(this.addrUpdate_Click);
            // 
            // addrHelp
            // 
            this.addrHelp.BackColor = System.Drawing.Color.Transparent;
            this.addrHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addrHelp.FillColor = System.Drawing.Color.Lime;
            this.addrHelp.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addrHelp.IsCircle = true;
            this.addrHelp.Location = new System.Drawing.Point(492, 33);
            this.addrHelp.MinimumSize = new System.Drawing.Size(1, 1);
            this.addrHelp.Name = "addrHelp";
            this.addrHelp.RectColor = System.Drawing.Color.Lime;
            this.addrHelp.Size = new System.Drawing.Size(60, 60);
            this.addrHelp.Style = Sunny.UI.UIStyle.Custom;
            this.addrHelp.Symbol = 61736;
            this.addrHelp.SymbolSize = 40;
            this.addrHelp.TabIndex = 17;
            this.addrHelp.Click += new System.EventHandler(this.addrHelp_Click);
            // 
            // addrExit
            // 
            this.addrExit.BackColor = System.Drawing.Color.Transparent;
            this.addrExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addrExit.FillColor = System.Drawing.Color.Red;
            this.addrExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addrExit.IsCircle = true;
            this.addrExit.Location = new System.Drawing.Point(567, 33);
            this.addrExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.addrExit.Name = "addrExit";
            this.addrExit.RectColor = System.Drawing.Color.Red;
            this.addrExit.Size = new System.Drawing.Size(60, 60);
            this.addrExit.Style = Sunny.UI.UIStyle.Custom;
            this.addrExit.Symbol = 61457;
            this.addrExit.SymbolSize = 40;
            this.addrExit.TabIndex = 18;
            this.addrExit.Click += new System.EventHandler(this.addrExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(662, 584);
            this.Controls.Add(this.addrExit);
            this.Controls.Add(this.addrHelp);
            this.Controls.Add(this.addrUpdate);
            this.Controls.Add(this.addrDelAll);
            this.Controls.Add(this.addDel);
            this.Controls.Add(this.addrAddRand);
            this.Controls.Add(this.addrView);
            this.Controls.Add(this.cxFlatPictureBox1);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.addrAdd);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatRoundButton addrAdd;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private CxFlatUI.CxFlatRoundButton addrView;
        private CxFlatUI.CxFlatRoundButton addrAddRand;
        private CxFlatUI.CxFlatRoundButton addDel;
        private CxFlatUI.CxFlatRoundButton addrDelAll;
        private CxFlatUI.CxFlatRoundButton addrUpdate;
        private Sunny.UI.UISymbolButton addrHelp;
        private Sunny.UI.UISymbolButton addrExit;
    }
}

