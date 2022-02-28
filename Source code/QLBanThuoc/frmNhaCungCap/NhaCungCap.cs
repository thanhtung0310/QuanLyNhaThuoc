using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLBanThuoc.Data;

namespace QLBanThuoc.frmNhaCungCap
{
    public partial class NhaCungCap : UserControl
    {
        public NhaCungCap()
        {
            InitializeComponent();

            this.AutoSize = true;
        }

        frmConnection connection = new frmConnection();
        QL_SR.QLBanThuocServiceSoapClient client = new QL_SR.QLBanThuocServiceSoapClient();
        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            DataTable DSTK = client.TimKiemNCC(txbTimKiem.Text);
            dataGridView1.DataSource = DSTK;
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private int checkNullTextbox()
        {
            if (textBoxMaNhaCungCap.Text == "" || textBoxTenNhaCungCap.Text == "" ||
               textBoxNguoiDaiDien.Text == "" || textBoxSoDienThoai.Text == "" || textBoxDiaChi.Text == "")
            {
                return 0;
            }
            else
                return 1;
        }
        private void ButtonThemMoi_Click(object sender, EventArgs e)
        {
            int iCheck = checkNullTextbox();
            if (iCheck == 0)
            {
                MessageBox.Show("Hãy nhập đủ thông tin", "Thông báo");
            }
            else
            {
                int i = client.ThemMoiNCC(textBoxMaNhaCungCap.Text, textBoxTenNhaCungCap.Text, textBoxNguoiDaiDien.Text, textBoxSoDienThoai.Text,textBoxDiaChi.Text);
                if (i!= 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm mới không thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }    
            }
        }

        private string MaNCC;
        private string TenNCC;
        private string NguoiDaiDien;
        private string SoDienThoai;
        private string DiaChi;
        private int iRowIndex;
        private void dgvCellClick_Click(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            iRowIndex = e.RowIndex;
            MaNCC = dataGridView1.Rows[i].Cells[0].Value.ToString();
            TenNCC = dataGridView1.Rows[i].Cells[1].Value.ToString();
            NguoiDaiDien = dataGridView1.Rows[i].Cells[2].Value.ToString();
            DiaChi = dataGridView1.Rows[i].Cells[3].Value.ToString();
            SoDienThoai = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private void ButtonSua_Click(object sender, EventArgs e)
        {
            textBoxMaNhaCungCap.Text = MaNCC;
            textBoxDiaChi.Text = DiaChi;
            textBoxSoDienThoai.Text = SoDienThoai;
            textBoxNguoiDaiDien.Text = NguoiDaiDien;
            textBoxTenNhaCungCap.Text = TenNCC;
            textBoxMaNhaCungCap.ReadOnly = true;

        }

        private void ButtonLuu_Click(object sender, EventArgs e)
        {
            int iCheck = checkNullTextbox();
            if (iCheck == 0)
            {
                MessageBox.Show("Hãy nhập đủ thông tin", "Thông báo");
            }
            else
            {
                int i = client.SuaNhaCungCap(textBoxMaNhaCungCap.Text, textBoxTenNhaCungCap.Text, textBoxNguoiDaiDien.Text, textBoxSoDienThoai.Text, textBoxDiaChi.Text);
                if (i != 0)
                {
                    MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thay đổi không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                textBoxMaNhaCungCap.Text = "";
                textBoxTenNhaCungCap.Text = "";
                textBoxNguoiDaiDien.Text = "";
                textBoxDiaChi.Text = "";
                textBoxSoDienThoai.Text = "";
                textBoxMaNhaCungCap.ReadOnly = false;
            }

        }

        private void ButtonXoa_Click(object sender, EventArgs e)
        {
            textBoxMaNhaCungCap.Text = MaNCC;
            textBoxDiaChi.Text = DiaChi;
            textBoxSoDienThoai.Text = SoDienThoai;
            textBoxNguoiDaiDien.Text = NguoiDaiDien;
            textBoxTenNhaCungCap.Text = TenNCC;
            textBoxMaNhaCungCap.ReadOnly = true;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            switch (result)
            {
                case DialogResult.Yes:
                    int i = client.XoaNhaCungCap(textBoxMaNhaCungCap.Text);
                    if (i != 0)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.Rows.RemoveAt(iRowIndex);
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case DialogResult.No:
                    break;
            }     
        }

        private void ButtonHuy_Click(object sender, EventArgs e)
        {
            textBoxMaNhaCungCap.Text = "";
            textBoxTenNhaCungCap.Text = "";
            textBoxNguoiDaiDien.Text = "";
            textBoxDiaChi.Text = "";
            textBoxSoDienThoai.Text = "";
            textBoxMaNhaCungCap.ReadOnly = false;
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            txbTimKiem.Text = "";
        }
    }
}
