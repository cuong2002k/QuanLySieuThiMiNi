namespace QuanLySieuThiMini.UI
{
	partial class FormBanHang
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
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.btnThanhToan = new DevExpress.XtraEditors.SimpleButton();
			this.txtVAT = new System.Windows.Forms.TextBox();
			this.txtTenKhach = new System.Windows.Forms.TextBox();
			this.txtTienKhachDua = new System.Windows.Forms.TextBox();
			this.txtTongTien = new System.Windows.Forms.TextBox();
			this.txtSDT = new System.Windows.Forms.TextBox();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.btnThanhToan);
			this.layoutControl1.Controls.Add(this.txtVAT);
			this.layoutControl1.Controls.Add(this.txtTenKhach);
			this.layoutControl1.Controls.Add(this.txtTienKhachDua);
			this.layoutControl1.Controls.Add(this.txtTongTien);
			this.layoutControl1.Controls.Add(this.txtSDT);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.Root;
			this.layoutControl1.Size = new System.Drawing.Size(495, 188);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// btnThanhToan
			// 
			this.btnThanhToan.Appearance.BackColor = System.Drawing.Color.SteelBlue;
			this.btnThanhToan.Appearance.Options.UseBackColor = true;
			this.btnThanhToan.Location = new System.Drawing.Point(170, 132);
			this.btnThanhToan.Name = "btnThanhToan";
			this.btnThanhToan.Size = new System.Drawing.Size(157, 44);
			this.btnThanhToan.StyleController = this.layoutControl1;
			this.btnThanhToan.TabIndex = 9;
			this.btnThanhToan.Text = "Thanh Toán";
			this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
			// 
			// txtVAT
			// 
			this.txtVAT.Location = new System.Drawing.Point(146, 108);
			this.txtVAT.Name = "txtVAT";
			this.txtVAT.Size = new System.Drawing.Size(337, 20);
			this.txtVAT.TabIndex = 8;
			this.txtVAT.Text = "0";
			// 
			// txtTenKhach
			// 
			this.txtTenKhach.Enabled = false;
			this.txtTenKhach.Location = new System.Drawing.Point(146, 36);
			this.txtTenKhach.Name = "txtTenKhach";
			this.txtTenKhach.ReadOnly = true;
			this.txtTenKhach.Size = new System.Drawing.Size(337, 20);
			this.txtTenKhach.TabIndex = 7;
			// 
			// txtTienKhachDua
			// 
			this.txtTienKhachDua.Location = new System.Drawing.Point(146, 84);
			this.txtTienKhachDua.Name = "txtTienKhachDua";
			this.txtTienKhachDua.Size = new System.Drawing.Size(337, 20);
			this.txtTienKhachDua.TabIndex = 6;
			// 
			// txtTongTien
			// 
			this.txtTongTien.Enabled = false;
			this.txtTongTien.Location = new System.Drawing.Point(146, 60);
			this.txtTongTien.Name = "txtTongTien";
			this.txtTongTien.ReadOnly = true;
			this.txtTongTien.Size = new System.Drawing.Size(337, 20);
			this.txtTongTien.TabIndex = 5;
			// 
			// txtSDT
			// 
			this.txtSDT.Location = new System.Drawing.Point(146, 12);
			this.txtSDT.Name = "txtSDT";
			this.txtSDT.Size = new System.Drawing.Size(337, 20);
			this.txtSDT.TabIndex = 4;
			this.txtSDT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSDT_KeyDown);
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem2});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(495, 188);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.txtSDT;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(475, 24);
			this.layoutControlItem1.Text = "Số Điện Thoại";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(122, 13);
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.Location = new System.Drawing.Point(319, 120);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(156, 48);
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.txtTongTien;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(475, 24);
			this.layoutControlItem2.Text = "Tổng Số Tiền Thanh Toán";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(122, 13);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.txtTienKhachDua;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 72);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(475, 24);
			this.layoutControlItem3.Text = "Tiền Khách Đưa";
			this.layoutControlItem3.TextSize = new System.Drawing.Size(122, 13);
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.txtTenKhach;
			this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(475, 24);
			this.layoutControlItem4.Text = "Tên Khách Hàng";
			this.layoutControlItem4.TextSize = new System.Drawing.Size(122, 13);
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.txtVAT;
			this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(475, 24);
			this.layoutControlItem5.Text = "VAT";
			this.layoutControlItem5.TextSize = new System.Drawing.Size(122, 13);
			// 
			// layoutControlItem6
			// 
			this.layoutControlItem6.Control = this.btnThanhToan;
			this.layoutControlItem6.Location = new System.Drawing.Point(158, 120);
			this.layoutControlItem6.MinSize = new System.Drawing.Size(78, 26);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new System.Drawing.Size(161, 48);
			this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem6.TextVisible = false;
			// 
			// emptySpaceItem2
			// 
			this.emptySpaceItem2.AllowHotTrack = false;
			this.emptySpaceItem2.Location = new System.Drawing.Point(0, 120);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new System.Drawing.Size(158, 48);
			this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
			// 
			// FormBanHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(495, 188);
			this.Controls.Add(this.layoutControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormBanHang";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormBanHang";
			this.Load += new System.EventHandler(this.FormBanHang_Load);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraEditors.SimpleButton btnThanhToan;
		private System.Windows.Forms.TextBox txtVAT;
		private System.Windows.Forms.TextBox txtTenKhach;
		private System.Windows.Forms.TextBox txtTienKhachDua;
		private System.Windows.Forms.TextBox txtTongTien;
		private System.Windows.Forms.TextBox txtSDT;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
	}
}