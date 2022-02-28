using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBanThuoc.Data;
using System.Data.SqlClient;

namespace QLBanThuoc.frmQuanLyNguoiDung
{
    public partial class frmNhapThuoc : System.Windows.Forms.UserControl
    {
        public frmNhapThuoc()
        {
            InitializeComponent();
        }

        frmConnection frmconnection = new frmConnection();

        private string maHangSanXuat;
        private string maLoaiThuoc;
  
        private void comboBoxTenNCC_ItemChange(object sender, EventArgs e)
        {
            
        }
        private void frmNhapThuoc_Load(object sender, EventArgs e)
        {
            QL_SR.QLBanThuocServiceSoapClient client = new QL_SR.QLBanThuocServiceSoapClient();

            DataTable DSNV = client.LoadThongTinNV(XtraForm1.Ma_USER);

            lbMaNhanVien.Text = XtraForm1.Ma_USER;
            lbTenNhanVien.Text = DSNV.Rows[0].ItemArray[0].ToString();
            labelSDT.Text = DSNV.Rows[0].ItemArray[1].ToString();
        }

        private void btnNhaCungCapOK_Click(object sender, EventArgs e)
        {
            QL_SR.QLBanThuocServiceSoapClient client = new QL_SR.QLBanThuocServiceSoapClient();

            DataTable DSNCC = client.TimNCC(comboTenNCC.Text);

            labelMaNhaCungCap.Text = DSNCC.Rows[0].ItemArray[0].ToString();
            labelThongTinDaiDien.Text = DSNCC.Rows[0].ItemArray[1].ToString();
        }

        private void btnNhaCungCapHuy_Click(object sender, EventArgs e)
        {
            comboTenNCC.Text = "";
            labelMaNhaCungCap.Text = "________________________";
            labelThongTinDaiDien.Text = "________________________";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbTenThuoc.Text = "";
            tbMaThuoc.Text = "";
            tbTenLo.Text = "";
            dtpHanSD.Value = DateTime.Now;
            dtpNgaySX.Value = DateTime.Now;
            comboBoxHangSanXuat.Text = "";
            tbThanhPhan.Text = "";
            tbCongDung.Text = "";
            tbDangThuoc.Text = "";
            tbSoLuong.Text = "";
            tbDonGia.Text = "";
            lbTongTien.Text = "__________________";
        }

        private int checkThongTin()
        {
            if (tbSoLuong.Text == "" || tbDonGia.Text == "" || tbMaThuoc.Text == "" ||
                tbMaThuoc.Text == "" || tbTenThuoc.Text == "" || tbCongDung.Text == "" ||
                tbThanhPhan.Text == "" || tbDangThuoc.Text == "")
            {
                return 0;
            }
            else
                return 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QL_SR.QLBanThuocServiceSoapClient client = new QL_SR.QLBanThuocServiceSoapClient();

            int i = client.NhapThuoc(tbMaThuoc.Text, maHangSanXuat, dtpNgaySX.Value.ToString(), dtpHanSD.Value.ToString(), tbTenThuoc.Text, tbCongDung.Text, tbThanhPhan.Text, tbSoLuong.Text, tbDangThuoc.Text, maLoaiThuoc, DateTime.Now.ToString(), labelMaNhaCungCap.Text, XtraForm1.Ma_USER, tbDonGia.Text);

            MessageBox.Show(i.ToString() + " dòng bị ảnh hưởng", "thông báo");
            int check = checkThongTin();
            if (check == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo.");
            }
            else
            {
                int k = client.NhapThuoc(tbMaThuoc.Text, maHangSanXuat, dtpNgaySX.Value.ToString(), dtpHanSD.Value.ToString(), tbTenThuoc.Text, tbCongDung.Text, tbThanhPhan.Text, tbSoLuong.Text, tbDangThuoc.Text, maLoaiThuoc, DateTime.Now.ToString(), labelMaNhaCungCap.Text, XtraForm1.Ma_USER, tbDonGia.Text);
                if (k != 0)
                {
                    MessageBox.Show("Nhập thuốc thành công", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng thử lại.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBoxHangSanXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            QL_SR.QLBanThuocServiceSoapClient client = new QL_SR.QLBanThuocServiceSoapClient();

            DataTable DSHSX = client.LoadThongTinHSX(comboBoxHangSanXuat.SelectedItem.ToString());

            maHangSanXuat = DSHSX.Rows[0].ItemArray[0].ToString();
        }

        private void comboBoxLoaiThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            QL_SR.QLBanThuocServiceSoapClient client = new QL_SR.QLBanThuocServiceSoapClient();

            DataTable DSLT = client.LoadThongTinLoaiThuoc(comboBoxLoaiThuoc.SelectedItem.ToString());

            maLoaiThuoc = DSLT.Rows[0].ItemArray[0].ToString();
        }

        private void comboTenNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            QL_SR.QLBanThuocServiceSoapClient client = new QL_SR.QLBanThuocServiceSoapClient();

            DataTable DSNCC = client.TimNCC(comboTenNCC.SelectedItem.ToString());

            labelMaNhaCungCap.Text = DSNCC.Rows[0].ItemArray[0].ToString();
            labelThongTinDaiDien.Text = DSNCC.Rows[0].ItemArray[1].ToString();
        }
    }
}
