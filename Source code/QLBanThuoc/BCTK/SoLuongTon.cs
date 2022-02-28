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

namespace QLBanThuoc.BCTK
{
    public partial class SoLuongTon : DevExpress.XtraEditors.XtraUserControl
    {
        frmConnection Connect = new frmConnection();
        DataTable mainTable = new DataTable();

        public SoLuongTon()
        {
            InitializeComponent();
        }
        QL_SR.QLBanThuocServiceSoapClient client = new QL_SR.QLBanThuocServiceSoapClient();
        void loadData()
        {
            //Lấy danh sách thông tin thuốc vào bảng
            mainTable = client.ThongkeSLT();
            dgvKetQua.DataSource = mainTable;
        }

        private void SoLuongTon_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang xuất file Excel...", "Thông báo.");
        }
    }
}
