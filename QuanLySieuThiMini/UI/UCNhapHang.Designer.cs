namespace QuanLySieuThiMini.UI
{
	partial class UCNhapHang
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCNhapHang));
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.grDsHangNhap = new DevExpress.XtraGrid.GridControl();
			this.gvHangNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
			this.btnNhapFile = new DevExpress.XtraEditors.SimpleButton();
			this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grDsHangNhap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvHangNhap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.grDsHangNhap);
			this.layoutControl1.Controls.Add(this.btnLamMoi);
			this.layoutControl1.Controls.Add(this.btnNhapFile);
			this.layoutControl1.Controls.Add(this.btnLuu);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.Root;
			this.layoutControl1.Size = new System.Drawing.Size(641, 328);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// grDsHangNhap
			// 
			this.grDsHangNhap.Location = new System.Drawing.Point(12, 38);
			this.grDsHangNhap.MainView = this.gvHangNhap;
			this.grDsHangNhap.Name = "grDsHangNhap";
			this.grDsHangNhap.Size = new System.Drawing.Size(617, 278);
			this.grDsHangNhap.TabIndex = 8;
			this.grDsHangNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHangNhap});
			// 
			// gvHangNhap
			// 
			this.gvHangNhap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13});
			this.gvHangNhap.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
			this.gvHangNhap.GridControl = this.grDsHangNhap;
			this.gvHangNhap.Name = "gvHangNhap";
			this.gvHangNhap.OptionsBehavior.Editable = false;
			this.gvHangNhap.OptionsBehavior.ReadOnly = true;
			this.gvHangNhap.OptionsView.ShowGroupPanel = false;
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "STT";
			this.gridColumn1.FieldName = "STT";
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 0;
			this.gridColumn1.Width = 44;
			// 
			// gridColumn2
			// 
			this.gridColumn2.Caption = "TenHang";
			this.gridColumn2.FieldName = "TenHang";
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 1;
			this.gridColumn2.Width = 52;
			// 
			// gridColumn3
			// 
			this.gridColumn3.Caption = "MaNH";
			this.gridColumn3.FieldName = "MaNH";
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.Visible = true;
			this.gridColumn3.VisibleIndex = 2;
			this.gridColumn3.Width = 42;
			// 
			// gridColumn4
			// 
			this.gridColumn4.Caption = "XuatXu";
			this.gridColumn4.FieldName = "XuatXu";
			this.gridColumn4.Name = "gridColumn4";
			this.gridColumn4.Visible = true;
			this.gridColumn4.VisibleIndex = 3;
			this.gridColumn4.Width = 42;
			// 
			// gridColumn5
			// 
			this.gridColumn5.Caption = "GiaNhap";
			this.gridColumn5.FieldName = "GiaNhap";
			this.gridColumn5.Name = "gridColumn5";
			this.gridColumn5.Visible = true;
			this.gridColumn5.VisibleIndex = 4;
			this.gridColumn5.Width = 42;
			// 
			// gridColumn6
			// 
			this.gridColumn6.Caption = "GiaBan";
			this.gridColumn6.FieldName = "GiaBan";
			this.gridColumn6.Name = "gridColumn6";
			this.gridColumn6.Visible = true;
			this.gridColumn6.VisibleIndex = 5;
			this.gridColumn6.Width = 42;
			// 
			// gridColumn7
			// 
			this.gridColumn7.Caption = "DonViTinh";
			this.gridColumn7.FieldName = "DonViTinh";
			this.gridColumn7.Name = "gridColumn7";
			this.gridColumn7.Visible = true;
			this.gridColumn7.VisibleIndex = 6;
			this.gridColumn7.Width = 42;
			// 
			// gridColumn8
			// 
			this.gridColumn8.Caption = "NhaCungCap";
			this.gridColumn8.FieldName = "NhaCungCap";
			this.gridColumn8.Name = "gridColumn8";
			this.gridColumn8.Visible = true;
			this.gridColumn8.VisibleIndex = 7;
			this.gridColumn8.Width = 42;
			// 
			// gridColumn9
			// 
			this.gridColumn9.Caption = "MaVach";
			this.gridColumn9.FieldName = "MaVach";
			this.gridColumn9.Name = "gridColumn9";
			this.gridColumn9.Visible = true;
			this.gridColumn9.VisibleIndex = 8;
			this.gridColumn9.Width = 42;
			// 
			// gridColumn10
			// 
			this.gridColumn10.Caption = "DinhMuc";
			this.gridColumn10.FieldName = "DinhMuc";
			this.gridColumn10.Name = "gridColumn10";
			this.gridColumn10.Visible = true;
			this.gridColumn10.VisibleIndex = 9;
			this.gridColumn10.Width = 42;
			// 
			// gridColumn11
			// 
			this.gridColumn11.Caption = "SoLuong";
			this.gridColumn11.FieldName = "SoLuong";
			this.gridColumn11.Name = "gridColumn11";
			this.gridColumn11.Visible = true;
			this.gridColumn11.VisibleIndex = 10;
			this.gridColumn11.Width = 42;
			// 
			// gridColumn12
			// 
			this.gridColumn12.Caption = "TrangThaiBan";
			this.gridColumn12.FieldName = "TrangThaiBan";
			this.gridColumn12.Name = "gridColumn12";
			this.gridColumn12.Visible = true;
			this.gridColumn12.VisibleIndex = 11;
			this.gridColumn12.Width = 42;
			// 
			// gridColumn13
			// 
			this.gridColumn13.Caption = "VAT";
			this.gridColumn13.FieldName = "VAT";
			this.gridColumn13.Name = "gridColumn13";
			this.gridColumn13.Visible = true;
			this.gridColumn13.VisibleIndex = 12;
			this.gridColumn13.Width = 65;
			// 
			// btnLamMoi
			// 
			this.btnLamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.Image")));
			this.btnLamMoi.Location = new System.Drawing.Point(250, 12);
			this.btnLamMoi.Name = "btnLamMoi";
			this.btnLamMoi.Size = new System.Drawing.Size(115, 22);
			this.btnLamMoi.StyleController = this.layoutControl1;
			this.btnLamMoi.TabIndex = 7;
			this.btnLamMoi.Text = "Làm Mới";
			this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
			// 
			// btnNhapFile
			// 
			this.btnNhapFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapFile.ImageOptions.Image")));
			this.btnNhapFile.Location = new System.Drawing.Point(12, 12);
			this.btnNhapFile.Name = "btnNhapFile";
			this.btnNhapFile.Size = new System.Drawing.Size(119, 22);
			this.btnNhapFile.StyleController = this.layoutControl1;
			this.btnNhapFile.TabIndex = 6;
			this.btnNhapFile.Text = "Nhập File";
			this.btnNhapFile.Click += new System.EventHandler(this.btnNhapFile_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
			this.btnLuu.Location = new System.Drawing.Point(135, 12);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(111, 22);
			this.btnLuu.StyleController = this.layoutControl1;
			this.btnLuu.TabIndex = 5;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem1});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(641, 328);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.btnLuu;
			this.layoutControlItem2.Location = new System.Drawing.Point(123, 0);
			this.layoutControlItem2.MaxSize = new System.Drawing.Size(115, 26);
			this.layoutControlItem2.MinSize = new System.Drawing.Size(115, 26);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(115, 26);
			this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.btnNhapFile;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem3.MaxSize = new System.Drawing.Size(123, 26);
			this.layoutControlItem3.MinSize = new System.Drawing.Size(123, 26);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(123, 26);
			this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem3.TextVisible = false;
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.btnLamMoi;
			this.layoutControlItem4.Location = new System.Drawing.Point(238, 0);
			this.layoutControlItem4.MaxSize = new System.Drawing.Size(119, 26);
			this.layoutControlItem4.MinSize = new System.Drawing.Size(119, 26);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(383, 26);
			this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem4.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.grDsHangNhap;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(621, 282);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// UCNhapHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl1);
			this.Name = "UCNhapHang";
			this.Size = new System.Drawing.Size(641, 328);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grDsHangNhap)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvHangNhap)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraEditors.SimpleButton btnLamMoi;
		private DevExpress.XtraEditors.SimpleButton btnNhapFile;
		private DevExpress.XtraEditors.SimpleButton btnLuu;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private DevExpress.XtraGrid.GridControl grDsHangNhap;
		private DevExpress.XtraGrid.Views.Grid.GridView gvHangNhap;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
	}
}
