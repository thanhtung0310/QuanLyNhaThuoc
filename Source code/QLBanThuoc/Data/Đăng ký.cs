using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanThuoc.Data
{
    public partial class Đăng_ký : Form
    {
        public Đăng_ký()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            XtraForm1 DangNhap = new XtraForm1();
            DangNhap.Show();
            this.Hide();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            QL_SR.QLBanThuocServiceSoapClient qlClient = new QL_SR.QLBanThuocServiceSoapClient();

            string TenDangNhap = txbTenDangNhap.Text;
            string MatKhau = txbMatKhau.Text;
            string kiemtra = txbMatKhau2.Text;
            
            if (kiemtra != MatKhau)
            {
                MessageBox.Show("Vui lòng kiểm tra lại mật khẩu.", "Thông báo");
            }
            else
            {
                qlClient.DangKy(TenDangNhap, MatKhau);

                //Đăng ký thành công
                MessageBox.Show("Đăng ký thành công.", "Thông báo.");
                XtraForm1 DangNhap = new XtraForm1();
                DangNhap.Show();
                this.Hide();
            }
        }

        private void Đăng_ký_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận thoát khỏi phần mềm?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("cmd.exe", "/c taskkill /F /IM QuanLyKho-TT.exe");
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
