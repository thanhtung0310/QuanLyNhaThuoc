namespace QLBanThuoc.frmThongKe
{
    partial class DonThuocDaBan
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DonThuocDaBanlayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.groupBox1item = new DevExpress.XtraLayout.LayoutControlGroup();
            this.textBox1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnTimKiemitem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonThuocDaBanlayoutControl1ConvertedLayout)).BeginInit();
            this.DonThuocDaBanlayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimKiemitem)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBox1.Location = new System.Drawing.Point(185, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(968, 49);
            this.textBox1.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.Location = new System.Drawing.Point(1157, 50);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(319, 49);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(24, 103);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1452, 650);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // DonThuocDaBanlayoutControl1ConvertedLayout
            // 
            this.DonThuocDaBanlayoutControl1ConvertedLayout.Controls.Add(this.textBox1);
            this.DonThuocDaBanlayoutControl1ConvertedLayout.Controls.Add(this.gridControl1);
            this.DonThuocDaBanlayoutControl1ConvertedLayout.Controls.Add(this.btnTimKiem);
            this.DonThuocDaBanlayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DonThuocDaBanlayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.DonThuocDaBanlayoutControl1ConvertedLayout.Name = "DonThuocDaBanlayoutControl1ConvertedLayout";
            this.DonThuocDaBanlayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.DonThuocDaBanlayoutControl1ConvertedLayout.Size = new System.Drawing.Size(1500, 777);
            this.DonThuocDaBanlayoutControl1ConvertedLayout.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.groupBox1item});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1500, 777);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // groupBox1item
            // 
            this.groupBox1item.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.textBox1item,
            this.gridControl1item,
            this.btnTimKiemitem});
            this.groupBox1item.Location = new System.Drawing.Point(0, 0);
            this.groupBox1item.Name = "groupBox1item";
            this.groupBox1item.Size = new System.Drawing.Size(1480, 757);
            this.groupBox1item.Text = " ";
            // 
            // textBox1item
            // 
            this.textBox1item.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBox1item.AppearanceItemCaption.Options.UseFont = true;
            this.textBox1item.Control = this.textBox1;
            this.textBox1item.Location = new System.Drawing.Point(0, 0);
            this.textBox1item.Name = "textBox1item";
            this.textBox1item.Size = new System.Drawing.Size(1133, 53);
            this.textBox1item.Text = "Tên khách hàng:";
            this.textBox1item.TextLocation = DevExpress.Utils.Locations.Left;
            this.textBox1item.TextSize = new System.Drawing.Size(149, 24);
            // 
            // gridControl1item
            // 
            this.gridControl1item.Control = this.gridControl1;
            this.gridControl1item.Location = new System.Drawing.Point(0, 53);
            this.gridControl1item.Name = "gridControl1item";
            this.gridControl1item.Size = new System.Drawing.Size(1456, 654);
            this.gridControl1item.TextSize = new System.Drawing.Size(0, 0);
            this.gridControl1item.TextVisible = false;
            // 
            // btnTimKiemitem
            // 
            this.btnTimKiemitem.Control = this.btnTimKiem;
            this.btnTimKiemitem.Location = new System.Drawing.Point(1133, 0);
            this.btnTimKiemitem.Name = "btnTimKiemitem";
            this.btnTimKiemitem.Size = new System.Drawing.Size(323, 53);
            this.btnTimKiemitem.TextSize = new System.Drawing.Size(0, 0);
            this.btnTimKiemitem.TextVisible = false;
            // 
            // DonThuocDaBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DonThuocDaBanlayoutControl1ConvertedLayout);
            this.Name = "DonThuocDaBan";
            this.Size = new System.Drawing.Size(1500, 777);
            this.Load += new System.EventHandler(this.DonThuocDaBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonThuocDaBanlayoutControl1ConvertedLayout)).EndInit();
            this.DonThuocDaBanlayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimKiemitem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControl DonThuocDaBanlayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup groupBox1item;
        private DevExpress.XtraLayout.LayoutControlItem textBox1item;
        private DevExpress.XtraLayout.LayoutControlItem gridControl1item;
        private DevExpress.XtraLayout.LayoutControlItem btnTimKiemitem;
    }
}
