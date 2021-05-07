
namespace ComprehensiveCarManager
{
    partial class ManagerParkingCar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_exitCar = new System.Windows.Forms.Button();
            this.button_park = new System.Windows.Forms.Button();
            this.textBox_phoneNumber = new System.Windows.Forms.TextBox();
            this.textBox_driverName = new System.Windows.Forms.TextBox();
            this.textBox_carNumber = new System.Windows.Forms.TextBox();
            this.textBox_parkingSpot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_AllLookUp = new System.Windows.Forms.Button();
            this.textBox_selectedParkingSpot = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_showCar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_ManageParkingCar = new System.Windows.Forms.DataGridView();
            this.listBox_History = new System.Windows.Forms.ListBox();
            this.statusStrip_timer = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStringLabel_Timer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer_countTime = new System.Windows.Forms.Timer(this.components);
            this.parkingSpotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ManageParkingCar)).BeginInit();
            this.statusStrip_timer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkingCarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_exitCar);
            this.groupBox1.Controls.Add(this.button_park);
            this.groupBox1.Controls.Add(this.textBox_phoneNumber);
            this.groupBox1.Controls.Add(this.textBox_driverName);
            this.groupBox1.Controls.Add(this.textBox_carNumber);
            this.groupBox1.Controls.Add(this.textBox_parkingSpot);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 141);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "주차출차";
            // 
            // button_exitCar
            // 
            this.button_exitCar.Location = new System.Drawing.Point(158, 50);
            this.button_exitCar.Name = "button_exitCar";
            this.button_exitCar.Size = new System.Drawing.Size(75, 23);
            this.button_exitCar.TabIndex = 9;
            this.button_exitCar.Text = "출차";
            this.button_exitCar.UseVisualStyleBackColor = true;
            this.button_exitCar.Click += new System.EventHandler(this.button_exitCar_Click);
            // 
            // button_park
            // 
            this.button_park.Location = new System.Drawing.Point(158, 16);
            this.button_park.Name = "button_park";
            this.button_park.Size = new System.Drawing.Size(75, 23);
            this.button_park.TabIndex = 8;
            this.button_park.Text = "주차";
            this.button_park.UseVisualStyleBackColor = true;
            this.button_park.Click += new System.EventHandler(this.button_park_Click);
            // 
            // textBox_phoneNumber
            // 
            this.textBox_phoneNumber.Location = new System.Drawing.Point(77, 104);
            this.textBox_phoneNumber.Name = "textBox_phoneNumber";
            this.textBox_phoneNumber.Size = new System.Drawing.Size(75, 21);
            this.textBox_phoneNumber.TabIndex = 7;
            // 
            // textBox_driverName
            // 
            this.textBox_driverName.Location = new System.Drawing.Point(77, 77);
            this.textBox_driverName.Name = "textBox_driverName";
            this.textBox_driverName.Size = new System.Drawing.Size(75, 21);
            this.textBox_driverName.TabIndex = 6;
            // 
            // textBox_carNumber
            // 
            this.textBox_carNumber.Location = new System.Drawing.Point(77, 47);
            this.textBox_carNumber.Name = "textBox_carNumber";
            this.textBox_carNumber.Size = new System.Drawing.Size(75, 21);
            this.textBox_carNumber.TabIndex = 5;
            // 
            // textBox_parkingSpot
            // 
            this.textBox_parkingSpot.Location = new System.Drawing.Point(77, 14);
            this.textBox_parkingSpot.Name = "textBox_parkingSpot";
            this.textBox_parkingSpot.Size = new System.Drawing.Size(75, 21);
            this.textBox_parkingSpot.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "전화번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "차주이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "차량번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "공간번호";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_selectedParkingSpot);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button_AllLookUp);
            this.groupBox2.Controls.Add(this.button_showCar);
            this.groupBox2.Location = new System.Drawing.Point(267, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 84);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "주차 공간 조회";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(267, 117);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(331, 23);
            this.button_add.TabIndex = 13;
            this.button_add.Text = "주차 공간 추가";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_AllLookUp
            // 
            this.button_AllLookUp.Location = new System.Drawing.Point(160, 47);
            this.button_AllLookUp.Name = "button_AllLookUp";
            this.button_AllLookUp.Size = new System.Drawing.Size(165, 23);
            this.button_AllLookUp.TabIndex = 12;
            this.button_AllLookUp.Text = "전체 조회";
            this.button_AllLookUp.UseVisualStyleBackColor = true;
            this.button_AllLookUp.Click += new System.EventHandler(this.button_AllLookUp_Click);
            // 
            // textBox_selectedParkingSpot
            // 
            this.textBox_selectedParkingSpot.Location = new System.Drawing.Point(68, 18);
            this.textBox_selectedParkingSpot.Name = "textBox_selectedParkingSpot";
            this.textBox_selectedParkingSpot.Size = new System.Drawing.Size(86, 21);
            this.textBox_selectedParkingSpot.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "공간번호";
            // 
            // button_showCar
            // 
            this.button_showCar.Location = new System.Drawing.Point(160, 18);
            this.button_showCar.Name = "button_showCar";
            this.button_showCar.Size = new System.Drawing.Size(165, 23);
            this.button_showCar.TabIndex = 9;
            this.button_showCar.Text = "해당 구역 조회";
            this.button_showCar.UseVisualStyleBackColor = true;
            this.button_showCar.Click += new System.EventHandler(this.button_showCar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView_ManageParkingCar);
            this.groupBox3.Location = new System.Drawing.Point(9, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(874, 191);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "주차 현황";
            // 
            // dataGridView_ManageParkingCar
            // 
            this.dataGridView_ManageParkingCar.AllowUserToAddRows = false;
            this.dataGridView_ManageParkingCar.AllowUserToDeleteRows = false;
            this.dataGridView_ManageParkingCar.AutoGenerateColumns = false;
            this.dataGridView_ManageParkingCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ManageParkingCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parkingSpotDataGridViewTextBoxColumn,
            this.carNumberDataGridViewTextBoxColumn,
            this.driverNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.parkingTimeDataGridViewTextBoxColumn});
            this.dataGridView_ManageParkingCar.DataSource = this.parkingCarBindingSource;
            this.dataGridView_ManageParkingCar.Location = new System.Drawing.Point(9, 20);
            this.dataGridView_ManageParkingCar.Name = "dataGridView_ManageParkingCar";
            this.dataGridView_ManageParkingCar.ReadOnly = true;
            this.dataGridView_ManageParkingCar.RowHeadersWidth = 62;
            this.dataGridView_ManageParkingCar.RowTemplate.Height = 23;
            this.dataGridView_ManageParkingCar.Size = new System.Drawing.Size(831, 165);
            this.dataGridView_ManageParkingCar.TabIndex = 12;
            this.dataGridView_ManageParkingCar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ManageParkingCar_CellClick);
            // 
            // listBox_History
            // 
            this.listBox_History.FormattingEnabled = true;
            this.listBox_History.ItemHeight = 12;
            this.listBox_History.Location = new System.Drawing.Point(18, 362);
            this.listBox_History.Name = "listBox_History";
            this.listBox_History.Size = new System.Drawing.Size(866, 76);
            this.listBox_History.TabIndex = 12;
            // 
            // statusStrip_timer
            // 
            this.statusStrip_timer.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip_timer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusStringLabel_Timer,
            this.toolStripStatusLabel3});
            this.statusStrip_timer.Location = new System.Drawing.Point(0, 454);
            this.statusStrip_timer.Name = "statusStrip_timer";
            this.statusStrip_timer.Size = new System.Drawing.Size(963, 22);
            this.statusStrip_timer.TabIndex = 13;
            this.statusStrip_timer.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStringLabel_Timer
            // 
            this.statusStringLabel_Timer.Name = "statusStringLabel_Timer";
            this.statusStringLabel_Timer.Size = new System.Drawing.Size(12, 17);
            this.statusStringLabel_Timer.Text = "-";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // timer_countTime
            // 
            this.timer_countTime.Enabled = true;
            this.timer_countTime.Interval = 1000;
            this.timer_countTime.Tick += new System.EventHandler(this.timer_countTime_Tick);
            // 
            // parkingSpotDataGridViewTextBoxColumn
            // 
            this.parkingSpotDataGridViewTextBoxColumn.DataPropertyName = "parkingSpot";
            this.parkingSpotDataGridViewTextBoxColumn.HeaderText = "공간번호";
            this.parkingSpotDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.parkingSpotDataGridViewTextBoxColumn.Name = "parkingSpotDataGridViewTextBoxColumn";
            this.parkingSpotDataGridViewTextBoxColumn.ReadOnly = true;
            this.parkingSpotDataGridViewTextBoxColumn.Width = 150;
            // 
            // carNumberDataGridViewTextBoxColumn
            // 
            this.carNumberDataGridViewTextBoxColumn.DataPropertyName = "carNumber";
            this.carNumberDataGridViewTextBoxColumn.HeaderText = "차번호";
            this.carNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.carNumberDataGridViewTextBoxColumn.Name = "carNumberDataGridViewTextBoxColumn";
            this.carNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.carNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // driverNameDataGridViewTextBoxColumn
            // 
            this.driverNameDataGridViewTextBoxColumn.DataPropertyName = "driverName";
            this.driverNameDataGridViewTextBoxColumn.HeaderText = "운전자명";
            this.driverNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.driverNameDataGridViewTextBoxColumn.Name = "driverNameDataGridViewTextBoxColumn";
            this.driverNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.driverNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "phoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "전화번호";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // parkingTimeDataGridViewTextBoxColumn
            // 
            this.parkingTimeDataGridViewTextBoxColumn.DataPropertyName = "parkingTime";
            this.parkingTimeDataGridViewTextBoxColumn.HeaderText = "주출차시간";
            this.parkingTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.parkingTimeDataGridViewTextBoxColumn.Name = "parkingTimeDataGridViewTextBoxColumn";
            this.parkingTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.parkingTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // parkingCarBindingSource
            // 
            this.parkingCarBindingSource.DataSource = typeof(ComprehensiveCarManager.ParkingCar);
            // 
            // ManagerParkingCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 476);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.statusStrip_timer);
            this.Controls.Add(this.listBox_History);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManagerParkingCar";
            this.Text = "주차 관리 프로그램";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ManageParkingCar)).EndInit();
            this.statusStrip_timer.ResumeLayout(false);
            this.statusStrip_timer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkingCarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_exitCar;
        private System.Windows.Forms.Button button_park;
        private System.Windows.Forms.TextBox textBox_phoneNumber;
        private System.Windows.Forms.TextBox textBox_driverName;
        private System.Windows.Forms.TextBox textBox_carNumber;
        private System.Windows.Forms.TextBox textBox_parkingSpot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_selectedParkingSpot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_showCar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView_ManageParkingCar;
        private System.Windows.Forms.ListBox listBox_History;
        private System.Windows.Forms.StatusStrip statusStrip_timer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusStringLabel_Timer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer_countTime;
        private System.Windows.Forms.BindingSource parkingCarBindingSource;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_AllLookUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingSpotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingTimeDataGridViewTextBoxColumn;
    }
}

