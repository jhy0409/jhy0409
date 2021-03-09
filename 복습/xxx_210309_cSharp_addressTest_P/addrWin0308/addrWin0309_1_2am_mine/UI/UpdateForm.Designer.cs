
namespace addrWin0302.UI
{
    partial class UpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.upList = new System.Windows.Forms.ListView();
            this.list_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_addr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.upEmail = new Sunny.UI.UITextBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.upAddr = new Sunny.UI.UITextBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.upTel = new Sunny.UI.UITextBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.upName = new Sunny.UI.UITextBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.addCancle = new Sunny.UI.UISymbolButton();
            this.addOk = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // upList
            // 
            this.upList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_count,
            this.list_name,
            this.list_tel,
            this.list_addr,
            this.list_email});
            this.upList.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.upList.FullRowSelect = true;
            this.upList.GridLines = true;
            this.upList.HideSelection = false;
            this.upList.Location = new System.Drawing.Point(34, 117);
            this.upList.Margin = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.upList.Name = "upList";
            this.upList.Size = new System.Drawing.Size(650, 246);
            this.upList.TabIndex = 1;
            this.upList.UseCompatibleStateImageBehavior = false;
            this.upList.View = System.Windows.Forms.View.Details;
            this.upList.SelectedIndexChanged += new System.EventHandler(this.upList_SelectedIndexChanged);
            // 
            // list_count
            // 
            this.list_count.Text = "번호";
            this.list_count.Width = 45;
            // 
            // list_name
            // 
            this.list_name.Text = "이름";
            this.list_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_name.Width = 70;
            // 
            // list_tel
            // 
            this.list_tel.Text = "전화";
            this.list_tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_tel.Width = 140;
            // 
            // list_addr
            // 
            this.list_addr.Text = "주소";
            this.list_addr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_addr.Width = 200;
            // 
            // list_email
            // 
            this.list_email.Text = "이메일";
            this.list_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_email.Width = 150;
            // 
            // upEmail
            // 
            this.upEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.upEmail.FillColor = System.Drawing.Color.White;
            this.upEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.upEmail.Location = new System.Drawing.Point(482, 452);
            this.upEmail.Margin = new System.Windows.Forms.Padding(0);
            this.upEmail.Maximum = 2147483647D;
            this.upEmail.Minimum = -2147483648D;
            this.upEmail.MinimumSize = new System.Drawing.Size(1, 38);
            this.upEmail.Name = "upEmail";
            this.upEmail.Padding = new System.Windows.Forms.Padding(5);
            this.upEmail.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.upEmail.Size = new System.Drawing.Size(200, 38);
            this.upEmail.Style = Sunny.UI.UIStyle.Custom;
            this.upEmail.TabIndex = 53;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel4.Location = new System.Drawing.Point(372, 452);
            this.uiSymbolLabel4.Margin = new System.Windows.Forms.Padding(0);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(94, 37);
            this.uiSymbolLabel4.Symbol = 57462;
            this.uiSymbolLabel4.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(116)))), ((int)(((byte)(140)))));
            this.uiSymbolLabel4.TabIndex = 52;
            this.uiSymbolLabel4.Text = "메일";
            // 
            // upAddr
            // 
            this.upAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.upAddr.FillColor = System.Drawing.Color.White;
            this.upAddr.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.upAddr.Location = new System.Drawing.Point(482, 385);
            this.upAddr.Margin = new System.Windows.Forms.Padding(0);
            this.upAddr.Maximum = 2147483647D;
            this.upAddr.Minimum = -2147483648D;
            this.upAddr.MinimumSize = new System.Drawing.Size(1, 38);
            this.upAddr.Name = "upAddr";
            this.upAddr.Padding = new System.Windows.Forms.Padding(5);
            this.upAddr.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.upAddr.Size = new System.Drawing.Size(200, 38);
            this.upAddr.Style = Sunny.UI.UIStyle.Custom;
            this.upAddr.TabIndex = 51;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel3.Location = new System.Drawing.Point(372, 385);
            this.uiSymbolLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(94, 37);
            this.uiSymbolLabel3.Symbol = 57473;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(116)))), ((int)(((byte)(140)))));
            this.uiSymbolLabel3.TabIndex = 50;
            this.uiSymbolLabel3.Text = "주소";
            // 
            // upTel
            // 
            this.upTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.upTel.FillColor = System.Drawing.Color.White;
            this.upTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.upTel.Location = new System.Drawing.Point(142, 455);
            this.upTel.Margin = new System.Windows.Forms.Padding(0);
            this.upTel.Maximum = 2147483647D;
            this.upTel.Minimum = -2147483648D;
            this.upTel.MinimumSize = new System.Drawing.Size(1, 38);
            this.upTel.Name = "upTel";
            this.upTel.Padding = new System.Windows.Forms.Padding(5);
            this.upTel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.upTel.Size = new System.Drawing.Size(200, 38);
            this.upTel.Style = Sunny.UI.UIStyle.Custom;
            this.upTel.TabIndex = 49;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel2.Location = new System.Drawing.Point(32, 455);
            this.uiSymbolLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(94, 37);
            this.uiSymbolLabel2.Symbol = 57488;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(116)))), ((int)(((byte)(140)))));
            this.uiSymbolLabel2.TabIndex = 48;
            this.uiSymbolLabel2.Text = "전화";
            // 
            // upName
            // 
            this.upName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.upName.FillColor = System.Drawing.Color.White;
            this.upName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.upName.Location = new System.Drawing.Point(142, 385);
            this.upName.Margin = new System.Windows.Forms.Padding(0);
            this.upName.Maximum = 2147483647D;
            this.upName.Minimum = -2147483648D;
            this.upName.MinimumSize = new System.Drawing.Size(1, 38);
            this.upName.Name = "upName";
            this.upName.Padding = new System.Windows.Forms.Padding(5);
            this.upName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.upName.Size = new System.Drawing.Size(200, 38);
            this.upName.Style = Sunny.UI.UIStyle.Custom;
            this.upName.TabIndex = 47;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(32, 385);
            this.uiSymbolLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(94, 37);
            this.uiSymbolLabel1.Symbol = 57482;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(116)))), ((int)(((byte)(140)))));
            this.uiSymbolLabel1.TabIndex = 46;
            this.uiSymbolLabel1.Text = "이름";
            // 
            // addCancle
            // 
            this.addCancle.BackColor = System.Drawing.Color.Transparent;
            this.addCancle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCancle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.addCancle.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.addCancle.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.addCancle.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.addCancle.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCancle.IsCircle = true;
            this.addCancle.Location = new System.Drawing.Point(639, 41);
            this.addCancle.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.addCancle.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCancle.Name = "addCancle";
            this.addCancle.Radius = 40;
            this.addCancle.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.addCancle.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.addCancle.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.addCancle.Size = new System.Drawing.Size(45, 45);
            this.addCancle.Style = Sunny.UI.UIStyle.Custom;
            this.addCancle.Symbol = 61453;
            this.addCancle.TabIndex = 45;
            this.addCancle.Click += new System.EventHandler(this.addCancle_Click);
            // 
            // addOk
            // 
            this.addOk.BackColor = System.Drawing.Color.Transparent;
            this.addOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOk.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addOk.IsCircle = true;
            this.addOk.Location = new System.Drawing.Point(586, 41);
            this.addOk.Margin = new System.Windows.Forms.Padding(92, 3, 10, 3);
            this.addOk.MinimumSize = new System.Drawing.Size(1, 1);
            this.addOk.Name = "addOk";
            this.addOk.Radius = 40;
            this.addOk.Size = new System.Drawing.Size(45, 45);
            this.addOk.TabIndex = 44;
            this.addOk.Click += new System.EventHandler(this.addOk_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 530);
            this.Controls.Add(this.upEmail);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.upAddr);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.upTel);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.upName);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.addCancle);
            this.Controls.Add(this.addOk);
            this.Controls.Add(this.upList);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView upList;
        private System.Windows.Forms.ColumnHeader list_count;
        private System.Windows.Forms.ColumnHeader list_name;
        private System.Windows.Forms.ColumnHeader list_tel;
        private System.Windows.Forms.ColumnHeader list_addr;
        private System.Windows.Forms.ColumnHeader list_email;
        private Sunny.UI.UITextBox upEmail;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UITextBox upAddr;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UITextBox upTel;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UITextBox upName;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolButton addCancle;
        private Sunny.UI.UISymbolButton addOk;
    }
}