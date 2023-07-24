namespace QuanLySieuThiMini.UI
{
	partial class UCHangHoaNV
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
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.grcontrol = new DevExpress.XtraGrid.GridControl();
			this.dvDSHangHoa = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grcontrol)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dvDSHangHoa)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.grcontrol);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.Root;
			this.layoutControl1.Size = new System.Drawing.Size(681, 350);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// grcontrol
			// 
			this.grcontrol.Location = new System.Drawing.Point(12, 12);
			this.grcontrol.MainView = this.dvDSHangHoa;
			this.grcontrol.Name = "grcontrol";
			this.grcontrol.Size = new System.Drawing.Size(657, 326);
			this.grcontrol.TabIndex = 6;
			this.grcontrol.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dvDSHangHoa,
            this.gridView1});
			this.grcontrol.Load += new System.EventHandler(this.grcontrol_Load);
			// 
			// dvDSHangHoa
			// 
			this.dvDSHangHoa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn9,
            this.gridColumn11,
            this.gridColumn13});
			this.dvDSHangHoa.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
			this.dvDSHangHoa.GridControl = this.grcontrol;
			this.dvDSHangHoa.Name = "dvDSHangHoa";
			this.dvDSHangHoa.OptionsBehavior.Editable = false;
			this.dvDSHangHoa.OptionsBehavior.ReadOnly = true;
			this.dvDSHangHoa.OptionsView.ShowGroupPanel = false;
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "MaHH";
			this.gridColumn1.FieldName = "MaHH";
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 0;
			// 
			// gridColumn2
			// 
			this.gridColumn2.Caption = "TenHang";
			this.gridColumn2.FieldName = "TenHang";
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 1;
			// 
			// gridColumn4
			// 
			this.gridColumn4.Caption = "XuatXu";
			this.gridColumn4.FieldName = "XuatXu";
			this.gridColumn4.Name = "gridColumn4";
			this.gridColumn4.Visible = true;
			this.gridColumn4.VisibleIndex = 2;
			// 
			// gridColumn6
			// 
			this.gridColumn6.Caption = "GiaBan";
			this.gridColumn6.FieldName = "GiaBan";
			this.gridColumn6.Name = "gridColumn6";
			this.gridColumn6.Visible = true;
			this.gridColumn6.VisibleIndex = 3;
			// 
			// gridColumn7
			// 
			this.gridColumn7.Caption = "DonViTinh";
			this.gridColumn7.FieldName = "DonViTinh";
			this.gridColumn7.Name = "gridColumn7";
			this.gridColumn7.Visible = true;
			this.gridColumn7.VisibleIndex = 4;
			// 
			// gridColumn9
			// 
			this.gridColumn9.Caption = "MaVach";
			this.gridColumn9.FieldName = "MaVach";
			this.gridColumn9.Name = "gridColumn9";
			this.gridColumn9.Visible = true;
			this.gridColumn9.VisibleIndex = 5;
			// 
			// gridColumn11
			// 
			this.gridColumn11.Caption = "SoLuong";
			this.gridColumn11.FieldName = "SoLuong";
			this.gridColumn11.Name = "gridColumn11";
			this.gridColumn11.Visible = true;
			this.gridColumn11.VisibleIndex = 6;
			// 
			// gridColumn13
			// 
			this.gridColumn13.Caption = "VAT";
			this.gridColumn13.FieldName = "VAT";
			this.gridColumn13.Name = "gridColumn13";
			this.gridColumn13.Visible = true;
			this.gridColumn13.VisibleIndex = 7;
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.grcontrol;
			this.gridView1.Name = "gridView1";
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(681, 350);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.grcontrol;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(661, 330);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// UCHangHoaNV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl1);
			this.Name = "UCHangHoaNV";
			this.Size = new System.Drawing.Size(681, 350);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grcontrol)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dvDSHangHoa)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraGrid.GridControl grcontrol;
		private DevExpress.XtraGrid.Views.Grid.GridView dvDSHangHoa;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
	}
}
