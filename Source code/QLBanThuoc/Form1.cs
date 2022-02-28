using System;
using QLBanThuoc.BCTK;
using QLBanThuoc.frmQuanLyNguoiDung;
using QLBanThuoc.frmQuanLyThuoc;
using QLBanThuoc.frmTimKiem;
using QLBanThuoc.frmThongKe;
using QLBanThuoc.frmNhaCungCap;
using QLBanThuoc.Data;
using System.Windows.Forms;
using System.Drawing;

namespace QLBanThuoc
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);

            this.WindowState = FormWindowState.Maximized;
            this.Size = new System.Drawing.Size(10000, 1000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkQuyen();
        }

        void checkQuyen()
        {
            string permission = XtraForm1.quyen.Trim();
            if (permission == "0")
            {
                ribbonPage1.Visible = true;
                ribbonPage6.Visible = true;
                ribbonPage3.Visible = true;
                ribbonPage4.Visible = true;
                ribbonPage5.Visible = true;                
            }
            else
            {
                ribbonPage1.Visible = true;
                barButtonItem28.Enabled = false;
                ribbonPage6.Visible = false;
                ribbonPage3.Visible = true;
                ribbonPage4.Visible = true;
                ribbonPage5.Visible = true;
            }
        }

            private void BarButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel.Controls.Clear();
            frmDanhSach ds = new frmDanhSach();
            panel.Controls.Add(ds);
        }

        private void Nhập_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel.Controls.Clear();
            frmNhapThuoc nt = new frmNhapThuoc();
            panel.Controls.Add(nt);
        }

        private void BarButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel.Controls.Clear();
            frmBanThuoc bt = new frmBanThuoc();
            panel.Controls.Add(bt);
        }

        private void BarButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel.Controls.Clear();
            TenThuoc tt = new TenThuoc();
            panel.Controls.Add(tt);
        }

        private void BarButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel.Controls.Clear();
            ThuocNhap thuocnha = new ThuocNhap();
            panel.Controls.Add(thuocnha);
        }

        private void BarButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel.Controls.Clear();
            ThuocBanRa thuocban = new ThuocBanRa();
            panel.Controls.Add(thuocban);
        }

        private void BarButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel.Controls.Clear();
            SoLuongTon ton = new SoLuongTon();
            panel.Controls.Add(ton);
        }

        private void BarButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel.Controls.Clear();
            ThuocHetHan thuochet = new ThuocHetHan();
            panel.Controls.Add(thuochet);
        }

        private void BarButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel.Controls.Clear();
            DoanhThu dthang = new DoanhThu();
            panel.Controls.Add(dthang);
        }


        private void BarButtonItem3_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel.Controls.Clear();
            NhaCungCap ncc = new NhaCungCap();
            panel.Controls.Add(ncc);
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Đổi_mật_khẩu DoiMK = new Đổi_mật_khẩu();
            DoiMK.Show();
            this.Hide();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel.Controls.Clear();
            ThuocOnline ncc = new ThuocOnline();
            panel.Controls.Add(ncc);
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel.Controls.Clear();
            DonThuocDaBan dt = new DonThuocDaBan();
            panel.Controls.Add(dt);
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận đăng xuất?", "Thông báo.", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                XtraForm1 DangNhap = new XtraForm1();
                XtraForm1.Ten_USER = "";
                DangNhap.Show();
                this.Hide();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận thoát khỏi phần mềm?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("cmd.exe", "/c taskkill /F /IM QuanLyKho-TT.exe");
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
