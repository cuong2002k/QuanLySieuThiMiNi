namespace QuanLySieuThiMini.UI
{
	partial class UCNhaCungCap
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCNhaCungCap));
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.gctDSNhaCungCap = new DevExpress.XtraGrid.GridControl();
			this.gvDsNhaCungCap = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
			this.btnThemHangHoa = new DevExpress.XtraEditors.SimpleButton();
			this.btnSua = new DevExpress.XtraEditors.SimpleButton();
			this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
			this.scNhacungcap = new DevExpress.XtraEditors.SearchControl();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gctDSNhaCungCap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvDsNhaCungCap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.scNhacungcap.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.gctDSNhaCungCap);
			this.layoutControl1.Controls.Add(this.btnLamMoi);
			this.layoutControl1.Controls.Add(this.btnThemHangHoa);
			this.layoutControl1.Controls.Add(this.btnSua);
			this.layoutControl1.Controls.Add(this.btnXoa);
			this.layoutControl1.Controls.Add(this.scNhacungcap);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.Root;
			this.layoutControl1.Size = new System.Drawing.Size(711, 386);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// gctDSNhaCungCap
			// 
			this.gctDSNhaCungCap.Location = new System.Drawing.Point(12, 38);
			this.gctDSNhaCungCap.MainView = this.gvDsNhaCungCap;
			this.gctDSNhaCungCap.Name = "gctDSNhaCungCap";
			this.gctDSNhaCungCap.Size = new System.Drawing.Size(687, 336);
			this.gctDSNhaCungCap.TabIndex = 14;
			this.gctDSNhaCungCap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDsNhaCungCap});
			// 
			// gvDsNhaCungCap
			// 
			this.gvDsNhaCungCap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
			this.gvDsNhaCungCap.GridControl = this.gctDSNhaCungCap;
			this.gvDsNhaCungCap.Name = "gvDsNhaCungCap";
			this.gvDsNhaCungCap.OptionsBehavior.Editable = false;
			this.gvDsNhaCungCap.OptionsBehavior.ReadOnly = true;
			this.gvDsNhaCungCap.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gvDsNhaCungCap.OptionsView.ShowGroupPanel = false;
			this.gvDsNhaCungCap.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvDsNhaCungCap_FocusedRowChanged);
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "MaNhaCungCap";
			this.gridColumn1.FieldName = "MaNCC";
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 0;
			// 
			// gridColumn2
			// 
			this.gridColumn2.Caption = "TenNhaCungCap";
			this.gridColumn2.FieldName = "TenNCC";
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 1;
			// 
			// gridColumn3
			// 
			this.gridColumn3.Caption = "DiaChi";
			this.gridColumn3.FieldName = "DiaChi";
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.Visible = true;
			this.gridColumn3.VisibleIndex = 2;
			// 
			// gridColumn4
			// 
			this.gridColumn4.Caption = "SDT";
			this.gridColumn4.FieldName = "SDT";
			this.gridColumn4.Name = "gridColumn4";
			this.gridColumn4.Visible = true;
			this.gridColumn4.VisibleIndex = 3;
			// 
			// btnLamMoi
			// 
			this.btnLamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.Image")));
			this.btnLamMoi.Location = new System.Drawing.Point(343, 12);
			this.btnLamMoi.Name = "btnLamMoi";
			this.btnLamMoi.Size = new System.Drawing.Size(87, 22);
			this.btnLamMoi.StyleController = this.layoutControl1;
			this.btnLamMoi.TabIndex = 13;
			this.btnLamMoi.Text = "Làm Mới";
			this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
			// 
			// btnThemHangHoa
			// 
			this.btnThemHangHoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemHangHoa.ImageOptions.Image")));
			this.btnThemHangHoa.Location = new System.Drawing.Point(598, 12);
			this.btnThemHangHoa.Name = "btnThemHangHoa";
			this.btnThemHangHoa.Size = new System.Drawing.Size(101, 22);
			this.btnThemHangHoa.StyleController = this.layoutControl1;
			this.btnThemHangHoa.TabIndex = 12;
			this.btnThemHangHoa.Text = "Tạo Mới";
			this.btnThemHangHoa.Click += new System.EventHandler(this.btnThemHangHoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
			this.btnSua.Location = new System.Drawing.Point(434, 12);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(74, 22);
			this.btnSua.StyleController = this.layoutControl1;
			this.btnSua.TabIndex = 11;
			this.btnSua.Text = "Sửa";
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
			this.btnXoa.Location = new System.Drawing.Point(512, 12);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(82, 22);
			this.btnXoa.StyleController = this.layoutControl1;
			this.btnXoa.TabIndex = 10;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// scNhacungcap
			// 
			this.scNhacungcap.Location = new System.Drawing.Point(65, 12);
			this.scNhacungcap.Name = "scNhacungcap";
			this.scNhacungcap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
			this.scNhacungcap.Size = new System.Drawing.Size(274, 20);
			this.scNhacungcap.StyleController = this.layoutControl1;
			this.scNhacungcap.TabIndex = 4;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem4,
            this.layoutControlItem3});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(711, 386);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.scNhacungcap;
			this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.layoutControlItem1.CustomizationFormText = "Tim Kiếm";
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(331, 26);
			this.layoutControlItem1.Text = "Tim Kiếm";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(41, 13);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.btnLamMoi;
			this.layoutControlItem2.Location = new System.Drawing.Point(331, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(91, 26);
			this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.btnXoa;
			this.layoutControlItem5.Location = new System.Drawing.Point(500, 0);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(86, 26);
			this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem5.TextVisible = false;
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.Control = this.gctDSNhaCungCap;
			this.layoutControlItem6.Location = new System.Drawing.Point(0, 26);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(691, 340);
			this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem6.TextVisible = false;
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.btnSua;
			this.layoutControlItem4.Location = new System.Drawing.Point(422, 0);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(78, 26);
			this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem4.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.btnThemHangHoa;
			this.layoutControlItem3.Location = new System.Drawing.Point(586, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(105, 26);
			this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem3.TextVisible = false;
			// 
			// UCNhaCungCap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl1);
			this.Name = "UCNhaCungCap";
			this.Size = new System.Drawing.Size(711, 386);
			this.Load += new System.EventHandler(this.UCNhaCungCap_Load);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gctDSNhaCungCap)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvDsNhaCungCap)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.scNhacungcap.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraEditors.SearchControl scNhacungcap;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraGrid.GridControl gctDSNhaCungCap;
		private DevExpress.XtraGrid.Views.Grid.GridView gvDsNhaCungCap;
		private DevExpress.XtraEditors.SimpleButton btnLamMoi;
		private DevExpress.XtraEditors.SimpleButton btnThemHangHoa;
		private DevExpress.XtraEditors.SimpleButton btnSua;
		private DevExpress.XtraEditors.SimpleButton btnXoa;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
	}
}
