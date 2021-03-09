
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
            this.listView = new System.Windows.Forms.ListView();
            this.list_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_addr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.delCancle = new Sunny.UI.UISymbolButton();
            this.delItem = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_count,
            this.list_name,
            this.list_tel,
            this.list_addr,
            this.list_email});
            this.listView.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(35, 93);
            this.listView.Margin = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(650, 336);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
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
            // delCancle
            // 
            this.delCancle.BackColor = System.Drawing.Color.Transparent;
            this.delCancle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delCancle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.delCancle.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.delCancle.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.delCancle.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.delCancle.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.delCancle.Location = new System.Drawing.Point(375, 450);
            this.delCancle.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.delCancle.MinimumSize = new System.Drawing.Size(1, 1);
            this.delCancle.Name = "delCancle";
            this.delCancle.Radius = 40;
            this.delCancle.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.delCancle.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.delCancle.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.delCancle.Size = new System.Drawing.Size(130, 45);
            this.delCancle.Style = Sunny.UI.UIStyle.Custom;
            this.delCancle.TabIndex = 45;
            this.delCancle.Text = "취소";
            this.delCancle.Click += new System.EventHandler(this.addCancle_Click);
            // 
            // delItem
            // 
            this.delItem.BackColor = System.Drawing.Color.Transparent;
            this.delItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delItem.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.delItem.Location = new System.Drawing.Point(225, 450);
            this.delItem.Margin = new System.Windows.Forms.Padding(92, 3, 10, 3);
            this.delItem.MinimumSize = new System.Drawing.Size(1, 1);
            this.delItem.Name = "delItem";
            this.delItem.Radius = 40;
            this.delItem.Size = new System.Drawing.Size(130, 45);
            this.delItem.TabIndex = 44;
            this.delItem.Text = "삭제";
            this.delItem.Click += new System.EventHandler(this.delItem_Click);
            // 
            // DelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 530);
            this.Controls.Add(this.delCancle);
            this.Controls.Add(this.delItem);
            this.Controls.Add(this.listView);
            this.Name = "DelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DelForm";
            this.Load += new System.EventHandler(this.DelForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader list_count;
        private System.Windows.Forms.ColumnHeader list_name;
        private System.Windows.Forms.ColumnHeader list_tel;
        private System.Windows.Forms.ColumnHeader list_addr;
        private System.Windows.Forms.ColumnHeader list_email;
        private Sunny.UI.UISymbolButton delCancle;
        private Sunny.UI.UISymbolButton delItem;
    }
}