namespace QuanLySieuThiMini
{
	partial class frmQuanLyKho
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
			DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyKho));
			this.MainContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
			this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
			this.btnHangHoa = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.btnNhaCungCap = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.btnNhapHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
			this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
			accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// accordionControlElement6
			// 
			accordionControlElement6.Name = "accordionControlElement6";
			accordionControlElement6.Text = "Thoát";
			// 
			// MainContainer
			// 
			this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainContainer.Location = new System.Drawing.Point(260, 31);
			this.MainContainer.Name = "MainContainer";
			this.MainContainer.Size = new System.Drawing.Size(554, 442);
			this.MainContainer.TabIndex = 0;
			// 
			// accordionControl1
			// 
			this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnHangHoa,
            this.btnNhaCungCap,
            this.accordionControlElement3,
            this.btnNhapHang,
            this.accordionControlElement5,
            accordionControlElement6});
			this.accordionControl1.Location = new System.Drawing.Point(0, 31);
			this.accordionControl1.Name = "accordionControl1";
			this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
			this.accordionControl1.Size = new System.Drawing.Size(260, 442);
			this.accordionControl1.TabIndex = 1;
			this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
			// 
			// btnHangHoa
			// 
			this.btnHangHoa.Name = "btnHangHoa";
			this.btnHangHoa.Text = "Hàng Hóa";
			this.btnHangHoa.Click += new System.EventHandler(this.btnHangHoa_Click);
			// 
			// btnNhaCungCap
			// 
			this.btnNhaCungCap.Name = "btnNhaCungCap";
			this.btnNhaCungCap.Text = "Nhà Cung Cấp";
			this.btnNhaCungCap.Click += new System.EventHandler(this.btnNhaCungCap_Click);
			// 
			// accordionControlElement3
			// 
			this.accordionControlElement3.Name = "accordionControlElement3";
			this.accordionControlElement3.Text = "Nhóm Hàng";
			this.accordionControlElement3.Click += new System.EventHandler(this.accordionControlElement3_Click);
			// 
			// btnNhapHang
			// 
			this.btnNhapHang.Name = "btnNhapHang";
			this.btnNhapHang.Text = "Nhập Hàng";
			this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
			// 
			// accordionControlElement5
			// 
			this.accordionControlElement5.Name = "accordionControlElement5";
			this.accordionControlElement5.Text = "Trả Hàng";
			// 
			// fluentDesignFormControl1
			// 
			this.fluentDesignFormControl1.FluentDesignForm = this;
			this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
			this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
			this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
			this.fluentDesignFormControl1.Size = new System.Drawing.Size(814, 31);
			this.fluentDesignFormControl1.TabIndex = 2;
			this.fluentDesignFormControl1.TabStop = false;
			// 
			// fluentFormDefaultManager1
			// 
			this.fluentFormDefaultManager1.Form = this;
			// 
			// frmQuanLyKho
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(814, 473);
			this.ControlContainer = this.MainContainer;
			this.Controls.Add(this.MainContainer);
			this.Controls.Add(this.accordionControl1);
			this.Controls.Add(this.fluentDesignFormControl1);
			this.FluentDesignFormControl = this.fluentDesignFormControl1;
			this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmQuanLyKho.IconOptions.SvgImage")));
			this.Name = "frmQuanLyKho";
			this.NavigationControl = this.accordionControl1;
			this.Text = "Quản Lý Siêu Thị Mini";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmQuanLyKho_Load);
			((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer MainContainer;
		private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
		private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
		private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
		private DevExpress.XtraBars.Navigation.AccordionControlElement btnHangHoa;
		private DevExpress.XtraBars.Navigation.AccordionControlElement btnNhaCungCap;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
		private DevExpress.XtraBars.Navigation.AccordionControlElement btnNhapHang;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
	}
}

