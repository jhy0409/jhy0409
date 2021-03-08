
namespace addrWin0302.UI
{
    partial class EditForm
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
            this.addCancle = new Sunny.UI.UISymbolButton();
            this.addOk = new Sunny.UI.UISymbolButton();
            this.listView = new System.Windows.Forms.ListView();
            this.list_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_addr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EditEmail = new Sunny.UI.UITextBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.EditAddr = new Sunny.UI.UITextBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.EditTel = new Sunny.UI.UITextBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.EditName = new Sunny.UI.UITextBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.SuspendLayout();
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
            this.addCancle.Location = new System.Drawing.Point(635, 45);
            this.addCancle.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.addCancle.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCancle.Name = "addCancle";
            this.addCancle.Radius = 0;
            this.addCancle.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.addCancle.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.addCancle.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.addCancle.Size = new System.Drawing.Size(50, 50);
            this.addCancle.Style = Sunny.UI.UIStyle.Custom;
            this.addCancle.Symbol = 61453;
            this.addCancle.TabIndex = 37;
            this.addCancle.Click += new System.EventHandler(this.addCancle_Click);
            // 
            // addOk
            // 
            this.addOk.BackColor = System.Drawing.Color.Transparent;
            this.addOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOk.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addOk.Location = new System.Drawing.Point(285, 458);
            this.addOk.Margin = new System.Windows.Forms.Padding(92, 3, 10, 3);
            this.addOk.MinimumSize = new System.Drawing.Size(1, 1);
            this.addOk.Name = "addOk";
            this.addOk.Radius = 45;
            this.addOk.Size = new System.Drawing.Size(150, 45);
            this.addOk.TabIndex = 36;
            this.addOk.TagString = "";
            this.addOk.Text = "수정";
            this.addOk.Click += new System.EventHandler(this.addOk_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_count,
            this.list_id,
            this.list_name,
            this.list_tel,
            this.list_addr,
            this.list_email});
            this.listView.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(35, 130);
            this.listView.Margin = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(650, 180);
            this.listView.TabIndex = 38;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // list_count
            // 
            this.list_count.Text = "번호";
            this.list_count.Width = 40;
            // 
            // list_id
            // 
            this.list_id.Text = "id";
            this.list_id.Width = 40;
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
            this.list_addr.Width = 180;
            // 
            // list_email
            // 
            this.list_email.Text = "이메일";
            this.list_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_email.Width = 150;
            // 
            // EditEmail
            // 
            this.EditEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EditEmail.FillColor = System.Drawing.Color.White;
            this.EditEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.EditEmail.Location = new System.Drawing.Point(485, 384);
            this.EditEmail.Margin = new System.Windows.Forms.Padding(4, 5, 25, 5);
            this.EditEmail.Maximum = 2147483647D;
            this.EditEmail.Minimum = -2147483648D;
            this.EditEmail.MinimumSize = new System.Drawing.Size(1, 38);
            this.EditEmail.Name = "EditEmail";
            this.EditEmail.Padding = new System.Windows.Forms.Padding(5);
            this.EditEmail.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EditEmail.Size = new System.Drawing.Size(200, 38);
            this.EditEmail.Style = Sunny.UI.UIStyle.Custom;
            this.EditEmail.TabIndex = 51;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel4.Location = new System.Drawing.Point(389, 385);
            this.uiSymbolLabel4.Margin = new System.Windows.Forms.Padding(40, 3, 12, 3);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(80, 37);
            this.uiSymbolLabel4.Symbol = 57462;
            this.uiSymbolLabel4.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(116)))), ((int)(((byte)(140)))));
            this.uiSymbolLabel4.TabIndex = 50;
            this.uiSymbolLabel4.Text = "메일";
            // 
            // EditAddr
            // 
            this.EditAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EditAddr.FillColor = System.Drawing.Color.White;
            this.EditAddr.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.EditAddr.Location = new System.Drawing.Point(485, 336);
            this.EditAddr.Margin = new System.Windows.Forms.Padding(4, 5, 25, 5);
            this.EditAddr.Maximum = 2147483647D;
            this.EditAddr.Minimum = -2147483648D;
            this.EditAddr.MinimumSize = new System.Drawing.Size(1, 38);
            this.EditAddr.Name = "EditAddr";
            this.EditAddr.Padding = new System.Windows.Forms.Padding(5);
            this.EditAddr.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EditAddr.Size = new System.Drawing.Size(200, 38);
            this.EditAddr.Style = Sunny.UI.UIStyle.Custom;
            this.EditAddr.TabIndex = 49;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel3.Location = new System.Drawing.Point(389, 337);
            this.uiSymbolLabel3.Margin = new System.Windows.Forms.Padding(40, 3, 12, 3);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(80, 37);
            this.uiSymbolLabel3.Symbol = 57473;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(116)))), ((int)(((byte)(140)))));
            this.uiSymbolLabel3.TabIndex = 48;
            this.uiSymbolLabel3.Text = "주소";
            // 
            // EditTel
            // 
            this.EditTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EditTel.FillColor = System.Drawing.Color.White;
            this.EditTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.EditTel.Location = new System.Drawing.Point(131, 387);
            this.EditTel.Margin = new System.Windows.Forms.Padding(4, 5, 25, 5);
            this.EditTel.Maximum = 2147483647D;
            this.EditTel.Minimum = -2147483648D;
            this.EditTel.MinimumSize = new System.Drawing.Size(1, 38);
            this.EditTel.Name = "EditTel";
            this.EditTel.Padding = new System.Windows.Forms.Padding(5);
            this.EditTel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EditTel.Size = new System.Drawing.Size(200, 38);
            this.EditTel.Style = Sunny.UI.UIStyle.Custom;
            this.EditTel.TabIndex = 47;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel2.Location = new System.Drawing.Point(35, 388);
            this.uiSymbolLabel2.Margin = new System.Windows.Forms.Padding(40, 3, 12, 3);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(80, 37);
            this.uiSymbolLabel2.Symbol = 57488;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(116)))), ((int)(((byte)(140)))));
            this.uiSymbolLabel2.TabIndex = 46;
            this.uiSymbolLabel2.Text = "전화";
            // 
            // EditName
            // 
            this.EditName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EditName.FillColor = System.Drawing.Color.White;
            this.EditName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.EditName.Location = new System.Drawing.Point(131, 336);
            this.EditName.Margin = new System.Windows.Forms.Padding(4, 5, 25, 5);
            this.EditName.Maximum = 2147483647D;
            this.EditName.Minimum = -2147483648D;
            this.EditName.MinimumSize = new System.Drawing.Size(1, 38);
            this.EditName.Name = "EditName";
            this.EditName.Padding = new System.Windows.Forms.Padding(5);
            this.EditName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EditName.Size = new System.Drawing.Size(200, 38);
            this.EditName.Style = Sunny.UI.UIStyle.Custom;
            this.EditName.TabIndex = 45;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(35, 337);
            this.uiSymbolLabel1.Margin = new System.Windows.Forms.Padding(40, 3, 12, 3);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(80, 37);
            this.uiSymbolLabel1.Symbol = 57482;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(116)))), ((int)(((byte)(140)))));
            this.uiSymbolLabel1.TabIndex = 44;
            this.uiSymbolLabel1.Text = "이름";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 530);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.EditEmail);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.EditAddr);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.EditTel);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.EditName);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.addCancle);
            this.Controls.Add(this.addOk);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "주소록 수정";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton addCancle;
        private Sunny.UI.UISymbolButton addOk;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader list_count;
        private System.Windows.Forms.ColumnHeader list_name;
        private System.Windows.Forms.ColumnHeader list_tel;
        private System.Windows.Forms.ColumnHeader list_addr;
        private System.Windows.Forms.ColumnHeader list_email;
        private System.Windows.Forms.ColumnHeader list_id;
        private Sunny.UI.UITextBox EditEmail;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UITextBox EditAddr;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UITextBox EditTel;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UITextBox EditName;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
    }
}