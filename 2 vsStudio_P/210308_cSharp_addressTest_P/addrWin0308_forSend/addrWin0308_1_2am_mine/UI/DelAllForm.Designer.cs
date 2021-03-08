
namespace addrWin0302.UI
{
    partial class DelAllForm
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
            this.btn_delAll = new Sunny.UI.UISymbolButton();
            this.delCancle = new Sunny.UI.UISymbolButton();
            this.listView = new System.Windows.Forms.ListView();
            this.list_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_addr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_delAll
            // 
            this.btn_delAll.BackColor = System.Drawing.Color.Transparent;
            this.btn_delAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delAll.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btn_delAll.Location = new System.Drawing.Point(285, 458);
            this.btn_delAll.Margin = new System.Windows.Forms.Padding(92, 3, 10, 3);
            this.btn_delAll.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_delAll.Name = "btn_delAll";
            this.btn_delAll.Radius = 45;
            this.btn_delAll.Size = new System.Drawing.Size(150, 45);
            this.btn_delAll.TabIndex = 37;
            this.btn_delAll.TagString = "";
            this.btn_delAll.Text = "전체삭제";
            this.btn_delAll.Click += new System.EventHandler(this.btn_delAll_Click);
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
            this.delCancle.IsCircle = true;
            this.delCancle.Location = new System.Drawing.Point(635, 45);
            this.delCancle.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.delCancle.MinimumSize = new System.Drawing.Size(1, 1);
            this.delCancle.Name = "delCancle";
            this.delCancle.Radius = 0;
            this.delCancle.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.delCancle.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.delCancle.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.delCancle.Size = new System.Drawing.Size(50, 50);
            this.delCancle.Style = Sunny.UI.UIStyle.Custom;
            this.delCancle.Symbol = 61453;
            this.delCancle.TabIndex = 38;
            this.delCancle.Click += new System.EventHandler(this.delCancle_Click);
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
            this.listView.TabIndex = 39;
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
            // DelAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 530);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.delCancle);
            this.Controls.Add(this.btn_delAll);
            this.Name = "DelAllForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "전체삭제";
            this.Load += new System.EventHandler(this.DelAllForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton btn_delAll;
        private Sunny.UI.UISymbolButton delCancle;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader list_count;
        private System.Windows.Forms.ColumnHeader list_id;
        private System.Windows.Forms.ColumnHeader list_name;
        private System.Windows.Forms.ColumnHeader list_tel;
        private System.Windows.Forms.ColumnHeader list_addr;
        private System.Windows.Forms.ColumnHeader list_email;
    }
}