
namespace addrWin0302.UI
{
    partial class AddForm
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
            this.addOk = new Sunny.UI.UISymbolButton();
            this.addCancle = new Sunny.UI.UISymbolButton();
            this.addEmail = new Sunny.UI.UITextBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.addAddr = new Sunny.UI.UITextBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.addTel = new Sunny.UI.UITextBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.addName = new Sunny.UI.UITextBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.SuspendLayout();
            // 
            // addOk
            // 
            this.addOk.BackColor = System.Drawing.Color.Transparent;
            this.addOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOk.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addOk.Location = new System.Drawing.Point(92, 401);
            this.addOk.Margin = new System.Windows.Forms.Padding(92, 3, 10, 3);
            this.addOk.MinimumSize = new System.Drawing.Size(1, 1);
            this.addOk.Name = "addOk";
            this.addOk.Radius = 40;
            this.addOk.Size = new System.Drawing.Size(130, 45);
            this.addOk.TabIndex = 8;
            this.addOk.Text = "확인";
            this.addOk.Click += new System.EventHandler(this.addOk_Click);
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
            this.addCancle.Location = new System.Drawing.Point(242, 401);
            this.addCancle.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.addCancle.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCancle.Name = "addCancle";
            this.addCancle.Radius = 40;
            this.addCancle.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.addCancle.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.addCancle.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.addCancle.Size = new System.Drawing.Size(130, 45);
            this.addCancle.Style = Sunny.UI.UIStyle.Custom;
            this.addCancle.TabIndex = 9;
            this.addCancle.Text = "취소";
            this.addCancle.Click += new System.EventHandler(this.addCancle_Click);
            // 
            // addEmail
            // 
            this.addEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addEmail.FillColor = System.Drawing.Color.White;
            this.addEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addEmail.Location = new System.Drawing.Point(154, 321);
            this.addEmail.Margin = new System.Windows.Forms.Padding(4, 5, 40, 5);
            this.addEmail.Maximum = 2147483647D;
            this.addEmail.Minimum = -2147483648D;
            this.addEmail.MinimumSize = new System.Drawing.Size(1, 38);
            this.addEmail.Name = "addEmail";
            this.addEmail.Padding = new System.Windows.Forms.Padding(5);
            this.addEmail.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addEmail.Size = new System.Drawing.Size(256, 38);
            this.addEmail.Style = Sunny.UI.UIStyle.Custom;
            this.addEmail.TabIndex = 23;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel4.Location = new System.Drawing.Point(44, 321);
            this.uiSymbolLabel4.Margin = new System.Windows.Forms.Padding(40, 3, 12, 3);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(94, 37);
            this.uiSymbolLabel4.Symbol = 57462;
            this.uiSymbolLabel4.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(116)))), ((int)(((byte)(140)))));
            this.uiSymbolLabel4.TabIndex = 22;
            this.uiSymbolLabel4.Text = "메일";
            // 
            // addAddr
            // 
            this.addAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addAddr.FillColor = System.Drawing.Color.White;
            this.addAddr.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addAddr.Location = new System.Drawing.Point(154, 254);
            this.addAddr.Margin = new System.Windows.Forms.Padding(4, 5, 40, 5);
            this.addAddr.Maximum = 2147483647D;
            this.addAddr.Minimum = -2147483648D;
            this.addAddr.MinimumSize = new System.Drawing.Size(1, 38);
            this.addAddr.Name = "addAddr";
            this.addAddr.Padding = new System.Windows.Forms.Padding(5);
            this.addAddr.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addAddr.Size = new System.Drawing.Size(256, 38);
            this.addAddr.Style = Sunny.UI.UIStyle.Custom;
            this.addAddr.TabIndex = 21;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel3.Location = new System.Drawing.Point(44, 254);
            this.uiSymbolLabel3.Margin = new System.Windows.Forms.Padding(40, 3, 12, 3);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(94, 37);
            this.uiSymbolLabel3.Symbol = 57473;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(116)))), ((int)(((byte)(140)))));
            this.uiSymbolLabel3.TabIndex = 20;
            this.uiSymbolLabel3.Text = "주소";
            // 
            // addTel
            // 
            this.addTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addTel.FillColor = System.Drawing.Color.White;
            this.addTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addTel.Location = new System.Drawing.Point(154, 181);
            this.addTel.Margin = new System.Windows.Forms.Padding(4, 5, 40, 5);
            this.addTel.Maximum = 2147483647D;
            this.addTel.Minimum = -2147483648D;
            this.addTel.MinimumSize = new System.Drawing.Size(1, 38);
            this.addTel.Name = "addTel";
            this.addTel.Padding = new System.Windows.Forms.Padding(5);
            this.addTel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addTel.Size = new System.Drawing.Size(256, 38);
            this.addTel.Style = Sunny.UI.UIStyle.Custom;
            this.addTel.TabIndex = 19;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel2.Location = new System.Drawing.Point(44, 181);
            this.uiSymbolLabel2.Margin = new System.Windows.Forms.Padding(40, 3, 12, 3);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(94, 37);
            this.uiSymbolLabel2.Symbol = 57488;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(116)))), ((int)(((byte)(140)))));
            this.uiSymbolLabel2.TabIndex = 18;
            this.uiSymbolLabel2.Text = "전화";
            // 
            // addName
            // 
            this.addName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addName.FillColor = System.Drawing.Color.White;
            this.addName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addName.Location = new System.Drawing.Point(154, 111);
            this.addName.Margin = new System.Windows.Forms.Padding(4, 5, 40, 5);
            this.addName.Maximum = 2147483647D;
            this.addName.Minimum = -2147483648D;
            this.addName.MinimumSize = new System.Drawing.Size(1, 38);
            this.addName.Name = "addName";
            this.addName.Padding = new System.Windows.Forms.Padding(5);
            this.addName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addName.Size = new System.Drawing.Size(256, 38);
            this.addName.Style = Sunny.UI.UIStyle.Custom;
            this.addName.TabIndex = 17;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(44, 111);
            this.uiSymbolLabel1.Margin = new System.Windows.Forms.Padding(40, 3, 12, 3);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(94, 37);
            this.uiSymbolLabel1.Symbol = 57482;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(116)))), ((int)(((byte)(140)))));
            this.uiSymbolLabel1.TabIndex = 16;
            this.uiSymbolLabel1.Text = "이름";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 491);
            this.Controls.Add(this.addEmail);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.addAddr);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.addTel);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.addName);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.addCancle);
            this.Controls.Add(this.addOk);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "주소록 데이터 추가";
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UISymbolButton addOk;
        private Sunny.UI.UISymbolButton addCancle;
        private Sunny.UI.UITextBox addEmail;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UITextBox addAddr;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UITextBox addTel;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UITextBox addName;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
    }
}