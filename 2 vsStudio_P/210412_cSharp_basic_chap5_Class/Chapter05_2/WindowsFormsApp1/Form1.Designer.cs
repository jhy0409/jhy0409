
namespace WindowsFormsApp1
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
            this.ok_btn1 = new System.Windows.Forms.Button();
            this.munTxt_1 = new System.Windows.Forms.Label();
            this.munTxt_2 = new System.Windows.Forms.Label();
            this.myRCP = new System.Windows.Forms.Label();
            this.btn_m2_gawi = new System.Windows.Forms.Button();
            this.btn_m2_bawi = new System.Windows.Forms.Button();
            this.btn_m2_bo = new System.Windows.Forms.Button();
            this.cmpter = new System.Windows.Forms.Label();
            this.btn_m2_Combo = new System.Windows.Forms.Button();
            this.btn_m2_Combawi = new System.Windows.Forms.Button();
            this.btn_m2_Comgawi = new System.Windows.Forms.Button();
            this.whoWin = new System.Windows.Forms.Label();
            this.rcpResult = new System.Windows.Forms.Label();
            this.munTxt_4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.viewList_lb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addString_11 = new System.Windows.Forms.Button();
            this.addString_22 = new System.Windows.Forms.Button();
            this.addString_33 = new System.Windows.Forms.Button();
            this.addLabel = new System.Windows.Forms.Label();
            this.delLabel = new System.Windows.Forms.Label();
            this.delString_33 = new System.Windows.Forms.Button();
            this.delString_22 = new System.Windows.Forms.Button();
            this.delString_11 = new System.Windows.Forms.Button();
            this.viewList = new System.Windows.Forms.Label();
            this.ansMun1 = new VerticalTextBox();
            this.munTxt_3 = new System.Windows.Forms.Label();
            this.ok_btn3 = new System.Windows.Forms.Button();
            this.viewList3 = new System.Windows.Forms.Label();
            this.viewList_lb3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ok_btn1
            // 
            this.ok_btn1.Location = new System.Drawing.Point(170, 95);
            this.ok_btn1.Name = "ok_btn1";
            this.ok_btn1.Size = new System.Drawing.Size(62, 33);
            this.ok_btn1.TabIndex = 4;
            this.ok_btn1.Text = "확인";
            this.ok_btn1.UseVisualStyleBackColor = true;
            this.ok_btn1.Click += new System.EventHandler(this.ok_btn1_Click);
            // 
            // munTxt_1
            // 
            this.munTxt_1.AutoSize = true;
            this.munTxt_1.Location = new System.Drawing.Point(36, 32);
            this.munTxt_1.Name = "munTxt_1";
            this.munTxt_1.Size = new System.Drawing.Size(161, 45);
            this.munTxt_1.TabIndex = 3;
            this.munTxt_1.Text = "문제 1. \r\nRandom 함수를 이용한\r\n숫자 맞추기 프로그램";
            // 
            // munTxt_2
            // 
            this.munTxt_2.AutoSize = true;
            this.munTxt_2.Location = new System.Drawing.Point(36, 186);
            this.munTxt_2.Name = "munTxt_2";
            this.munTxt_2.Size = new System.Drawing.Size(166, 45);
            this.munTxt_2.TabIndex = 6;
            this.munTxt_2.Text = "문제 2. \r\nRandom 함수를 이용한 \r\n가위 바위 보 게임";
            // 
            // myRCP
            // 
            this.myRCP.AutoSize = true;
            this.myRCP.Location = new System.Drawing.Point(36, 255);
            this.myRCP.Name = "myRCP";
            this.myRCP.Size = new System.Drawing.Size(22, 15);
            this.myRCP.TabIndex = 7;
            this.myRCP.Text = "나";
            // 
            // btn_m2_gawi
            // 
            this.btn_m2_gawi.Location = new System.Drawing.Point(36, 277);
            this.btn_m2_gawi.Name = "btn_m2_gawi";
            this.btn_m2_gawi.Size = new System.Drawing.Size(62, 33);
            this.btn_m2_gawi.TabIndex = 8;
            this.btn_m2_gawi.Text = "가위";
            this.btn_m2_gawi.UseVisualStyleBackColor = true;
            this.btn_m2_gawi.Click += new System.EventHandler(this.btn_m2_gawi_Click);
            // 
            // btn_m2_bawi
            // 
            this.btn_m2_bawi.Location = new System.Drawing.Point(104, 277);
            this.btn_m2_bawi.Name = "btn_m2_bawi";
            this.btn_m2_bawi.Size = new System.Drawing.Size(62, 33);
            this.btn_m2_bawi.TabIndex = 9;
            this.btn_m2_bawi.Text = "바위";
            this.btn_m2_bawi.UseVisualStyleBackColor = true;
            this.btn_m2_bawi.Click += new System.EventHandler(this.btn_m2_bawi_Click);
            // 
            // btn_m2_bo
            // 
            this.btn_m2_bo.Location = new System.Drawing.Point(172, 277);
            this.btn_m2_bo.Name = "btn_m2_bo";
            this.btn_m2_bo.Size = new System.Drawing.Size(62, 33);
            this.btn_m2_bo.TabIndex = 10;
            this.btn_m2_bo.Text = "보";
            this.btn_m2_bo.UseVisualStyleBackColor = true;
            this.btn_m2_bo.Click += new System.EventHandler(this.btn_m2_bo_Click);
            // 
            // cmpter
            // 
            this.cmpter.AutoSize = true;
            this.cmpter.Location = new System.Drawing.Point(36, 326);
            this.cmpter.Name = "cmpter";
            this.cmpter.Size = new System.Drawing.Size(52, 15);
            this.cmpter.TabIndex = 11;
            this.cmpter.Text = "컴퓨터";
            // 
            // btn_m2_Combo
            // 
            this.btn_m2_Combo.Location = new System.Drawing.Point(172, 348);
            this.btn_m2_Combo.Name = "btn_m2_Combo";
            this.btn_m2_Combo.Size = new System.Drawing.Size(62, 33);
            this.btn_m2_Combo.TabIndex = 14;
            this.btn_m2_Combo.Text = "보";
            this.btn_m2_Combo.UseVisualStyleBackColor = true;
            // 
            // btn_m2_Combawi
            // 
            this.btn_m2_Combawi.Location = new System.Drawing.Point(104, 348);
            this.btn_m2_Combawi.Name = "btn_m2_Combawi";
            this.btn_m2_Combawi.Size = new System.Drawing.Size(62, 33);
            this.btn_m2_Combawi.TabIndex = 13;
            this.btn_m2_Combawi.Text = "바위";
            this.btn_m2_Combawi.UseVisualStyleBackColor = true;
            // 
            // btn_m2_Comgawi
            // 
            this.btn_m2_Comgawi.Location = new System.Drawing.Point(36, 348);
            this.btn_m2_Comgawi.Name = "btn_m2_Comgawi";
            this.btn_m2_Comgawi.Size = new System.Drawing.Size(62, 33);
            this.btn_m2_Comgawi.TabIndex = 12;
            this.btn_m2_Comgawi.Text = "가위";
            this.btn_m2_Comgawi.UseVisualStyleBackColor = true;
            // 
            // whoWin
            // 
            this.whoWin.AutoSize = true;
            this.whoWin.Location = new System.Drawing.Point(36, 404);
            this.whoWin.Name = "whoWin";
            this.whoWin.Size = new System.Drawing.Size(37, 15);
            this.whoWin.TabIndex = 15;
            this.whoWin.Text = "결과";
            // 
            // rcpResult
            // 
            this.rcpResult.AutoSize = true;
            this.rcpResult.Location = new System.Drawing.Point(36, 430);
            this.rcpResult.Name = "rcpResult";
            this.rcpResult.Size = new System.Drawing.Size(139, 15);
            this.rcpResult.TabIndex = 16;
            this.rcpResult.Text = "[ - ]가 이겼습니다.";
            // 
            // munTxt_4
            // 
            this.munTxt_4.AutoSize = true;
            this.munTxt_4.Location = new System.Drawing.Point(542, 32);
            this.munTxt_4.Name = "munTxt_4";
            this.munTxt_4.Size = new System.Drawing.Size(210, 60);
            this.munTxt_4.TabIndex = 17;
            this.munTxt_4.Text = "문제 4. \r\nlist에 임의의 문장들을 만들고 \r\nRandom 함수를 이용하여 \r\n임의의 문장을 출력";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "결과";
            // 
            // viewList_lb
            // 
            this.viewList_lb.AutoSize = true;
            this.viewList_lb.Location = new System.Drawing.Point(543, 125);
            this.viewList_lb.Name = "viewList_lb";
            this.viewList_lb.Size = new System.Drawing.Size(52, 15);
            this.viewList_lb.TabIndex = 19;
            this.viewList_lb.Text = "리스트";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "결과";
            // 
            // addString_11
            // 
            this.addString_11.Location = new System.Drawing.Point(546, 266);
            this.addString_11.Name = "addString_11";
            this.addString_11.Size = new System.Drawing.Size(62, 33);
            this.addString_11.TabIndex = 21;
            this.addString_11.Text = "11";
            this.addString_11.UseVisualStyleBackColor = true;
            this.addString_11.Click += new System.EventHandler(this.addString_11_Click);
            // 
            // addString_22
            // 
            this.addString_22.Location = new System.Drawing.Point(614, 266);
            this.addString_22.Name = "addString_22";
            this.addString_22.Size = new System.Drawing.Size(62, 33);
            this.addString_22.TabIndex = 22;
            this.addString_22.Text = "22";
            this.addString_22.UseVisualStyleBackColor = true;
            this.addString_22.Click += new System.EventHandler(this.addString_22_Click);
            // 
            // addString_33
            // 
            this.addString_33.Location = new System.Drawing.Point(682, 266);
            this.addString_33.Name = "addString_33";
            this.addString_33.Size = new System.Drawing.Size(62, 33);
            this.addString_33.TabIndex = 23;
            this.addString_33.Text = "33";
            this.addString_33.UseVisualStyleBackColor = true;
            this.addString_33.Click += new System.EventHandler(this.addString_33_Click);
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Location = new System.Drawing.Point(543, 239);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(37, 15);
            this.addLabel.TabIndex = 24;
            this.addLabel.Text = "추가";
            // 
            // delLabel
            // 
            this.delLabel.AutoSize = true;
            this.delLabel.Location = new System.Drawing.Point(543, 321);
            this.delLabel.Name = "delLabel";
            this.delLabel.Size = new System.Drawing.Size(37, 15);
            this.delLabel.TabIndex = 28;
            this.delLabel.Text = "삭제";
            // 
            // delString_33
            // 
            this.delString_33.Location = new System.Drawing.Point(682, 348);
            this.delString_33.Name = "delString_33";
            this.delString_33.Size = new System.Drawing.Size(62, 33);
            this.delString_33.TabIndex = 27;
            this.delString_33.Text = "33";
            this.delString_33.UseVisualStyleBackColor = true;
            this.delString_33.Click += new System.EventHandler(this.delString_33_Click);
            // 
            // delString_22
            // 
            this.delString_22.Location = new System.Drawing.Point(614, 348);
            this.delString_22.Name = "delString_22";
            this.delString_22.Size = new System.Drawing.Size(62, 33);
            this.delString_22.TabIndex = 26;
            this.delString_22.Text = "22";
            this.delString_22.UseVisualStyleBackColor = true;
            this.delString_22.Click += new System.EventHandler(this.delString_22_Click);
            // 
            // delString_11
            // 
            this.delString_11.Location = new System.Drawing.Point(546, 348);
            this.delString_11.Name = "delString_11";
            this.delString_11.Size = new System.Drawing.Size(62, 33);
            this.delString_11.TabIndex = 25;
            this.delString_11.Text = "11";
            this.delString_11.UseVisualStyleBackColor = true;
            this.delString_11.Click += new System.EventHandler(this.delString_11_Click);
            // 
            // viewList
            // 
            this.viewList.AutoSize = true;
            this.viewList.Location = new System.Drawing.Point(543, 153);
            this.viewList.MinimumSize = new System.Drawing.Size(200, 30);
            this.viewList.Name = "viewList";
            this.viewList.Size = new System.Drawing.Size(200, 30);
            this.viewList.TabIndex = 29;
            this.viewList.Text = "-";
            // 
            // ansMun1
            // 
            this.ansMun1.BackColor = System.Drawing.SystemColors.Window;
            this.ansMun1.BorderColor = System.Drawing.Color.Gray;
            this.ansMun1.LeftRightPadding = ((uint)(10u));
            this.ansMun1.Location = new System.Drawing.Point(36, 95);
            this.ansMun1.Name = "ansMun1";
            this.ansMun1.Size = new System.Drawing.Size(125, 33);
            this.ansMun1.TabIndex = 5;
            this.ansMun1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // munTxt_3
            // 
            this.munTxt_3.AutoSize = true;
            this.munTxt_3.Location = new System.Drawing.Point(289, 32);
            this.munTxt_3.Name = "munTxt_3";
            this.munTxt_3.Size = new System.Drawing.Size(195, 60);
            this.munTxt_3.TabIndex = 30;
            this.munTxt_3.Text = "문제3. \r\nlist에 임의의 문장을 만들고 \r\nRandom 함수를 이용하여 \r\n임의의 문장을 출력";
            // 
            // ok_btn3
            // 
            this.ok_btn3.Location = new System.Drawing.Point(292, 277);
            this.ok_btn3.Name = "ok_btn3";
            this.ok_btn3.Size = new System.Drawing.Size(62, 33);
            this.ok_btn3.TabIndex = 31;
            this.ok_btn3.Text = "확인";
            this.ok_btn3.UseVisualStyleBackColor = true;
            this.ok_btn3.Click += new System.EventHandler(this.ok_btn3_Click);
            // 
            // viewList3
            // 
            this.viewList3.AutoSize = true;
            this.viewList3.Location = new System.Drawing.Point(289, 153);
            this.viewList3.MinimumSize = new System.Drawing.Size(200, 30);
            this.viewList3.Name = "viewList3";
            this.viewList3.Size = new System.Drawing.Size(200, 30);
            this.viewList3.TabIndex = 33;
            this.viewList3.Text = "-";
            // 
            // viewList_lb3
            // 
            this.viewList_lb3.AutoSize = true;
            this.viewList_lb3.Location = new System.Drawing.Point(289, 125);
            this.viewList_lb3.Name = "viewList_lb3";
            this.viewList_lb3.Size = new System.Drawing.Size(52, 15);
            this.viewList_lb3.TabIndex = 32;
            this.viewList_lb3.Text = "리스트";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.viewList3);
            this.Controls.Add(this.viewList_lb3);
            this.Controls.Add(this.ok_btn3);
            this.Controls.Add(this.munTxt_3);
            this.Controls.Add(this.btn_m2_Combo);
            this.Controls.Add(this.btn_m2_bo);
            this.Controls.Add(this.munTxt_1);
            this.Controls.Add(this.viewList);
            this.Controls.Add(this.delLabel);
            this.Controls.Add(this.delString_33);
            this.Controls.Add(this.delString_22);
            this.Controls.Add(this.delString_11);
            this.Controls.Add(this.addLabel);
            this.Controls.Add(this.addString_33);
            this.Controls.Add(this.addString_22);
            this.Controls.Add(this.addString_11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.viewList_lb);
            this.Controls.Add(this.munTxt_2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.munTxt_4);
            this.Controls.Add(this.rcpResult);
            this.Controls.Add(this.whoWin);
            this.Controls.Add(this.btn_m2_Combawi);
            this.Controls.Add(this.btn_m2_Comgawi);
            this.Controls.Add(this.cmpter);
            this.Controls.Add(this.btn_m2_bawi);
            this.Controls.Add(this.btn_m2_gawi);
            this.Controls.Add(this.myRCP);
            this.Controls.Add(this.ansMun1);
            this.Controls.Add(this.ok_btn1);
            this.Font = new System.Drawing.Font("굴림", 11F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_btn1;
        private System.Windows.Forms.Label munTxt_1;
        private VerticalTextBox ansMun1;
        private System.Windows.Forms.Label munTxt_2;
        private System.Windows.Forms.Label myRCP;
        private System.Windows.Forms.Button btn_m2_gawi;
        private System.Windows.Forms.Button btn_m2_bawi;
        private System.Windows.Forms.Button btn_m2_bo;
        private System.Windows.Forms.Label cmpter;
        private System.Windows.Forms.Button btn_m2_Combo;
        private System.Windows.Forms.Button btn_m2_Combawi;
        private System.Windows.Forms.Button btn_m2_Comgawi;
        private System.Windows.Forms.Label whoWin;
        private System.Windows.Forms.Label rcpResult;
        private System.Windows.Forms.Label munTxt_4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label viewList_lb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addString_11;
        private System.Windows.Forms.Button addString_22;
        private System.Windows.Forms.Button addString_33;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.Label delLabel;
        private System.Windows.Forms.Button delString_33;
        private System.Windows.Forms.Button delString_22;
        private System.Windows.Forms.Button delString_11;
        private System.Windows.Forms.Label viewList;
        private System.Windows.Forms.Label munTxt_3;
        private System.Windows.Forms.Button ok_btn3;
        private System.Windows.Forms.Label viewList3;
        private System.Windows.Forms.Label viewList_lb3;
    }
}

