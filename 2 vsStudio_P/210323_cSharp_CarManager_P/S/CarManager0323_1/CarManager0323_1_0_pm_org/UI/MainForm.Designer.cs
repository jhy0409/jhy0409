
namespace CarManager0323
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
            this.createTB = new Sunny.UI.UIButton();
            this.dropTB = new Sunny.UI.UIButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // createTB
            // 
            this.createTB.BackColor = System.Drawing.Color.Black;
            this.createTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createTB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.createTB.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(96)))), ((int)(((byte)(107)))));
            this.createTB.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.createTB.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.createTB.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.createTB.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.createTB.Location = new System.Drawing.Point(456, 32);
            this.createTB.Margin = new System.Windows.Forms.Padding(5);
            this.createTB.MinimumSize = new System.Drawing.Size(120, 25);
            this.createTB.Name = "createTB";
            this.createTB.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.createTB.RectHoverColor = System.Drawing.Color.DarkGray;
            this.createTB.RectPressColor = System.Drawing.Color.DimGray;
            this.createTB.RectSelectedColor = System.Drawing.Color.DimGray;
            this.createTB.Size = new System.Drawing.Size(120, 25);
            this.createTB.Style = Sunny.UI.UIStyle.Custom;
            this.createTB.TabIndex = 0;
            this.createTB.Text = "테이블 생성";
            this.createTB.Click += new System.EventHandler(this.createTB_Click);
            // 
            // dropTB
            // 
            this.dropTB.BackColor = System.Drawing.Color.Black;
            this.dropTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropTB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.dropTB.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(96)))), ((int)(((byte)(107)))));
            this.dropTB.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.dropTB.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.dropTB.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.dropTB.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.dropTB.Location = new System.Drawing.Point(586, 32);
            this.dropTB.Margin = new System.Windows.Forms.Padding(5);
            this.dropTB.MinimumSize = new System.Drawing.Size(120, 25);
            this.dropTB.Name = "dropTB";
            this.dropTB.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(132)))), ((int)(((byte)(137)))));
            this.dropTB.RectHoverColor = System.Drawing.Color.DarkGray;
            this.dropTB.RectPressColor = System.Drawing.Color.DimGray;
            this.dropTB.RectSelectedColor = System.Drawing.Color.DimGray;
            this.dropTB.Size = new System.Drawing.Size(120, 25);
            this.dropTB.Style = Sunny.UI.UIStyle.Custom;
            this.dropTB.TabIndex = 1;
            this.dropTB.Text = "테이블 삭제";
            this.dropTB.Click += new System.EventHandler(this.dropTB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::CarManager0323.Properties.Resources.mainImg_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 64);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(720, 555);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 620);
            this.Controls.Add(this.dropTB);
            this.Controls.Add(this.createTB);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "차량 고객 관리 프로그램 v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton createTB;
        private Sunny.UI.UIButton dropTB;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

