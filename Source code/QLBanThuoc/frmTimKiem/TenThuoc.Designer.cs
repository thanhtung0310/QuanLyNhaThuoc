namespace QLBanThuoc.frmTimKiem
{
    partial class TenThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TenThuoc));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTimKiem = new System.Windows.Forms.TextBox();
            this.dateHSD = new System.Windows.Forms.DateTimePicker();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.dateNSX = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CongDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DangThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanSuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgvKetQua);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1502, 753);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txbTimKiem);
            this.groupBox2.Controls.Add(this.dateHSD);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.dateNSX);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(8, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1349, 65);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(29, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập thông tin tìm kiếm:";
            // 
            // txbTimKiem
            // 
            this.txbTimKiem.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txbTimKiem.Location = new System.Drawing.Point(29, 24);
            this.txbTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbTimKiem.Name = "txbTimKiem";
            this.txbTimKiem.Size = new System.Drawing.Size(477, 28);
            this.txbTimKiem.TabIndex = 0;
            // 
            // dateHSD
            // 
            this.dateHSD.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateHSD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateHSD.Location = new System.Drawing.Point(859, 24);
            this.dateHSD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateHSD.Name = "dateHSD";
            this.dateHSD.Size = new System.Drawing.Size(142, 28);
            this.dateHSD.TabIndex = 6;
            this.dateHSD.ValueChanged += new System.EventHandler(this.dateHSD_ValueChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Appearance.Options.UseFont = true;
            this.btnTimKiem.Appearance.Options.UseForeColor = true;
            this.btnTimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(1102, 3);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(187, 54);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dateNSX
            // 
            this.dateNSX.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNSX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNSX.Location = new System.Drawing.Point(627, 24);
            this.dateNSX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateNSX.Name = "dateNSX";
            this.dateNSX.Size = new System.Drawing.Size(164, 28);
            this.dateNSX.TabIndex = 5;
            this.dateNSX.ValueChanged += new System.EventHandler(this.dateNSX_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(623, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày sản xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(855, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hạn sử dụng";
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvKetQua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.CongDung,
            this.ThanhPhan,
            this.DangThuoc,
            this.NgaySanXuat,
            this.HanSuDung,
            this.DonGia,
            this.DonGia1});
            this.dgvKetQua.GridColor = System.Drawing.SystemColors.Control;
            this.dgvKetQua.Location = new System.Drawing.Point(8, 97);
            this.dgvKetQua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.RowHeadersWidth = 51;
            this.dgvKetQua.Size = new System.Drawing.Size(1349, 489);
            this.dgvKetQua.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenThuoc";
            this.Column1.HeaderText = "Tên thuốc";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // CongDung
            // 
            this.CongDung.DataPropertyName = "CongDung";
            this.CongDung.HeaderText = "Công dụng";
            this.CongDung.MinimumWidth = 6;
            this.CongDung.Name = "CongDung";
            this.CongDung.Width = 125;
            // 
            // ThanhPhan
            // 
            this.ThanhPhan.DataPropertyName = "ThanhPhan";
            this.ThanhPhan.HeaderText = "Thành phần";
            this.ThanhPhan.MinimumWidth = 6;
            this.ThanhPhan.Name = "ThanhPhan";
            this.ThanhPhan.Width = 125;
            // 
            // DangThuoc
            // 
            this.DangThuoc.DataPropertyName = "DangThuoc";
            this.DangThuoc.HeaderText = "Dạng thuốc";
            this.DangThuoc.MinimumWidth = 6;
            this.DangThuoc.Name = "DangThuoc";
            this.DangThuoc.Width = 125;
            // 
            // NgaySanXuat
            // 
            this.NgaySanXuat.DataPropertyName = "NgaySanXuat";
            this.NgaySanXuat.HeaderText = "Ngày sản xuất";
            this.NgaySanXuat.MinimumWidth = 6;
            this.NgaySanXuat.Name = "NgaySanXuat";
            this.NgaySanXuat.Width = 125;
            // 
            // HanSuDung
            // 
            this.HanSuDung.DataPropertyName = "HanSuDung";
            this.HanSuDung.HeaderText = "Hạn sử dụng";
            this.HanSuDung.MinimumWidth = 6;
            this.HanSuDung.Name = "HanSuDung";
            this.HanSuDung.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá nhập";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 125;
            // 
            // DonGia1
            // 
            this.DonGia1.DataPropertyName = "DonGia1";
            this.DonGia1.HeaderText = "Đơn giá xuất";
            this.DonGia1.MinimumWidth = 6;
            this.DonGia1.Name = "DonGia1";
            this.DonGia1.Width = 125;
            // 
            // TenThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TenThuoc";
            this.Size = new System.Drawing.Size(1541, 788);
            this.Load += new System.EventHandler(this.TenThuoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CongDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DangThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanSuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia1;
        private System.Windows.Forms.DateTimePicker dateHSD;
        private System.Windows.Forms.DateTimePicker dateNSX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
