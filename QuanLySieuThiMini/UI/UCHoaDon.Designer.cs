﻿namespace QuanLySieuThiMini.UI
{
	partial class UCHoaDon
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
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.gridControl = new DevExpress.XtraGrid.GridControl();
			this.gvDSHD = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvDSHD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.gridControl);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.Root;
			this.layoutControl1.Size = new System.Drawing.Size(770, 422);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(770, 422);
			this.Root.TextVisible = false;
			// 
			// gridControl
			// 
			this.gridControl.Location = new System.Drawing.Point(12, 12);
			this.gridControl.MainView = this.gvDSHD;
			this.gridControl.Name = "gridControl";
			this.gridControl.Size = new System.Drawing.Size(746, 398);
			this.gridControl.TabIndex = 4;
			this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSHD});
			// 
			// gvDSHD
			// 
			this.gvDSHD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn9});
			this.gvDSHD.GridControl = this.gridControl;
			this.gvDSHD.Name = "gvDSHD";
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.gridControl;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(750, 402);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "SoHD";
			this.gridColumn1.FieldName = "SoHD";
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 0;
			// 
			// gridColumn2
			// 
			this.gridColumn2.Caption = "MaNV";
			this.gridColumn2.FieldName = "MaNV";
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 1;
			// 
			// gridColumn3
			// 
			this.gridColumn3.Caption = "NgayLap";
			this.gridColumn3.FieldName = "NgayLap";
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.Visible = true;
			this.gridColumn3.VisibleIndex = 2;
			// 
			// gridColumn4
			// 
			this.gridColumn4.Caption = "MaKH";
			this.gridColumn4.FieldName = "MaKH";
			this.gridColumn4.Name = "gridColumn4";
			this.gridColumn4.Visible = true;
			this.gridColumn4.VisibleIndex = 3;
			// 
			// gridColumn5
			// 
			this.gridColumn5.Caption = "VAT";
			this.gridColumn5.FieldName = "VAT";
			this.gridColumn5.Name = "gridColumn5";
			this.gridColumn5.Visible = true;
			this.gridColumn5.VisibleIndex = 4;
			// 
			// gridColumn6
			// 
			this.gridColumn6.Caption = "TienKhachDua";
			this.gridColumn6.FieldName = "TienKhachDua";
			this.gridColumn6.Name = "gridColumn6";
			this.gridColumn6.Visible = true;
			this.gridColumn6.VisibleIndex = 5;
			// 
			// gridColumn7
			// 
			this.gridColumn7.Caption = "TienGuiKhach";
			this.gridColumn7.FieldName = "TienGuiKhach";
			this.gridColumn7.Name = "gridColumn7";
			this.gridColumn7.Visible = true;
			this.gridColumn7.VisibleIndex = 6;
			// 
			// gridColumn9
			// 
			this.gridColumn9.Caption = "ThanhTien";
			this.gridColumn9.FieldName = "ThanhTien";
			this.gridColumn9.Name = "gridColumn9";
			this.gridColumn9.Visible = true;
			this.gridColumn9.VisibleIndex = 7;
			// 
			// UCHoaDon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl1);
			this.Name = "UCHoaDon";
			this.Size = new System.Drawing.Size(770, 422);
			this.Load += new System.EventHandler(this.UCHoaDon_Load);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvDSHD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraGrid.GridControl gridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView gvDSHD;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
	}
}
