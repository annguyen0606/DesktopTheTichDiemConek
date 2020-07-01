namespace TheTichDiem
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnectComport = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txbUIDTAG = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNameCustomer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbAddressCustomer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbPhoneCustomer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbPricePay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbConvertRate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbDiemCong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbDiemCurrent = new System.Windows.Forms.Label();
            this.btnTimKiemKH = new System.Windows.Forms.Button();
            this.btnTichDiem = new System.Windows.Forms.Button();
            this.btnTimTatCa = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTongSoKh = new System.Windows.Forms.Label();
            this.dgvDanhSachKhachHang = new System.Windows.Forms.DataGridView();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnRegistration = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // cbComPort
            // 
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(44, 16);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(121, 21);
            this.cbComPort.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.btnConnectComport);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbComPort);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 108);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điều khiển";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cổng";
            // 
            // btnConnectComport
            // 
            this.btnConnectComport.Location = new System.Drawing.Point(9, 43);
            this.btnConnectComport.Name = "btnConnectComport";
            this.btnConnectComport.Size = new System.Drawing.Size(156, 23);
            this.btnConnectComport.TabIndex = 2;
            this.btnConnectComport.Text = "Kết nối";
            this.btnConnectComport.UseVisualStyleBackColor = true;
            this.btnConnectComport.Click += new System.EventHandler(this.BtnConnectComport_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 72);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(156, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // txbUIDTAG
            // 
            this.txbUIDTAG.Location = new System.Drawing.Point(52, 17);
            this.txbUIDTAG.Name = "txbUIDTAG";
            this.txbUIDTAG.Size = new System.Drawing.Size(128, 20);
            this.txbUIDTAG.TabIndex = 2;
            this.txbUIDTAG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRegistration);
            this.groupBox2.Controls.Add(this.btnTimTatCa);
            this.groupBox2.Controls.Add(this.btnTichDiem);
            this.groupBox2.Controls.Add(this.btnTimKiemKH);
            this.groupBox2.Controls.Add(this.lbDiemCurrent);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txbDiemCong);
            this.groupBox2.Controls.Add(this.txbConvertRate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txbPricePay);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txbPhoneCustomer);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txbAddressCustomer);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txbNameCustomer);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txbUIDTAG);
            this.groupBox2.Location = new System.Drawing.Point(194, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 108);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã thẻ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Họ tên";
            // 
            // txbNameCustomer
            // 
            this.txbNameCustomer.Location = new System.Drawing.Point(51, 43);
            this.txbNameCustomer.Name = "txbNameCustomer";
            this.txbNameCustomer.Size = new System.Drawing.Size(129, 20);
            this.txbNameCustomer.TabIndex = 3;
            this.txbNameCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa chỉ";
            // 
            // txbAddressCustomer
            // 
            this.txbAddressCustomer.Location = new System.Drawing.Point(51, 69);
            this.txbAddressCustomer.Name = "txbAddressCustomer";
            this.txbAddressCustomer.Size = new System.Drawing.Size(129, 20);
            this.txbAddressCustomer.TabIndex = 4;
            this.txbAddressCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone";
            // 
            // txbPhoneCustomer
            // 
            this.txbPhoneCustomer.Location = new System.Drawing.Point(231, 17);
            this.txbPhoneCustomer.Name = "txbPhoneCustomer";
            this.txbPhoneCustomer.Size = new System.Drawing.Size(129, 20);
            this.txbPhoneCustomer.TabIndex = 5;
            this.txbPhoneCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số tiền";
            // 
            // txbPricePay
            // 
            this.txbPricePay.Location = new System.Drawing.Point(231, 43);
            this.txbPricePay.Name = "txbPricePay";
            this.txbPricePay.Size = new System.Drawing.Size(129, 20);
            this.txbPricePay.TabIndex = 6;
            this.txbPricePay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbPricePay.TextChanged += new System.EventHandler(this.TxbPricePay_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tỉ lệ";
            // 
            // txbConvertRate
            // 
            this.txbConvertRate.Location = new System.Drawing.Point(231, 69);
            this.txbConvertRate.Name = "txbConvertRate";
            this.txbConvertRate.ReadOnly = true;
            this.txbConvertRate.Size = new System.Drawing.Size(129, 20);
            this.txbConvertRate.TabIndex = 0;
            this.txbConvertRate.Text = "1000";
            this.txbConvertRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Điểm cộng";
            // 
            // txbDiemCong
            // 
            this.txbDiemCong.Location = new System.Drawing.Point(426, 15);
            this.txbDiemCong.Name = "txbDiemCong";
            this.txbDiemCong.ReadOnly = true;
            this.txbDiemCong.Size = new System.Drawing.Size(100, 20);
            this.txbDiemCong.TabIndex = 0;
            this.txbDiemCong.Text = "0";
            this.txbDiemCong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(367, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Số điểm hiện tại: ";
            // 
            // lbDiemCurrent
            // 
            this.lbDiemCurrent.AutoSize = true;
            this.lbDiemCurrent.Location = new System.Drawing.Point(456, 46);
            this.lbDiemCurrent.Name = "lbDiemCurrent";
            this.lbDiemCurrent.Size = new System.Drawing.Size(13, 13);
            this.lbDiemCurrent.TabIndex = 7;
            this.lbDiemCurrent.Text = "0";
            // 
            // btnTimKiemKH
            // 
            this.btnTimKiemKH.Location = new System.Drawing.Point(370, 66);
            this.btnTimKiemKH.Name = "btnTimKiemKH";
            this.btnTimKiemKH.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemKH.TabIndex = 7;
            this.btnTimKiemKH.Text = "Tìm kiếm";
            this.btnTimKiemKH.UseVisualStyleBackColor = true;
            this.btnTimKiemKH.Click += new System.EventHandler(this.BtnTimKiemKH_Click);
            // 
            // btnTichDiem
            // 
            this.btnTichDiem.Location = new System.Drawing.Point(451, 66);
            this.btnTichDiem.Name = "btnTichDiem";
            this.btnTichDiem.Size = new System.Drawing.Size(75, 23);
            this.btnTichDiem.TabIndex = 8;
            this.btnTichDiem.Text = "Tích điểm";
            this.btnTichDiem.UseVisualStyleBackColor = true;
            this.btnTichDiem.Click += new System.EventHandler(this.BtnTichDiem_Click);
            // 
            // btnTimTatCa
            // 
            this.btnTimTatCa.Location = new System.Drawing.Point(531, 66);
            this.btnTimTatCa.Name = "btnTimTatCa";
            this.btnTimTatCa.Size = new System.Drawing.Size(75, 23);
            this.btnTimTatCa.TabIndex = 9;
            this.btnTimTatCa.Text = "Tìm tất";
            this.btnTimTatCa.UseVisualStyleBackColor = true;
            this.btnTimTatCa.Click += new System.EventHandler(this.BtnTimTatCa_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Tổng số khách hàng:";
            // 
            // lbTongSoKh
            // 
            this.lbTongSoKh.AutoSize = true;
            this.lbTongSoKh.Location = new System.Drawing.Point(123, 124);
            this.lbTongSoKh.Name = "lbTongSoKh";
            this.lbTongSoKh.Size = new System.Drawing.Size(13, 13);
            this.lbTongSoKh.TabIndex = 5;
            this.lbTongSoKh.Text = "0";
            // 
            // dgvDanhSachKhachHang
            // 
            this.dgvDanhSachKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachKhachHang.Location = new System.Drawing.Point(12, 140);
            this.dgvDanhSachKhachHang.Name = "dgvDanhSachKhachHang";
            this.dgvDanhSachKhachHang.ReadOnly = true;
            this.dgvDanhSachKhachHang.Size = new System.Drawing.Size(788, 354);
            this.dgvDanhSachKhachHang.TabIndex = 6;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(531, 14);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(74, 45);
            this.btnRegistration.TabIndex = 10;
            this.btnRegistration.Text = "Đăng ký";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.BtnRegistration_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 506);
            this.Controls.Add(this.dgvDanhSachKhachHang);
            this.Controls.Add(this.lbTongSoKh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Thẻ tích điểm Conek";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnConnectComport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbUIDTAG;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimTatCa;
        private System.Windows.Forms.Button btnTichDiem;
        private System.Windows.Forms.Button btnTimKiemKH;
        private System.Windows.Forms.Label lbDiemCurrent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbDiemCong;
        private System.Windows.Forms.TextBox txbConvertRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbPricePay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbPhoneCustomer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbAddressCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNameCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbTongSoKh;
        private System.Windows.Forms.DataGridView dgvDanhSachKhachHang;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnRegistration;
    }
}

