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
using DevExpress.Data.Mask;
using System.Data.SqlClient;

namespace QLBanThuoc.BCTK
{
    public partial class ThuocNhap : DevExpress.XtraEditors.XtraUserControl
    {
        frmConnection Connect = new frmConnection();
        DataTable mainTable = new DataTable();

        public ThuocNhap()
        {
            InitializeComponent();
        }
        QL_SR.QLBanThuocServiceSoapClient client = new QL_SR.QLBanThuocServiceSoapClient();
        void loadData()
        {
            string startDate = date1.Value.ToString().Split(' ')[0].Replace("/", "-");
            string endDate = date2.Value.ToString().Split(' ')[0].Replace("/", "-");

            //xuất ra thông tin cho bảng
            mainTable = client.Thongke_ThuocNhap(startDate, endDate);
            dgvThuocNhap.DataSource = mainTable;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            mainTable.Clear();
            loadData();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang xuất file Excel...", "Thông báo.");
        }

        void checkTime()
        {
            date2.MinDate = date1.Value;
            date2.Value = date1.Value;
        }

        private void ThuocNhap_Load(object sender, EventArgs e)
        {
            checkTime();    
        }

        private void date1_ValueChanged(object sender, EventArgs e)
        {
            checkTime();
        }

        private void date2_ValueChanged(object sender, EventArgs e)
        {
            date2.MinDate = date1.Value;
        }
    }
}
