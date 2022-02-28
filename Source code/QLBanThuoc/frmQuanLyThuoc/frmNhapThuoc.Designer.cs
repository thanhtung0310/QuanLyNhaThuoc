namespace QLBanThuoc.frmQuanLyNguoiDung
{
    partial class frmNhapThuoc
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.comboTenNCC = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNhaCungCapOK = new System.Windows.Forms.Button();
            this.btnNhaCungCapHuy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelMaNhaCungCap = new System.Windows.Forms.Label();
            this.labelThongTinDaiDien = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.labelSDT = new System.Windows.Forms.Label();
            this.lbMaNhanVien = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxLoaiThuoc = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbDonGia = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tbMaThuoc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbDangThuoc = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbCongDung = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbThanhPhan = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxHangSanXuat = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpHanSD = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpNgaySX = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTenLo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTenThuoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(30, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhà cung cấp:";
            // 
            // comboTenNCC
            // 
            this.comboTenNCC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboTenNCC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboTenNCC.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboTenNCC.FormattingEnabled = true;
            this.comboTenNCC.Items.AddRange(new object[] {
            "CTY TNHH Downstair",
            "CTY PP Duy Anh",
            "CTY TNHH Hải Lam",
            "CTY PP Wefor",
            "CTY PP Gamma"});
            this.comboTenNCC.Location = new System.Drawing.Point(266, 45);
            this.comboTenNCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboTenNCC.Name = "comboTenNCC";
            this.comboTenNCC.Size = new System.Drawing.Size(311, 29);
            this.comboTenNCC.TabIndex = 2;
            this.comboTenNCC.SelectedIndexChanged += new System.EventHandler(this.comboTenNCC_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(30, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã nhà cung cấp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(30, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thông tin người đại diện:";
            // 
            // btnNhaCungCapOK
            // 
            this.btnNhaCungCapOK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnNhaCungCapOK.Location = new System.Drawing.Point(133, 185);
            this.btnNhaCungCapOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNhaCungCapOK.Name = "btnNhaCungCapOK";
            this.btnNhaCungCapOK.Size = new System.Drawing.Size(109, 42);
            this.btnNhaCungCapOK.TabIndex = 5;
            this.btnNhaCungCapOK.Text = "OK";
            this.btnNhaCungCapOK.UseVisualStyleBackColor = true;
            this.btnNhaCungCapOK.Click += new System.EventHandler(this.btnNhaCungCapOK_Click);
            // 
            // btnNhaCungCapHuy
            // 
            this.btnNhaCungCapHuy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnNhaCungCapHuy.Location = new System.Drawing.Point(351, 185);
            this.btnNhaCungCapHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNhaCungCapHuy.Name = "btnNhaCungCapHuy";
            this.btnNhaCungCapHuy.Size = new System.Drawing.Size(120, 42);
            this.btnNhaCungCapHuy.TabIndex = 6;
            this.btnNhaCungCapHuy.Text = "Hủy bỏ";
            this.btnNhaCungCapHuy.UseVisualStyleBackColor = true;
            this.btnNhaCungCapHuy.Click += new System.EventHandler(this.btnNhaCungCapHuy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelMaNhaCungCap);
            this.groupBox1.Controls.Add(this.labelThongTinDaiDien);
            this.groupBox1.Controls.Add(this.btnNhaCungCapHuy);
            this.groupBox1.Controls.Add(this.comboTenNCC);
            this.groupBox1.Controls.Add(this.btnNhaCungCapOK);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(10, 199);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(682, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN NHÀ CUNG CẤP";
            // 
            // labelMaNhaCungCap
            // 
            this.labelMaNhaCungCap.AutoSize = true;
            this.labelMaNhaCungCap.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelMaNhaCungCap.Location = new System.Drawing.Point(262, 91);
            this.labelMaNhaCungCap.Name = "labelMaNhaCungCap";
            this.labelMaNhaCungCap.Size = new System.Drawing.Size(298, 21);
            this.labelMaNhaCungCap.TabIndex = 12;
            this.labelMaNhaCungCap.Text = "________________________________";
            // 
            // labelThongTinDaiDien
            // 
            this.labelThongTinDaiDien.AutoSize = true;
            this.labelThongTinDaiDien.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelThongTinDaiDien.Location = new System.Drawing.Point(262, 133);
            this.labelThongTinDaiDien.Name = "labelThongTinDaiDien";
            this.labelThongTinDaiDien.Size = new System.Drawing.Size(298, 21);
            this.labelThongTinDaiDien.TabIndex = 11;
            this.labelThongTinDaiDien.Text = "________________________________";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTenNhanVien);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.labelSDT);
            this.groupBox2.Controls.Add(this.lbMaNhanVien);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(10, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(682, 176);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.AutoSize = true;
            this.lbTenNhanVien.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbTenNhanVien.Location = new System.Drawing.Point(266, 47);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(298, 21);
            this.lbTenNhanVien.TabIndex = 12;
            this.lbTenNhanVien.Text = "________________________________";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label23.Location = new System.Drawing.Point(30, 47);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(120, 21);
            this.label23.TabIndex = 11;
            this.label23.Text = "Tên nhân viên:";
            // 
            // labelSDT
            // 
            this.labelSDT.AutoSize = true;
            this.labelSDT.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelSDT.Location = new System.Drawing.Point(266, 119);
            this.labelSDT.Name = "labelSDT";
            this.labelSDT.Size = new System.Drawing.Size(298, 21);
            this.labelSDT.TabIndex = 10;
            this.labelSDT.Text = "________________________________";
            // 
            // lbMaNhanVien
            // 
            this.lbMaNhanVien.AutoSize = true;
            this.lbMaNhanVien.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbMaNhanVien.Location = new System.Drawing.Point(266, 83);
            this.lbMaNhanVien.Name = "lbMaNhanVien";
            this.lbMaNhanVien.Size = new System.Drawing.Size(298, 21);
            this.lbMaNhanVien.TabIndex = 9;
            this.lbMaNhanVien.Text = "________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(30, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(30, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã nhân viên:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxLoaiThuoc);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.lbTongTien);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.tbDonGia);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.tbSoLuong);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.tbMaThuoc);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.tbDangThuoc);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.tbCongDung);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.tbThanhPhan);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.comboBoxHangSanXuat);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.dtpHanSD);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.dtpNgaySX);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbTenLo);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbTenThuoc);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(711, 5);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(694, 738);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "THÔNG TIN NHẬP THUỐC";
            // 
            // comboBoxLoaiThuoc
            // 
            this.comboBoxLoaiThuoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxLoaiThuoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxLoaiThuoc.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboBoxLoaiThuoc.FormattingEnabled = true;
            this.comboBoxLoaiThuoc.Items.AddRange(new object[] {
            "Thuốc Đông Y",
            "Thuốc Kháng Sinh",
            "Thuốc Nam Y",
            "Thực Phẩm Chức Năng",
            "Thuốc Tây Y"});
            this.comboBoxLoaiThuoc.Location = new System.Drawing.Point(225, 479);
            this.comboBoxLoaiThuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxLoaiThuoc.Name = "comboBoxLoaiThuoc";
            this.comboBoxLoaiThuoc.Size = new System.Drawing.Size(399, 29);
            this.comboBoxLoaiThuoc.TabIndex = 14;
            this.comboBoxLoaiThuoc.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoaiThuoc_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label20.Location = new System.Drawing.Point(42, 483);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 21);
            this.label20.TabIndex = 32;
            this.label20.Text = "Loại thuốc:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label22.Location = new System.Drawing.Point(462, 611);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 23);
            this.label22.TabIndex = 31;
            this.label22.Text = "(VNĐ)";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lbTongTien.Location = new System.Drawing.Point(276, 611);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(190, 23);
            this.lbTongTien.TabIndex = 30;
            this.lbTongTien.Text = "__________________";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label21.Location = new System.Drawing.Point(176, 611);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(97, 23);
            this.label21.TabIndex = 29;
            this.label21.Text = "Tổng tiền:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label19.Location = new System.Drawing.Point(602, 566);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 23);
            this.label19.TabIndex = 28;
            this.label19.Text = "(VNĐ)";
            // 
            // tbDonGia
            // 
            this.tbDonGia.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbDonGia.Location = new System.Drawing.Point(481, 562);
            this.tbDonGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDonGia.Name = "tbDonGia";
            this.tbDonGia.Size = new System.Drawing.Size(115, 30);
            this.tbDonGia.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label18.Location = new System.Drawing.Point(336, 566);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(135, 23);
            this.label18.TabIndex = 26;
            this.label18.Text = "Đơn giá thuốc:";
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbSoLuong.Location = new System.Drawing.Point(217, 562);
            this.tbSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(99, 30);
            this.tbSoLuong.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label17.Location = new System.Drawing.Point(62, 566);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(141, 23);
            this.label17.TabIndex = 24;
            this.label17.Text = "Số lượng nhập:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(384, 655);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 37);
            this.button3.TabIndex = 23;
            this.button3.Text = "Hủy bỏ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(191, 655);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 37);
            this.button4.TabIndex = 22;
            this.button4.Text = "OK";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbMaThuoc
            // 
            this.tbMaThuoc.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbMaThuoc.Location = new System.Drawing.Point(225, 86);
            this.tbMaThuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaThuoc.Name = "tbMaThuoc";
            this.tbMaThuoc.Size = new System.Drawing.Size(399, 28);
            this.tbMaThuoc.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label16.Location = new System.Drawing.Point(42, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 21);
            this.label16.TabIndex = 20;
            this.label16.Text = "Mã thuốc:";
            // 
            // tbDangThuoc
            // 
            this.tbDangThuoc.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbDangThuoc.Location = new System.Drawing.Point(225, 443);
            this.tbDangThuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDangThuoc.Name = "tbDangThuoc";
            this.tbDangThuoc.Size = new System.Drawing.Size(399, 28);
            this.tbDangThuoc.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label15.Location = new System.Drawing.Point(42, 447);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 21);
            this.label15.TabIndex = 18;
            this.label15.Text = "Dạng thuốc:";
            // 
            // tbCongDung
            // 
            this.tbCongDung.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbCongDung.Location = new System.Drawing.Point(225, 370);
            this.tbCongDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCongDung.Multiline = true;
            this.tbCongDung.Name = "tbCongDung";
            this.tbCongDung.Size = new System.Drawing.Size(399, 65);
            this.tbCongDung.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label14.Location = new System.Drawing.Point(42, 377);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 21);
            this.label14.TabIndex = 16;
            this.label14.Text = "Công dụng:";
            // 
            // tbThanhPhan
            // 
            this.tbThanhPhan.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbThanhPhan.Location = new System.Drawing.Point(225, 294);
            this.tbThanhPhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbThanhPhan.Multiline = true;
            this.tbThanhPhan.Name = "tbThanhPhan";
            this.tbThanhPhan.Size = new System.Drawing.Size(400, 66);
            this.tbThanhPhan.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label13.Location = new System.Drawing.Point(42, 297);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 21);
            this.label13.TabIndex = 14;
            this.label13.Text = "Thành phần:";
            // 
            // comboBoxHangSanXuat
            // 
            this.comboBoxHangSanXuat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxHangSanXuat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxHangSanXuat.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboBoxHangSanXuat.FormattingEnabled = true;
            this.comboBoxHangSanXuat.Items.AddRange(new object[] {
            "Công ty DP Armephaco",
            "Công ty DP Traphaco",
            "Công ty DP Davinci",
            "Công ty DP Hoa Linh",
            "Công ty DP Pharmedic",
            "Công ty DP Shinpoong Daewoo",
            "Một thành viên",
            "Nam Thiên Phú"});
            this.comboBoxHangSanXuat.Location = new System.Drawing.Point(225, 254);
            this.comboBoxHangSanXuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxHangSanXuat.Name = "comboBoxHangSanXuat";
            this.comboBoxHangSanXuat.Size = new System.Drawing.Size(400, 29);
            this.comboBoxHangSanXuat.TabIndex = 10;
            this.comboBoxHangSanXuat.SelectedIndexChanged += new System.EventHandler(this.comboBoxHangSanXuat_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label12.Location = new System.Drawing.Point(42, 257);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 21);
            this.label12.TabIndex = 12;
            this.label12.Text = "Hãng sản xuất:";
            // 
            // dtpHanSD
            // 
            this.dtpHanSD.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dtpHanSD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHanSD.Location = new System.Drawing.Point(225, 212);
            this.dtpHanSD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpHanSD.Name = "dtpHanSD";
            this.dtpHanSD.Size = new System.Drawing.Size(399, 28);
            this.dtpHanSD.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label11.Location = new System.Drawing.Point(42, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 21);
            this.label11.TabIndex = 10;
            this.label11.Text = "Hạn sử dụng:";
            // 
            // dtpNgaySX
            // 
            this.dtpNgaySX.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dtpNgaySX.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySX.Location = new System.Drawing.Point(225, 170);
            this.dtpNgaySX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgaySX.Name = "dtpNgaySX";
            this.dtpNgaySX.Size = new System.Drawing.Size(399, 28);
            this.dtpNgaySX.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label10.Location = new System.Drawing.Point(42, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 21);
            this.label10.TabIndex = 8;
            this.label10.Text = "Ngày sản xuất:";
            // 
            // tbTenLo
            // 
            this.tbTenLo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbTenLo.Location = new System.Drawing.Point(225, 128);
            this.tbTenLo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTenLo.Name = "tbTenLo";
            this.tbTenLo.Size = new System.Drawing.Size(399, 28);
            this.tbTenLo.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label9.Location = new System.Drawing.Point(42, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 21);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tên lô thuốc:";
            // 
            // tbTenThuoc
            // 
            this.tbTenThuoc.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbTenThuoc.Location = new System.Drawing.Point(225, 44);
            this.tbTenThuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTenThuoc.Name = "tbTenThuoc";
            this.tbTenThuoc.Size = new System.Drawing.Size(399, 28);
            this.tbTenThuoc.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.Location = new System.Drawing.Point(42, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tên thuốc:";
            // 
            // frmNhapThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmNhapThuoc";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(1554, 780);
            this.Load += new System.EventHandler(this.frmNhapThuoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboTenNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNhaCungCapOK;
        private System.Windows.Forms.Button btnNhaCungCapHuy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbTenThuoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpHanSD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpNgaySX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbTenLo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDangThuoc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbCongDung;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbThanhPhan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxHangSanXuat;
        private System.Windows.Forms.Label labelSDT;
        private System.Windows.Forms.Label lbMaNhanVien;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbMaThuoc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelMaNhaCungCap;
        private System.Windows.Forms.Label labelThongTinDaiDien;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbDonGia;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBoxLoaiThuoc;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbTenNhanVien;
        private System.Windows.Forms.Label label23;
    }
}
