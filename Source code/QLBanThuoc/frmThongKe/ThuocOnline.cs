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
using System.Security.Cryptography;

namespace QLBanThuoc.frmThongKe
{
    public partial class ThuocOnline : DevExpress.XtraEditors.XtraUserControl
    {
        QL_SR.QLBanThuocServiceSoapClient client = new QL_SR.QLBanThuocServiceSoapClient();
        private int index,tongtien;
        private string madon,makh,sdt,ma;
        public ThuocOnline()
        {
            InitializeComponent();
        }       
        private void ThuocOnline_Load(object sender, EventArgs e)
        {
            DataTable ds = client.LayThuocDatHang();
            ThuocOnlineGrid.DataSource = ds;
            labelTien.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (madon != null)
            {
                client.XoaDon(madon);
                MessageBox.Show("Hủy đơn hàng thành công!");
            }
            else
            {
                MessageBox.Show("Không thể thực hiện thao tác này!");
            }                
        }

        public string MaHoaMD5(string str)
        {
            MD5 mh = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(str);
            byte[] hash = mh.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            client.ThemKH(makh, sdt, sdt+"00");
            dt = client.TimKiemKH(sdt);
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                ma = dt.Rows[j]["MaKhachHang"].ToString();
            }
            dt = client.ThemPhieuXuat(DateTime.Now.ToString(),ma, XtraForm1.Ma_USER, labelTien.Text);
            dt = client.LayMaPX(DateTime.Now.ToString(), ma, XtraForm1.Ma_USER, labelTien.Text);
            string mapx = dt.Rows[0].ItemArray[0].ToString();
            for (int i = 0; i < dsct.Rows.Count; i++)
            {
                client.ThemDonThuoc(mapx, dsct.Rows[i]["MaThuoc"].ToString(), dsct.Rows[i]["SoLuong"].ToString(), dsct.Rows[i]["DonGia"].ToString());
            }
            dsct.Clear();
            client.XoaDon(madon);
        }
        DataTable dsct;
        private void ThuocOnlineGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            //MessageBox.Show("cell click "+ dataGridView1.Rows[i].Cells[1].Value.ToString());
            tongtien = 0;
            labelTien.Text = "";
            index = e.RowIndex;
            if (i >= 0)
            {
                madon = ThuocOnlineGrid.Rows[i].Cells[0].Value.ToString();
                makh = ThuocOnlineGrid.Rows[i].Cells[1].Value.ToString();
                sdt = ThuocOnlineGrid.Rows[i].Cells[3].Value.ToString();
                //MessageBox.Show(maThuoc);
            }
            dsct = client.LayThuocDatHangChiTiet(madon);
            dataGridView1.DataSource = dsct;
            for (int j=0;j<dsct.Rows.Count;j++)
            {
                tongtien = tongtien + Convert.ToInt32(dsct.Rows[j]["DonGia"].ToString());
            }
            labelTien.Text = tongtien.ToString();
        }
    }
}
