using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using QLBanThuoc.Data;
using System.Security.Cryptography;

namespace QLBanThuoc.Data
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        QL_SR.QLBanThuocServiceSoapClient client = new QL_SR.QLBanThuocServiceSoapClient();
        public static string Ten_USER = "";
        public static string Ma_USER ="";

        public static string tendangnhap;
        public static string matkhaucu;
        public static string quyen;

        public XtraForm1()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
        }
        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            Ten_USER = client.getID(txbTenDangNhap.Text, txbMatKhau.Text);
            Ma_USER = client.ma_user();
            if (Ten_USER != "0")
            {
                //getRole
                DataTable role = client.getRole(txbTenDangNhap.Text);
                quyen = role.Rows[0].ItemArray[6].ToString();
                string tenquyen;
                if (quyen.TrimEnd() == "0")
                {
                    tenquyen = "Admin";
                }
                else
                    tenquyen = "User";
                
                //Lưu giữ tên đăng nhập, mật khẩu và quyền
                tendangnhap = txbTenDangNhap.Text;
                matkhaucu = txbMatKhau.Text;
                //Bắt đầu phiên đăng nhập
                MessageBox.Show("Phiên đăng nhập nhân viên: " + Ten_USER + " với quyền là " + tenquyen);
                Form1 fmain = new Form1();
                fmain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản và mật khẩu không đúng !");
            }
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            txbMatKhau.UseSystemPasswordChar = true;
        }

        private void lbDangKy_Click(object sender, EventArgs e)
        {
            Đăng_ký DangKy = new Đăng_ký();
            DangKy.Show();
            this.Hide();
        }

        private void cbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPass.Checked == true)
            {
                txbMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txbMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng đăng nhập trước khi sử dụng phần mềm.", "Thông báo.");
        }

        private void XtraForm1_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txbMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnDangNhap_Click(this, new EventArgs());
            }
        }
    }
}