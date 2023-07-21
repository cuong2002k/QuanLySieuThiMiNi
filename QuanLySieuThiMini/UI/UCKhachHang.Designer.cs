namespace QuanLySieuThiMini.UI
{
	partial class UCKhachHang
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCKhachHang));
			this.scSearch = new DevExpress.XtraEditors.SearchControl();
			this.grcontrol = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.dvDSKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
			this.btnSua = new DevExpress.XtraEditors.SimpleButton();
			this.btnThem = new DevExpress.XtraEditors.SimpleButton();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			((System.ComponentModel.ISupportInitialize)(this.scSearch.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grcontrol)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dvDSKhachHang)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// scSearch
			// 
			this.scSearch.Location = new System.Drawing.Point(65, 12);
			this.scSearch.Name = "scSearch";
			this.scSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
			this.scSearch.Size = new System.Drawing.Size(239, 20);
			this.scSearch.StyleController = this.layoutControl1;
			this.scSearch.TabIndex = 4;
			// 
			// grcontrol
			// 
			this.grcontrol.Location = new System.Drawing.Point(12, 38);
			this.grcontrol.MainView = this.dvDSKhachHang;
			this.grcontrol.Name = "grcontrol";
			this.grcontrol.Size = new System.Drawing.Size(580, 315);
			this.grcontrol.TabIndex = 5;
			this.grcontrol.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dvDSKhachHang});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.grcontrol;
			this.gridView1.Name = "gridView1";
			// 
			// dvDSKhachHang
			// 
			this.dvDSKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn7,
            this.gridColumn10,
            this.gridColumn12});
			this.dvDSKhachHang.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
			this.dvDSKhachHang.GridControl = this.grcontrol;
			this.dvDSKhachHang.Name = "dvDSKhachHang";
			this.dvDSKhachHang.OptionsBehavior.Editable = false;
			this.dvDSKhachHang.OptionsBehavior.ReadOnly = true;
			this.dvDSKhachHang.OptionsView.ShowGroupPanel = false;
			this.dvDSKhachHang.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dvDSKhachHang_FocusedRowChanged);
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "MaKH";
			this.gridColumn1.FieldName = "MaKH";
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 0;
			// 
			// gridColumn2
			// 
			this.gridColumn2.Caption = "TenKH";
			this.gridColumn2.FieldName = "TenKH";
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 1;
			// 
			// gridColumn3
			// 
			this.gridColumn3.Caption = "CMND";
			this.gridColumn3.FieldName = "CMND";
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.Visible = true;
			this.gridColumn3.VisibleIndex = 2;
			// 
			// gridColumn4
			// 
			this.gridColumn4.Caption = "DiaChi";
			this.gridColumn4.FieldName = "DiaChi";
			this.gridColumn4.Name = "gridColumn4";
			this.gridColumn4.Visible = true;
			this.gridColumn4.VisibleIndex = 3;
			// 
			// gridColumn5
			// 
			this.gridColumn5.Caption = "SDT";
			this.gridColumn5.FieldName = "SDT";
			this.gridColumn5.Name = "gridColumn5";
			this.gridColumn5.Visible = true;
			this.gridColumn5.VisibleIndex = 7;
			// 
			// gridColumn7
			// 
			this.gridColumn7.Caption = "Diem";
			this.gridColumn7.FieldName = "Diem";
			this.gridColumn7.Name = "gridColumn7";
			this.gridColumn7.Visible = true;
			this.gridColumn7.VisibleIndex = 4;
			// 
			// gridColumn10
			// 
			this.gridColumn10.Caption = "NgayTao";
			this.gridColumn10.FieldName = "NgayTao";
			this.gridColumn10.Name = "gridColumn10";
			this.gridColumn10.Visible = true;
			this.gridColumn10.VisibleIndex = 5;
			// 
			// gridColumn12
			// 
			this.gridColumn12.Caption = "NamGanBo";
			this.gridColumn12.FieldName = "NamGanBo";
			this.gridColumn12.Name = "gridColumn12";
			this.gridColumn12.Visible = true;
			this.gridColumn12.VisibleIndex = 6;
			// 
			// btnXoa
			// 
			this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
			this.btnXoa.Location = new System.Drawing.Point(384, 12);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(68, 22);
			this.btnXoa.StyleController = this.layoutControl1;
			this.btnXoa.TabIndex = 6;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
			this.btnSua.Location = new System.Drawing.Point(308, 12);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(72, 22);
			this.btnSua.StyleController = this.layoutControl1;
			this.btnSua.TabIndex = 7;
			this.btnSua.Text = "Sửa";
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
			this.btnThem.Location = new System.Drawing.Point(456, 12);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(136, 22);
			this.btnThem.StyleController = this.layoutControl1;
			this.btnThem.TabIndex = 8;
			this.btnThem.Text = "Tạo Mới";
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(604, 365);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.btnThem;
			this.layoutControlItem5.Location = new System.Drawing.Point(444, 0);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(140, 26);
			this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem5.TextVisible = false;
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.btnSua;
			this.layoutControlItem4.Location = new System.Drawing.Point(296, 0);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(76, 26);
			this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem4.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.btnXoa;
			this.layoutControlItem3.Location = new System.Drawing.Point(372, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(72, 26);
			this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem3.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.grcontrol;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(584, 319);
			this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.scSearch;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(296, 26);
			this.layoutControlItem1.Text = "Tim Kiếm";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(41, 13);
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.btnThem);
			this.layoutControl1.Controls.Add(this.btnSua);
			this.layoutControl1.Controls.Add(this.btnXoa);
			this.layoutControl1.Controls.Add(this.grcontrol);
			this.layoutControl1.Controls.Add(this.scSearch);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 72, 650, 400);
			this.layoutControl1.Root = this.Root;
			this.layoutControl1.Size = new System.Drawing.Size(604, 365);
			this.layoutControl1.TabIndex = 1;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// UCKhachHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl1);
			this.Name = "UCKhachHang";
			this.Size = new System.Drawing.Size(604, 365);
			this.Load += new System.EventHandler(this.UCKhachHang_Load);
			((System.ComponentModel.ISupportInitialize)(this.scSearch.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grcontrol)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dvDSKhachHang)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.SearchControl scSearch;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraEditors.SimpleButton btnThem;
		private DevExpress.XtraEditors.SimpleButton btnSua;
		private DevExpress.XtraEditors.SimpleButton btnXoa;
		private DevExpress.XtraGrid.GridControl grcontrol;
		private DevExpress.XtraGrid.Views.Grid.GridView dvDSKhachHang;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
	}
}
