using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanThuoc.Data;
using System.Data.SqlClient;

namespace QLBanThuoc.frmThongKe
{
    public partial class DoanhThu : UserControl
    {
        DataTable mainTable = new DataTable();

        public DoanhThu()
        {
            InitializeComponent();
        }
        QL_SR.QLBanThuocServiceSoapClient client = new QL_SR.QLBanThuocServiceSoapClient();
        void loadData()
        {
            string month = cmbThang.Text;
            string year = cmbNam.Text;
            string date1 = year + "-" + month + "-01";
            string date2 = year + "-" + "01-01";

            //thông kê theo các giá trị đã chọn
            //txbThang = Tháng => THống kê theo năm
            if (cmbThang.Text != "Tháng")
            {
                if (cmbNam.Text != "Năm")
                {
                    //đưa ra doanh thu tháng - năm
                    mainTable = client.TKDoanhThuMY(date1);
                    dgvDoanhThu.DataSource = mainTable;
                }
                else if (cmbNam.Text == "Năm")
                {
                    MessageBox.Show("Vui lòng lựa chọn năm cần thống kê doanh thu.", "Thông báo.");
                }
            }
            else if (cmbThang.Text == "Tháng")
            {
                if (cmbNam.Text != "Năm")
                {
                    //đưa ra doanh thu năm
                    mainTable = client.TKDoanhThuY(date2);
                    dgvDoanhThu.DataSource = mainTable;
                }
                else if (cmbNam.Text == "Năm")
                {
                    MessageBox.Show("Vui lòng lựa chọn tháng và năm cần thống kê doanh thu.", "Thông báo.");
                }
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            mainTable.Clear();
            loadData();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            //đưa ra màn hình xác nhận in
            MessageBox.Show("Đang xuất file Excel...", "Thông báo.");
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            //load thông tin vào bảng
            mainTable = client.TKDoanhThu();
            dgvDoanhThu.DataSource = mainTable;
        }
    }
}
