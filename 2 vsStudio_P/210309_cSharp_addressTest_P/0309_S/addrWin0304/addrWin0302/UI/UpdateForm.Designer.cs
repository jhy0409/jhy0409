
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
            this.upCancel = new Sunny.UI.UISymbolButton();
            this.upOK = new Sunny.UI.UISymbolButton();
            this.upTel = new Sunny.UI.UITextBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.upEmail = new Sunny.UI.UITextBox();
            this.upAddr = new Sunny.UI.UITextBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.upName = new Sunny.UI.UITextBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.upList = new System.Windows.Forms.ListView();
            this.list_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_addr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // upCancel
            // 
            this.upCancel.BackColor = System.Drawing.Color.Transparent;
            this.upCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upCancel.FillColor = System.Drawing.Color.Red;
            this.upCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.upCancel.IsCircle = true;
            this.upCancel.Location = new System.Drawing.Point(348, 539);
            this.upCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.upCancel.Name = "upCancel";
            this.upCancel.RectColor = System.Drawing.Color.Red;
            this.upCancel.Size = new System.Drawing.Size(50, 50);
            this.upCancel.Style = Sunny.UI.UIStyle.Custom;
            this.upCancel.Symbol = 61453;
            this.upCancel.SymbolSize = 30;
            this.upCancel.TabIndex = 15;
            // 
            // upOK
            // 
            this.upOK.BackColor = System.Drawing.Color.Transparent;
            this.upOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.upOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.upOK.IsCircle = true;
            this.upOK.Location = new System.Drawing.Point(239, 539);
            this.upOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.upOK.Name = "upOK";
            this.upOK.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.upOK.Size = new System.Drawing.Size(50, 50);
            this.upOK.Style = Sunny.UI.UIStyle.Custom;
            this.upOK.SymbolSize = 30;
            this.upOK.TabIndex = 14;
            // 
            // upTel
            // 
            this.upTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.upTel.FillColor = System.Drawing.Color.White;
            this.upTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.upTel.Location = new System.Drawing.Point(348, 351);
            this.upTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upTel.Maximum = 2147483647D;
            this.upTel.Minimum = -2147483648D;
            this.upTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.upTel.Name = "upTel";
            this.upTel.Padding = new System.Windows.Forms.Padding(5);
            this.upTel.Size = new System.Drawing.Size(182, 29);
            this.upTel.TabIndex = 11;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(107, 351);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel3.Symbol = 57488;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel3.TabIndex = 8;
            this.uiSymbolLabel3.Text = "전 화";
            // 
            // upEmail
            // 
            this.upEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.upEmail.FillColor = System.Drawing.Color.White;
            this.upEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.upEmail.Location = new System.Drawing.Point(348, 477);
            this.upEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upEmail.Maximum = 2147483647D;
            this.upEmail.Minimum = -2147483648D;
            this.upEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.upEmail.Name = "upEmail";
            this.upEmail.Padding = new System.Windows.Forms.Padding(5);
            this.upEmail.Size = new System.Drawing.Size(182, 29);
            this.upEmail.TabIndex = 12;
            // 
            // upAddr
            // 
            this.upAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.upAddr.FillColor = System.Drawing.Color.White;
            this.upAddr.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.upAddr.Location = new System.Drawing.Point(348, 412);
            this.upAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upAddr.Maximum = 2147483647D;
            this.upAddr.Minimum = -2147483648D;
            this.upAddr.MinimumSize = new System.Drawing.Size(1, 1);
            this.upAddr.Name = "upAddr";
            this.upAddr.Padding = new System.Windows.Forms.Padding(5);
            this.upAddr.Size = new System.Drawing.Size(182, 29);
            this.upAddr.TabIndex = 13;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel4.Location = new System.Drawing.Point(107, 477);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel4.Symbol = 61946;
            this.uiSymbolLabel4.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel4.TabIndex = 9;
            this.uiSymbolLabel4.Text = "메 일";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(107, 412);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel2.Symbol = 61649;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel2.TabIndex = 10;
            this.uiSymbolLabel2.Text = "주 소";
            // 
            // upName
            // 
            this.upName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.upName.FillColor = System.Drawing.Color.White;
            this.upName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.upName.Location = new System.Drawing.Point(348, 290);
            this.upName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upName.Maximum = 2147483647D;
            this.upName.Minimum = -2147483648D;
            this.upName.MinimumSize = new System.Drawing.Size(1, 1);
            this.upName.Name = "upName";
            this.upName.Padding = new System.Windows.Forms.Padding(5);
            this.upName.Size = new System.Drawing.Size(182, 29);
            this.upName.TabIndex = 7;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(107, 290);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel1.Symbol = 62144;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel1.TabIndex = 6;
            this.uiSymbolLabel1.Text = "이 름";
            // 
            // upList
            // 
            this.upList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_count,
            this.list_name,
            this.list_tel,
            this.list_addr,
            this.list_email});
            this.upList.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.upList.FullRowSelect = true;
            this.upList.HideSelection = false;
            this.upList.Location = new System.Drawing.Point(12, 80);
            this.upList.Name = "upList";
            this.upList.Size = new System.Drawing.Size(638, 193);
            this.upList.TabIndex = 16;
            this.upList.UseCompatibleStateImageBehavior = false;
            this.upList.View = System.Windows.Forms.View.Details;
            this.upList.SelectedIndexChanged += new System.EventHandler(this.upList_SelectedIndexChanged);
            // 
            // list_count
            // 
            this.list_count.Text = "번 호";
            this.list_count.Width = 50;
            // 
            // list_name
            // 
            this.list_name.Text = "이 름";
            this.list_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_name.Width = 80;
            // 
            // list_tel
            // 
            this.list_tel.Text = "전 화";
            this.list_tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_tel.Width = 140;
            // 
            // list_addr
            // 
            this.list_addr.Text = "주 소";
            this.list_addr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_addr.Width = 180;
            // 
            // list_email
            // 
            this.list_email.Text = "이메일";
            this.list_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_email.Width = 150;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 626);
            this.Controls.Add(this.upList);
            this.Controls.Add(this.upCancel);
            this.Controls.Add(this.upOK);
            this.Controls.Add(this.upTel);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.upEmail);
            this.Controls.Add(this.upAddr);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.upName);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "데이터 수정";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UISymbolButton upCancel;
        private Sunny.UI.UISymbolButton upOK;
        private Sunny.UI.UITextBox upTel;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UITextBox upEmail;
        private Sunny.UI.UITextBox upAddr;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UITextBox upName;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private System.Windows.Forms.ListView upList;
        private System.Windows.Forms.ColumnHeader list_count;
        private System.Windows.Forms.ColumnHeader list_name;
        private System.Windows.Forms.ColumnHeader list_tel;
        private System.Windows.Forms.ColumnHeader list_addr;
        private System.Windows.Forms.ColumnHeader list_email;
    }
}