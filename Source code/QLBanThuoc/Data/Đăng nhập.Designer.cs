namespace QLBanThuoc.Data
{
    partial class XtraForm1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm1));
            this.txbTenDangNhap = new System.Windows.Forms.TextBox();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTrangChu = new DevExpress.XtraEditors.SimpleButton();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.cbPass = new DevExpress.XtraEditors.CheckButton();
            this.lbDangKy = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbTenDangNhap
            // 
            this.txbTenDangNhap.Location = new System.Drawing.Point(177, 22);
            this.txbTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbTenDangNhap.Name = "txbTenDangNhap";
            this.txbTenDangNhap.Size = new System.Drawing.Size(230, 23);
            this.txbTenDangNhap.TabIndex = 0;
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Location = new System.Drawing.Point(178, 63);
            this.txbMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(230, 23);
            this.txbMatKhau.TabIndex = 1;
            this.txbMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbMatKhau_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(97, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "QUẢN LÝ NHÀ THUỐC";
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTrangChu.ImageOptions.Image")));
            this.btnTrangChu.Location = new System.Drawing.Point(19, 15);
            this.btnTrangChu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(43, 48);
            this.btnTrangChu.TabIndex = 6;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Appearance.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnDangNhap.Appearance.Options.UseFont = true;
            this.btnDangNhap.Appearance.Options.UseForeColor = true;
            this.btnDangNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangNhap.ImageOptions.SvgImage")));
            this.btnDangNhap.Location = new System.Drawing.Point(154, 107);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(159, 41);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.BtnDangNhap_Click);
            // 
            // cbPass
            // 
            this.cbPass.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.cbPass.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cbPass.Appearance.Options.UseFont = true;
            this.cbPass.Appearance.Options.UseForeColor = true;
            this.cbPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cbPass.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cbPass.ImageOptions.Image")));
            this.cbPass.Location = new System.Drawing.Point(416, 53);
            this.cbPass.Name = "cbPass";
            this.cbPass.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.cbPass.Size = new System.Drawing.Size(38, 36);
            this.cbPass.TabIndex = 11;
            this.cbPass.CheckedChanged += new System.EventHandler(this.cbPass_CheckedChanged);
            // 
            // lbDangKy
            // 
            this.lbDangKy.AutoSize = true;
            this.lbDangKy.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.lbDangKy.ForeColor = System.Drawing.Color.Red;
            this.lbDangKy.Location = new System.Drawing.Point(89, 158);
            this.lbDangKy.Name = "lbDangKy";
            this.lbDangKy.Size = new System.Drawing.Size(278, 17);
            this.lbDangKy.TabIndex = 10;
            this.lbDangKy.Text = "Chưa có tài khoản? Ấn vào đây để đăng ký.";
            this.lbDangKy.Click += new System.EventHandler(this.lbDangKy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPass);
            this.groupBox1.Controls.Add(this.lbDangKy);
            this.groupBox1.Controls.Add(this.btnDangNhap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbMatKhau);
            this.groupBox1.Controls.Add(this.txbTenDangNhap);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 192);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 277);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTrangChu);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XtraForm1";
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XtraForm1_FormClosing);
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbTenDangNhap;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnTrangChu;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private DevExpress.XtraEditors.CheckButton cbPass;
        private System.Windows.Forms.Label lbDangKy;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}