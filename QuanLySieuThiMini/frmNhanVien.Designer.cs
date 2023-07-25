namespace QuanLySieuThiMini
{
	partial class frmNhanVien
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
			this.MainControl = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
			this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
			this.btnBanHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.btnHangHoa = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.btnThoat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
			this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
			((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// MainControl
			// 
			this.MainControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainControl.Location = new System.Drawing.Point(157, 31);
			this.MainControl.Name = "MainControl";
			this.MainControl.Size = new System.Drawing.Size(534, 442);
			this.MainControl.TabIndex = 0;
			// 
			// accordionControl1
			// 
			this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnBanHang,
            this.accordionControlElement2,
            this.btnHangHoa,
            this.btnThoat});
			this.accordionControl1.Location = new System.Drawing.Point(0, 31);
			this.accordionControl1.Name = "accordionControl1";
			this.accordionControl1.Size = new System.Drawing.Size(157, 442);
			this.accordionControl1.TabIndex = 1;
			this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
			// 
			// btnBanHang
			// 
			this.btnBanHang.Name = "btnBanHang";
			this.btnBanHang.Text = "Bán Hàng";
			this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
			// 
			// accordionControlElement2
			// 
			this.accordionControlElement2.Name = "accordionControlElement2";
			this.accordionControlElement2.Text = "Khách Hàng";
			this.accordionControlElement2.Click += new System.EventHandler(this.accordionControlElement2_Click);
			// 
			// btnHangHoa
			// 
			this.btnHangHoa.Name = "btnHangHoa";
			this.btnHangHoa.Text = "Hàng Hóa";
			this.btnHangHoa.Click += new System.EventHandler(this.btnHangHoa_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Text = "Thoát";
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// fluentDesignFormControl1
			// 
			this.fluentDesignFormControl1.FluentDesignForm = this;
			this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
			this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
			this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
			this.fluentDesignFormControl1.Size = new System.Drawing.Size(691, 31);
			this.fluentDesignFormControl1.TabIndex = 2;
			this.fluentDesignFormControl1.TabStop = false;
			// 
			// fluentFormDefaultManager1
			// 
			this.fluentFormDefaultManager1.Form = this;
			// 
			// frmNhanVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(691, 473);
			this.ControlContainer = this.MainControl;
			this.Controls.Add(this.MainControl);
			this.Controls.Add(this.accordionControl1);
			this.Controls.Add(this.fluentDesignFormControl1);
			this.FluentDesignFormControl = this.fluentDesignFormControl1;
			this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmNhanVien.IconOptions.Image")));
			this.Name = "frmNhanVien";
			this.NavigationControl = this.accordionControl1;
			this.Text = "Quản Lý Siêu Thị Mini";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer MainControl;
		private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
		private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
		private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
		private DevExpress.XtraBars.Navigation.AccordionControlElement btnBanHang;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
		private DevExpress.XtraBars.Navigation.AccordionControlElement btnHangHoa;
		private DevExpress.XtraBars.Navigation.AccordionControlElement btnThoat;
	}
}