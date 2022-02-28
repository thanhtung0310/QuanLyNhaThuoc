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
using System.Data.SqlClient;
using QLBanThuoc.Data;

namespace QLBanThuoc.frmTimKiem
{
    public partial class TenThuoc : System.Windows.Forms.UserControl
    {
        public TenThuoc()
        {
            InitializeComponent();
        }

        void loadData()
        {
            //Lấy danh sách thông tin thuốc vào bảng
            QL_SR.QLBanThuocServiceSoapClient qlClient = new QL_SR.QLBanThuocServiceSoapClient();

            DataTable DS = qlClient.DanhSachThuoc();
            dgvKetQua.AutoGenerateColumns = false;
            dgvKetQua.DataSource = DS;
        }

        private void TenThuoc_Load(object sender, EventArgs e)
        {
            //load dữ liệu vào bảng
            loadData();
            checkTime();
            dateNSX.Value = dateHSD.Value = DateTime.Now;
        }

        void searchTheoTen()
        {
            QL_SR.QLBanThuocServiceSoapClient qlClient = new QL_SR.QLBanThuocServiceSoapClient();

            string TenThuoc = txbTimKiem.Text;
            DataTable DS = qlClient.DanhSachThuocTheoTen(TenThuoc);

            dgvKetQua.AutoGenerateColumns = false;
            dgvKetQua.DataSource = DS;
        }

        void searchTheoThoiHan()
        {
            QL_SR.QLBanThuocServiceSoapClient qlClient = new QL_SR.QLBanThuocServiceSoapClient();

            string date1 = dateNSX.Value.ToString().Split(' ')[0].Replace("/", "-");
            string date2 = dateHSD.Value.ToString().Split(' ')[0].Replace("/", "-");

            DataTable DS = qlClient.DanhSachThuocTheoThoiHan(date1, date2);
            dgvKetQua.AutoGenerateColumns = false;
            dgvKetQua.DataSource = DS;
        }

        void searchTheoTenVaThoiHan()
        {
            QL_SR.QLBanThuocServiceSoapClient qlClient = new QL_SR.QLBanThuocServiceSoapClient();

            string TenThuoc = txbTimKiem.Text;
            string date1 = dateNSX.Value.ToString().Split(' ')[0].Replace("/", "-");
            string date2 = dateHSD.Value.ToString().Split(' ')[0].Replace("/", "-");

            DataTable DS = qlClient.DanhSachThuocTheoTenVaThoiHan(TenThuoc, date1, date2);
            dgvKetQua.AutoGenerateColumns = false;
            dgvKetQua.DataSource = DS;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //tìm kiếm tất cả các thông tin có liên quan đến chuỗi tìm kiếm
            if (txbTimKiem.Text == "" && dateNSX.Value == DateTime.Now && dateHSD.Value == DateTime.Now)
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin tìm kiếm.", "Thông báo.");
            }
            else if (txbTimKiem.Text != "")
            {
                searchTheoTen();
            }
            else if (txbTimKiem.Text == "" && dateNSX.Value != DateTime.Now && dateHSD.Value != DateTime.Now)
            {
                searchTheoThoiHan();
            }
            else if (txbTimKiem.Text != "" && dateNSX.Value != DateTime.Now && dateHSD.Value != DateTime.Now)
            {
                searchTheoTenVaThoiHan();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin tìm kiếm.", "Thông báo.");
            }
        }

        void checkTime()
        {
            
        }

        private void dateNSX_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                checkTime();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.ToString(), "Thông báo");
            }
        }

        private void dateHSD_ValueChanged(object sender, EventArgs e)
        {
            dateHSD.MinDate = dateNSX.Value;
        }
    }
}
