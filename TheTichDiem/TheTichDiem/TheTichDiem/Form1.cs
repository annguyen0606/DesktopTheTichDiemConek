using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheTichDiem
{
    public partial class Form1 : Form
    {
        string UIDTAG = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cbComPort.Items.AddRange(ports);
            cbComPort.SelectedIndex = -1;
            if(cbComPort.Items.Count < 0)
            {
                MessageBox.Show("Bạn chưa cắm thiết bị, Kiểm tra lại","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void BtnConnectComport_Click(object sender, EventArgs e)
        {
            if (cbComPort.Items.Count < 0)
            {
                MessageBox.Show("Bạn chưa cắm thiết bị, Kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            serialPort1.PortName = cbComPort.Text;
            serialPort1.BaudRate = 115200;
            if (serialPort1.IsOpen)
            {
                MessageBox.Show("Bạn đã mở cổng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            serialPort1.Open();
            progressBar1.Value = 100;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            UIDTAG = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(GetUIDTAG));
        }

        private void GetUIDTAG(object sender, EventArgs e)
        {
            txbUIDTAG.Text = UIDTAG;
        }

        private void BtnTimKiemKH_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbUIDTAG.Text))
            {
                MessageBox.Show("Bạn chưa chạm thẻ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Select UID, HoTen as 'Họ tên', DiaChi as 'Địa chỉ', Phone as 'SĐT', TichDiem as 'Điểm tích' from dbo.TheTichDiemSpa where UID = @uid";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@uid", txbUIDTAG.Text.ToString().Trim());

            DataTable duLieuKhachHang = Class.database.getData(cmd);
            if(duLieuKhachHang.Rows.Count < 1)
            {
                MessageBox.Show("Khách hàng chưa đăng ký thẻ, kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgvDanhSachKhachHang.DataSource = duLieuKhachHang;
            txbNameCustomer.Text = duLieuKhachHang.Rows[0]["Họ tên"].ToString();
            txbAddressCustomer.Text = duLieuKhachHang.Rows[0]["Địa chỉ"].ToString();
            txbPhoneCustomer.Text = duLieuKhachHang.Rows[0]["SĐT"].ToString();
            lbDiemCurrent.Text = duLieuKhachHang.Rows[0]["Điểm tích"].ToString();
            lbTongSoKh.Text = (dgvDanhSachKhachHang.Rows.Count - 1).ToString();
        }

        private void TxbPricePay_TextChanged(object sender, EventArgs e)
        {
            txbDiemCong.Text = (Int32.Parse(txbPricePay.Text.ToString().Trim()) / Int32.Parse(txbConvertRate.Text.ToString().Trim())).ToString();
        }

        private void BtnTichDiem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbUIDTAG.Text))
            {
                MessageBox.Show("Bạn chưa chạm thẻ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE dbo.TheTichDiemSpa SET HoTen = @hoten, DiaChi = @diachi, Phone = @dienthoai, TichDiem = @tichdiem where UID = @uid";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@hoten", txbNameCustomer.Text);
            cmd.Parameters.AddWithValue("@diachi", txbAddressCustomer.Text);
            cmd.Parameters.AddWithValue("@dienthoai", txbPhoneCustomer.Text);
            cmd.Parameters.AddWithValue("@tichdiem", int.Parse(txbDiemCong.Text.ToString()) + int.Parse(lbDiemCurrent.Text));
            cmd.Parameters.AddWithValue("@uid", txbUIDTAG.Text);

            if(Class.database.ExcuteNonQuery(cmd) > 0)
            {
                MessageBox.Show("Tích điểm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFrom();
            }
            else
            {
                MessageBox.Show("Tích điểm thất bại, kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void ClearFrom()
        {
            txbAddressCustomer.Text = "";
            txbDiemCong.Text = "";
            txbNameCustomer.Text = "";
            txbPhoneCustomer.Text = "";
            txbPricePay.Text = "0";
            txbUIDTAG.Text = "";
            txbConvertRate.Text = "1000";
            lbDiemCurrent.Text = "0";
        }

        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbUIDTAG.Text))
            {
                MessageBox.Show("Bạn chưa chạm thẻ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Select *from dbo.TheTichDiemSpa where UID = @uid";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@uid", txbUIDTAG.Text);
            DataTable layThongTinKH = Class.database.getData(cmd);
            if(layThongTinKH.Rows.Count > 0)
            {
                MessageBox.Show("Thẻ đã được đăng ký, kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cmd.CommandText = @"Insert into dbo.TheTichDiemSpa(UID,HoTen,DiaChi,Phone,TichDiem) values (@uid,@hoten,@diachi,@phone,@tichdiem) select @@Identity";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@uid", txbUIDTAG.Text);
            cmd.Parameters.AddWithValue("@hoten", txbNameCustomer.Text);
            cmd.Parameters.AddWithValue("@diachi", txbAddressCustomer.Text);
            cmd.Parameters.AddWithValue("@phone", txbPhoneCustomer.Text);
            cmd.Parameters.AddWithValue("@tichdiem", int.Parse(txbDiemCong.Text.ToString()));
            //MessageBox.Show(Class.database.ExecuteScalar(cmd));
            if(Int32.Parse(Class.database.ExecuteScalar(cmd).ToString()) > 0)
            {
                MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFrom();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void BtnTimTatCa_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Select *from dbo.TheTichDiemSpa";
            cmd.Parameters.Clear();
            DataTable DanhSachKH = Class.database.getData(cmd);
            if(DanhSachKH.Rows.Count < 1)
            {
                return;
            }
            dgvDanhSachKhachHang.DataSource = DanhSachKH;
            lbTongSoKh.Text = (dgvDanhSachKhachHang.Rows.Count - 1).ToString();
        }
    }
}
