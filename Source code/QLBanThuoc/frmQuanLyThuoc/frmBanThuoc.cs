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

namespace QLBanThuoc.frmQuanLyThuoc
{
    public partial class frmBanThuoc : System.Windows.Forms.UserControl
    {
        public frmBanThuoc()
        {
            InitializeComponent();
        }     
        private string maKH;
        private void button2_Click(object sender, EventArgs e)
        {
            txbCMTND.Text = "";
            txbSDT.Text = "";
            txbTen.Text = "";
        }
   
        private void button3_Click(object sender, EventArgs e)
        {
            string ten = txbTen.Text;
            string cmtnd = txbCMTND.Text;
            string SDT = txbSDT.Text;
            DataTable dt = new DataTable();
            dt = client.TimKiemKH(txbCMTND.Text);
            if (dt.Rows.Count != 0)
            {
                MessageBox.Show("Khách hàng đã được đăng ký rồi", "Thông báo");
                maKH = dt.Rows[0].ItemArray[0].ToString();
            }
            else
            {
                if (ten != "" && SDT != "" && cmtnd != "")
                {
                    int i = client.ThemKH(ten, SDT, cmtnd);
                    if (i != 0)
                    {
                        MessageBox.Show("Đăng ký khách hàng thành công", "Thông báo");                        
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký khách hàng không thành công", "Thông báo");
                    }
                    DataTable dtTemp = new DataTable();
                    dtTemp = client.TimKiemKH(txbCMTND.Text);
                    maKH = dtTemp.Rows[0].ItemArray[0].ToString();
                }
                else
                {
                    MessageBox.Show("Mời nhập đầy đủ dữ liệu", "Thông báo");
                }
            }

        }

        private void TinhTongTien()
        {
            if (dataGridViewGioHang.Rows.Count > 0)
            {
                Int32 tongTien = 0;
                for (int i = 0; i < dataGridViewGioHang.Rows.Count; i++)
                {
                    tongTien += Int32.Parse(dataGridViewGioHang.Rows[i].Cells[4].Value.ToString());
                }
                labelTongTien.Text = tongTien.ToString();
            }
            else 
            {
                labelTongTien.Text = "_____________";
            }
        }
        private class Thuoc
        {

        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                senderGrid.Rows.RemoveAt(e.RowIndex);
                for (int i = 0; i < senderGrid.Rows.Count - 1; i++)
                {
                    senderGrid.Rows[i].Cells[0].Value = i + 1;
                }
                MessageBox.Show(dataGridViewGioHang.Rows.Count.ToString());
            }
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid == dataGridViewGioHang)
            {
                if (e.RowIndex >= 0)
                {
                    Int32 sl = Int32.Parse(senderGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Int32 dg = Int32.Parse(senderGrid.Rows[e.RowIndex].Cells[3].Value.ToString());
                    senderGrid.Rows[e.RowIndex].Cells[4].Value = (sl * dg).ToString();
                    TinhTongTien();
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmBanThuoc_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Today;
            int day = now.Day;
            int month = now.Month;
            int year = now.Year;
            lbDate.Text = day.ToString() + "/" + month.ToString() + "/" + year.ToString();
            
            DataTable dtTemp = new DataTable();
            dtTemp.Clear();
            dtTemp = client.TimKiemThuoc_Ban("");
            for (int i = 0; i < dtTemp.Rows.Count; i++)
            {
                comboBoxTenThuoc.Items.Add(dtTemp.Rows[i].ItemArray[0]);
            }
            tbTenNhanVien.Text = XtraForm1.Ten_USER;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maKH !=null)
            {
                DataTable dt = new DataTable();
                dt = client.ThemPhieuXuat(DateTime.Now.ToString(), maKH, XtraForm1.Ma_USER, labelTongTien.Text);
                dt = client.LayMaPX(DateTime.Now.ToString(), maKH, XtraForm1.Ma_USER, labelTongTien.Text);
                string mapx = dt.Rows[0].ItemArray[0].ToString();
                for (int i = 0; i < dataGridViewGioHang.Rows.Count - 1; i++)
                {
                    client.ThemDonThuoc(mapx, dataGridViewGioHang.Rows[i].Cells[0].Value.ToString(), dataGridViewGioHang.Rows[i].Cells[2].Value.ToString(), dataGridViewGioHang.Rows[i].Cells[3].Value.ToString());
                }
                MessageBox.Show("Xuất thành công", "Thông báo");
                txbCMTND.Text = "";
                txbSDT.Text = "";
                txbTen.Text = "";
                tbCongDung.Text = "";
                tbDonGia.Text = "";
                tbMaThuoc.Text = "";
                tbSoLuongMua.Text = "";
                tbSoLuongTon.Text = "";
                tbThanhPhan.Text = "";
                dataGridViewGioHang = null;
                labelTongTien.Text = "_____________";
            }
            else
            {
                MessageBox.Show("Mời thêm khách hàng", "Thông báo");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        QL_SR.QLBanThuocServiceSoapClient client = new QL_SR.QLBanThuocServiceSoapClient();
        private void comboBoxTenThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {           
            DataTable dtThuoc = new DataTable();
            dtThuoc = client.TimKiemThuoc(comboBoxTenThuoc.SelectedItem.ToString());
            tbMaThuoc.Text = dtThuoc.Rows[0].ItemArray[0].ToString();
            tbThanhPhan.Text = dtThuoc.Rows[0].ItemArray[1].ToString();
            tbCongDung.Text = dtThuoc.Rows[0].ItemArray[2].ToString();
            tbSoLuongTon.Text = dtThuoc.Rows[0].ItemArray[5].ToString();
            tbDonGia.Text = dtThuoc.Rows[0].ItemArray[4].ToString();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            tbMaThuoc.Text = "";
            tbThanhPhan.Text = "";
            tbCongDung.Text = "";
            tbSoLuongTon.Text = "";
            tbDonGia.Text = "";
            comboBoxTenThuoc.Text = "";
            tbSoLuongMua.Text = "";
        }

        private void tbSoLuongMua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbSoLuongMua.Text != "")
                {
                    int slTon = Int16.Parse(tbSoLuongTon.Text);
                    int slMua = Int16.Parse(tbSoLuongMua.Text);
                    if (slMua > slTon)
                    {
                        MessageBox.Show("Không đủ thuốc", "Thông báo");
                        tbSoLuongMua.Text = "0";
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.ToString());
            }
        }

        private void buttonThemVaoGio_Click(object sender, EventArgs e)
        {
            int slMua = Int32.Parse(tbSoLuongMua.Text);
            int donGia = Int32.Parse(tbDonGia.Text);
            string tien = (slMua * donGia).ToString();
            dataGridViewGioHang.Rows.Add(tbMaThuoc.Text, comboBoxTenThuoc.SelectedItem.ToString(),
                tbSoLuongMua.Text, tbDonGia.Text, tien);
            TinhTongTien();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
