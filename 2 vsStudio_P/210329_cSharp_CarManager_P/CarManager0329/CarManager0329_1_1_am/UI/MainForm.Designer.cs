
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_mainTableAdd = new Sunny.UI.UISymbolButton();
            this.btn_mainTableDel = new Sunny.UI.UISymbolButton();
            this.insertAll = new Sunny.UI.UISymbolButton();
            this.insertCar = new Sunny.UI.UISymbolButton();
            this.insertCustomer = new Sunny.UI.UISymbolButton();
            this.insertSeller = new Sunny.UI.UISymbolButton();
            this.insertDeal = new Sunny.UI.UISymbolButton();
            this.appExit = new Sunny.UI.UISymbolButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_mainTableAdd
            // 
            this.btn_mainTableAdd.BackColor = System.Drawing.Color.Transparent;
            this.btn_mainTableAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mainTableAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(94)))), ((int)(((byte)(105)))));
            this.btn_mainTableAdd.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(94)))), ((int)(((byte)(105)))));
            this.btn_mainTableAdd.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(61)))));
            this.btn_mainTableAdd.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(61)))));
            this.btn_mainTableAdd.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btn_mainTableAdd.IsCircle = true;
            this.btn_mainTableAdd.Location = new System.Drawing.Point(640, 29);
            this.btn_mainTableAdd.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_mainTableAdd.Name = "btn_mainTableAdd";
            this.btn_mainTableAdd.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(112)))), ((int)(((byte)(125)))));
            this.btn_mainTableAdd.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(94)))), ((int)(((byte)(105)))));
            this.btn_mainTableAdd.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(61)))));
            this.btn_mainTableAdd.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(61)))));
            this.btn_mainTableAdd.Size = new System.Drawing.Size(30, 30);
            this.btn_mainTableAdd.Style = Sunny.UI.UIStyle.Custom;
            this.btn_mainTableAdd.Symbol = 62004;
            this.btn_mainTableAdd.SymbolSize = 20;
            this.btn_mainTableAdd.TabIndex = 3;
            this.btn_mainTableAdd.Click += new System.EventHandler(this.btn_mainTableAdd_Click);
            // 
            // btn_mainTableDel
            // 
            this.btn_mainTableDel.BackColor = System.Drawing.Color.Transparent;
            this.btn_mainTableDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mainTableDel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(94)))), ((int)(((byte)(105)))));
            this.btn_mainTableDel.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(94)))), ((int)(((byte)(105)))));
            this.btn_mainTableDel.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(61)))));
            this.btn_mainTableDel.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(61)))));
            this.btn_mainTableDel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btn_mainTableDel.IsCircle = true;
            this.btn_mainTableDel.Location = new System.Drawing.Point(676, 29);
            this.btn_mainTableDel.MinimumSize = new System.Drawing.Size(30, 30);
            this.btn_mainTableDel.Name = "btn_mainTableDel";
            this.btn_mainTableDel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(112)))), ((int)(((byte)(125)))));
            this.btn_mainTableDel.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(94)))), ((int)(((byte)(105)))));
            this.btn_mainTableDel.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(61)))));
            this.btn_mainTableDel.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(61)))));
            this.btn_mainTableDel.Size = new System.Drawing.Size(30, 30);
            this.btn_mainTableDel.Style = Sunny.UI.UIStyle.Custom;
            this.btn_mainTableDel.Symbol = 62005;
            this.btn_mainTableDel.SymbolSize = 20;
            this.btn_mainTableDel.TabIndex = 4;
            this.btn_mainTableDel.Click += new System.EventHandler(this.btn_mainTableDel_Click);
            // 
            // insertAll
            // 
            this.insertAll.BackColor = System.Drawing.Color.Transparent;
            this.insertAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertAll.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.insertAll.Location = new System.Drawing.Point(73, 509);
            this.insertAll.Margin = new System.Windows.Forms.Padding(8);
            this.insertAll.MinimumSize = new System.Drawing.Size(1, 1);
            this.insertAll.Name = "insertAll";
            this.insertAll.Size = new System.Drawing.Size(181, 35);
            this.insertAll.TabIndex = 5;
            this.insertAll.Text = "모든 데이터 추가";
            this.insertAll.Click += new System.EventHandler(this.insertAll_Click);
            // 
            // insertCar
            // 
            this.insertCar.BackColor = System.Drawing.Color.Transparent;
            this.insertCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertCar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.insertCar.Location = new System.Drawing.Point(270, 509);
            this.insertCar.Margin = new System.Windows.Forms.Padding(8);
            this.insertCar.MinimumSize = new System.Drawing.Size(1, 1);
            this.insertCar.Name = "insertCar";
            this.insertCar.Size = new System.Drawing.Size(181, 35);
            this.insertCar.TabIndex = 6;
            this.insertCar.Text = "차량 정보 추가";
            this.insertCar.Click += new System.EventHandler(this.insertCar_Click);
            // 
            // insertCustomer
            // 
            this.insertCustomer.BackColor = System.Drawing.Color.Transparent;
            this.insertCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertCustomer.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.insertCustomer.Location = new System.Drawing.Point(467, 509);
            this.insertCustomer.Margin = new System.Windows.Forms.Padding(8);
            this.insertCustomer.MinimumSize = new System.Drawing.Size(1, 1);
            this.insertCustomer.Name = "insertCustomer";
            this.insertCustomer.Size = new System.Drawing.Size(181, 35);
            this.insertCustomer.TabIndex = 7;
            this.insertCustomer.Text = "고객 정보 추가";
            this.insertCustomer.Click += new System.EventHandler(this.insertCustomer_Click);
            // 
            // insertSeller
            // 
            this.insertSeller.BackColor = System.Drawing.Color.Transparent;
            this.insertSeller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertSeller.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.insertSeller.Location = new System.Drawing.Point(73, 560);
            this.insertSeller.Margin = new System.Windows.Forms.Padding(8);
            this.insertSeller.MinimumSize = new System.Drawing.Size(1, 1);
            this.insertSeller.Name = "insertSeller";
            this.insertSeller.Size = new System.Drawing.Size(181, 35);
            this.insertSeller.TabIndex = 8;
            this.insertSeller.Text = "판매자 정보 추가";
            this.insertSeller.Click += new System.EventHandler(this.insertSeller_Click);
            // 
            // insertDeal
            // 
            this.insertDeal.BackColor = System.Drawing.Color.Transparent;
            this.insertDeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertDeal.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.insertDeal.Location = new System.Drawing.Point(270, 560);
            this.insertDeal.Margin = new System.Windows.Forms.Padding(8);
            this.insertDeal.MinimumSize = new System.Drawing.Size(1, 1);
            this.insertDeal.Name = "insertDeal";
            this.insertDeal.Size = new System.Drawing.Size(181, 35);
            this.insertDeal.TabIndex = 9;
            this.insertDeal.Text = "거래 정보 추가";
            // 
            // appExit
            // 
            this.appExit.BackColor = System.Drawing.Color.Transparent;
            this.appExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.appExit.Location = new System.Drawing.Point(467, 560);
            this.appExit.Margin = new System.Windows.Forms.Padding(8);
            this.appExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.appExit.Name = "appExit";
            this.appExit.Size = new System.Drawing.Size(181, 35);
            this.appExit.TabIndex = 10;
            this.appExit.Text = "프로그램 종료";
            this.appExit.Click += new System.EventHandler(this.appExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(95, 151);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(104, 0, 104, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 620);
            this.Controls.Add(this.appExit);
            this.Controls.Add(this.insertDeal);
            this.Controls.Add(this.insertSeller);
            this.Controls.Add(this.insertCustomer);
            this.Controls.Add(this.insertCar);
            this.Controls.Add(this.insertAll);
            this.Controls.Add(this.btn_mainTableDel);
            this.Controls.Add(this.btn_mainTableAdd);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "차량 고객 관리 프로그램 v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UISymbolButton btn_mainTableAdd;
        private Sunny.UI.UISymbolButton btn_mainTableDel;
        private Sunny.UI.UISymbolButton insertAll;
        private Sunny.UI.UISymbolButton insertCar;
        private Sunny.UI.UISymbolButton insertCustomer;
        private Sunny.UI.UISymbolButton insertSeller;
        private Sunny.UI.UISymbolButton insertDeal;
        private Sunny.UI.UISymbolButton appExit;
    }
}

