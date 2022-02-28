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

namespace QLBanThuoc.frmQuanLyThuoc
{
    public partial class frmDanhSach : DevExpress.XtraEditors.XtraUserControl
    {
        public frmDanhSach()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private string maThuoc;
        private int index;
        private string madon;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvCellClick_Click(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            //MessageBox.Show("cell click "+ dataGridView1.Rows[i].Cells[1].Value.ToString());
            
            index = e.RowIndex;
            if (i >= 0)
            {
                madon = dataGridView1.Rows[i].Cells[0].Value.ToString();
                //MessageBox.Show(maThuoc);
            }
        }
        private void buttonLuu_Click(object sender, EventArgs e)
        {
            int i = client.LuuThuoc(maThuoc, textBoxLoThuoc.Text, textBoxTenThuoc.Text, textBoxThanhPhanChinh.Text, textBoxCongDung.Text, textBoxNgaySX.Text, textBoxHanSD.Text,
            textBoxSoLuongTon.Text, textBoxDonVi.Text, textBoxGiaBan.Text);
            if (i != 0)
            {
                MessageBox.Show("Cập nhật thuốc thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thuốc không thành công");
            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            textBoxCongDung.Text = "";
            textBoxDonVi.Text = "";
            textBoxGiaBan.Text = "";
            textBoxHangSX.Text = "";
            textBoxHanSD.Text = "";
            textBoxLoaiThuoc.Text = "";
            textBoxLoThuoc.Text = "";
            textBoxNgaySX.Text = "";
            textBoxSoLuongTon.Text = "";
            textBoxTenThuoc.Text = "";
            textBoxThanhPhanChinh.Text = "";   
        }
        QL_SR.QLBanThuocServiceSoapClient client = new QL_SR.QLBanThuocServiceSoapClient();
        private void buttonSua_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtTemp = new DataTable();
                dtTemp = client.TimKiemThuocSua(maThuoc);
                textBoxTenThuoc.Text = dtTemp.Rows[0].ItemArray[0].ToString();
                textBoxLoThuoc.Text = dtTemp.Rows[0].ItemArray[1].ToString();
                textBoxLoaiThuoc.Text = dtTemp.Rows[0].ItemArray[2].ToString();
                textBoxHangSX.Text = dtTemp.Rows[0].ItemArray[3].ToString();
                textBoxThanhPhanChinh.Text = dtTemp.Rows[0].ItemArray[4].ToString();
                textBoxCongDung.Text = dtTemp.Rows[0].ItemArray[5].ToString();
                textBoxNgaySX.Text = dtTemp.Rows[0].ItemArray[6].ToString();
                textBoxHanSD.Text = dtTemp.Rows[0].ItemArray[7].ToString();
                textBoxGiaBan.Text = dtTemp.Rows[0].ItemArray[8].ToString();
                textBoxSoLuongTon.Text = dtTemp.Rows[0].ItemArray[9].ToString();
                textBoxDonVi.Text = dtTemp.Rows[0].ItemArray[10].ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.ToString());
            }



        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DataTable dtTemp = new DataTable();
            dtTemp = client.TimKiemThuocSua(maThuoc);
            textBoxTenThuoc.Text = dtTemp.Rows[0].ItemArray[0].ToString();
            textBoxLoThuoc.Text = dtTemp.Rows[0].ItemArray[1].ToString();
            textBoxLoaiThuoc.Text = dtTemp.Rows[0].ItemArray[2].ToString();
            textBoxHangSX.Text = dtTemp.Rows[0].ItemArray[3].ToString();
            textBoxThanhPhanChinh.Text = dtTemp.Rows[0].ItemArray[4].ToString();
            textBoxCongDung.Text = dtTemp.Rows[0].ItemArray[5].ToString();
            textBoxNgaySX.Text = dtTemp.Rows[0].ItemArray[6].ToString();
            textBoxHanSD.Text = dtTemp.Rows[0].ItemArray[7].ToString();
            textBoxGiaBan.Text = dtTemp.Rows[0].ItemArray[8].ToString();
            textBoxSoLuongTon.Text = dtTemp.Rows[0].ItemArray[9].ToString();
            textBoxDonVi.Text = dtTemp.Rows[0].ItemArray[10].ToString();
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (result)
            {
                case DialogResult.Yes:
                    int i = client.XoaThuoc(maThuoc);
                    if (i != 0)
                    {
                        MessageBox.Show("Xóa thuốc thành công");
                        dataGridView1.Rows.RemoveAt(index);
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công", "Lỗi");
                    }
                    break;
                case DialogResult.No:
                    break;
            }
        }
        
        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            if (textBoxTimKiem.Text != "")
            {
                dt = client.TimKiemThuoc(textBoxTimKiem.Text);
                dataGridView1.DataSource = dt;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                    if (Convert.ToInt32(row.Cells[5].Value) <= 100)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (Convert.ToInt32(row.Cells[5].Value) > 100 && Convert.ToInt32(row.Cells[5].Value) <= 1000)
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
            }
            else
            {
                MessageBox.Show("Nhập thông tin tìm kiếm", "Thông báo");
                return;
            }

            if (dt.Rows.Count != 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả", "Thông báo");
            }

        }

        private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTimKiem_Click(object sender, EventArgs e)
        {
            if(textBoxTimKiem.Text == "Thông tin tìm kiếm")
            {
                textBoxTimKiem.Text = "";
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
