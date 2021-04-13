
namespace Munje3_mine
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label_mun1 = new System.Windows.Forms.Label();
            this.label_mun2 = new System.Windows.Forms.Label();
            this.label_mun3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mun2_resLabel = new System.Windows.Forms.Label();
            this.mun1_resLabel = new System.Windows.Forms.Label();
            this.mun3_resLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.mun3_insTxtBox = new VerticalTextBox();
            this.mun1_insTxtBox = new VerticalTextBox();
            this.mun2_insTxtBox = new VerticalTextBox();
            this.SuspendLayout();
            // 
            // label_mun1
            // 
            this.label_mun1.AutoSize = true;
            this.label_mun1.Location = new System.Drawing.Point(55, 47);
            this.label_mun1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.label_mun1.Name = "label_mun1";
            this.label_mun1.Size = new System.Drawing.Size(434, 15);
            this.label_mun1.TabIndex = 0;
            this.label_mun1.Text = "문제1. Inch입력받아 cm단위 구하는 코드 작성 (1inch = 2.54cm)";
            // 
            // label_mun2
            // 
            this.label_mun2.AutoSize = true;
            this.label_mun2.Location = new System.Drawing.Point(55, 212);
            this.label_mun2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.label_mun2.Name = "label_mun2";
            this.label_mun2.Size = new System.Drawing.Size(330, 15);
            this.label_mun2.TabIndex = 1;
            this.label_mun2.Text = "문제2. kg → 파운드로 (1kg = 2.20462262pound)";
            // 
            // label_mun3
            // 
            this.label_mun3.AutoSize = true;
            this.label_mun3.Location = new System.Drawing.Point(55, 376);
            this.label_mun3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.label_mun3.Name = "label_mun3";
            this.label_mun3.Size = new System.Drawing.Size(289, 15);
            this.label_mun3.TabIndex = 2;
            this.label_mun3.Text = "문제3. 원의 반지름 입력 → 원둘레와 넓이";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "입력";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "결과";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "결과";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "입력";
            // 
            // mun2_resLabel
            // 
            this.mun2_resLabel.AutoSize = true;
            this.mun2_resLabel.Location = new System.Drawing.Point(258, 277);
            this.mun2_resLabel.Name = "mun2_resLabel";
            this.mun2_resLabel.Size = new System.Drawing.Size(15, 15);
            this.mun2_resLabel.TabIndex = 13;
            this.mun2_resLabel.Text = "-";
            // 
            // mun1_resLabel
            // 
            this.mun1_resLabel.AutoSize = true;
            this.mun1_resLabel.Location = new System.Drawing.Point(258, 112);
            this.mun1_resLabel.Name = "mun1_resLabel";
            this.mun1_resLabel.Size = new System.Drawing.Size(15, 15);
            this.mun1_resLabel.TabIndex = 12;
            this.mun1_resLabel.Text = "-";
            // 
            // mun3_resLabel
            // 
            this.mun3_resLabel.AutoSize = true;
            this.mun3_resLabel.Location = new System.Drawing.Point(258, 441);
            this.mun3_resLabel.Name = "mun3_resLabel";
            this.mun3_resLabel.Size = new System.Drawing.Size(15, 15);
            this.mun3_resLabel.TabIndex = 17;
            this.mun3_resLabel.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "결과";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "입력";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 146);
            this.button1.MinimumSize = new System.Drawing.Size(75, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 18;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 311);
            this.button2.MinimumSize = new System.Drawing.Size(75, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 19;
            this.button2.Text = "확인";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 475);
            this.button3.MinimumSize = new System.Drawing.Size(75, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 20;
            this.button3.Text = "확인";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "-";
            // 
            // mun3_insTxtBox
            // 
            this.mun3_insTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.mun3_insTxtBox.BorderColor = System.Drawing.Color.Gray;
            this.mun3_insTxtBox.LeftRightPadding = ((uint)(10u));
            this.mun3_insTxtBox.Location = new System.Drawing.Point(58, 429);
            this.mun3_insTxtBox.Name = "mun3_insTxtBox";
            this.mun3_insTxtBox.Size = new System.Drawing.Size(182, 40);
            this.mun3_insTxtBox.TabIndex = 14;
            this.mun3_insTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // mun1_insTxtBox
            // 
            this.mun1_insTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.mun1_insTxtBox.BorderColor = System.Drawing.Color.Gray;
            this.mun1_insTxtBox.LeftRightPadding = ((uint)(10u));
            this.mun1_insTxtBox.Location = new System.Drawing.Point(58, 100);
            this.mun1_insTxtBox.Name = "mun1_insTxtBox";
            this.mun1_insTxtBox.Size = new System.Drawing.Size(182, 40);
            this.mun1_insTxtBox.TabIndex = 4;
            this.mun1_insTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // mun2_insTxtBox
            // 
            this.mun2_insTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.mun2_insTxtBox.BorderColor = System.Drawing.Color.Gray;
            this.mun2_insTxtBox.LeftRightPadding = ((uint)(10u));
            this.mun2_insTxtBox.Location = new System.Drawing.Point(58, 265);
            this.mun2_insTxtBox.Name = "mun2_insTxtBox";
            this.mun2_insTxtBox.Size = new System.Drawing.Size(182, 40);
            this.mun2_insTxtBox.TabIndex = 8;
            this.mun2_insTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 553);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mun3_resLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mun3_insTxtBox);
            this.Controls.Add(this.mun2_resLabel);
            this.Controls.Add(this.mun1_resLabel);
            this.Controls.Add(this.mun1_insTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mun2_insTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_mun3);
            this.Controls.Add(this.label_mun2);
            this.Controls.Add(this.label_mun1);
            this.Font = new System.Drawing.Font("굴림", 11F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_mun1;
        private System.Windows.Forms.Label label_mun2;
        private System.Windows.Forms.Label label_mun3;
        private VerticalTextBox mun1_insTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private VerticalTextBox mun2_insTxtBox;
        private System.Windows.Forms.Label mun2_resLabel;
        private System.Windows.Forms.Label mun1_resLabel;
        private System.Windows.Forms.Label mun3_resLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private VerticalTextBox mun3_insTxtBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
    }
}

