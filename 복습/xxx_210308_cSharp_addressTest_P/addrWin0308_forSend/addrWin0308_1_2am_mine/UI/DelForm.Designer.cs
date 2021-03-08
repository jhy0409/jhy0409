
namespace addrWin0302.UI
{
    partial class DelForm
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
            this.addCancle.Location = new System.Drawing.Point(635, 44);
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
            this.addCancle.TabIndex = 39;
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
            this.addOk.Symbol = 57469;
            this.addOk.TabIndex = 38;
            this.addOk.TagString = "";
            this.addOk.Text = "삭제";
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
            this.listView.Size = new System.Drawing.Size(650, 300);
            this.listView.TabIndex = 40;
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
            // DelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 530);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.addCancle);
            this.Controls.Add(this.addOk);
            this.Name = "DelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "데이터 삭제";
            this.Load += new System.EventHandler(this.delForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton addCancle;
        private Sunny.UI.UISymbolButton addOk;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader list_count;
        private System.Windows.Forms.ColumnHeader list_id;
        private System.Windows.Forms.ColumnHeader list_name;
        private System.Windows.Forms.ColumnHeader list_tel;
        private System.Windows.Forms.ColumnHeader list_addr;
        private System.Windows.Forms.ColumnHeader list_email;
    }
}