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

namespace QLBanThuoc.frmThongKe
{
    public partial class DonThuocDaBan : DevExpress.XtraEditors.XtraUserControl
    {
        public DonThuocDaBan()
        {
            InitializeComponent();
        }
        QL_SR.QLBanThuocServiceSoapClient client = new QL_SR.QLBanThuocServiceSoapClient();
        private void DonThuocDaBan_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = client.LayThuocDonThuoc();
            gridControl1.DataSource = table;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = client.TimKiemThuocDonThuoc(textBox1.Text);
            gridControl1.DataSource = table;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
