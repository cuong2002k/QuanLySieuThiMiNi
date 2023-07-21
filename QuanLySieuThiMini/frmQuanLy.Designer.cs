namespace QuanLySieuThiMini
{
	partial class frmQuanLy
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
			this.MainControl = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
			this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
			this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.btnKhachHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.btnNhanVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
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
			this.MainControl.Location = new System.Drawing.Point(260, 31);
			this.MainControl.Name = "MainControl";
			this.MainControl.Size = new System.Drawing.Size(431, 442);
			this.MainControl.TabIndex = 0;
			// 
			// accordionControl1
			// 
			this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.btnKhachHang,
            this.btnNhanVien,
            this.accordionControlElement4,
            this.accordionControlElement5});
			this.accordionControl1.Location = new System.Drawing.Point(0, 31);
			this.accordionControl1.Name = "accordionControl1";
			this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
			this.accordionControl1.Size = new System.Drawing.Size(260, 442);
			this.accordionControl1.TabIndex = 1;
			this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
			// 
			// accordionControlElement1
			// 
			this.accordionControlElement1.Name = "accordionControlElement1";
			this.accordionControlElement1.Text = "Tổng quan";
			// 
			// btnKhachHang
			// 
			this.btnKhachHang.Name = "btnKhachHang";
			this.btnKhachHang.Text = "Khách Hàng";
			this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
			// 
			// btnNhanVien
			// 
			this.btnNhanVien.Name = "btnNhanVien";
			this.btnNhanVien.Text = "Nhân Viên";
			this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
			// 
			// accordionControlElement4
			// 
			this.accordionControlElement4.Name = "accordionControlElement4";
			this.accordionControlElement4.Text = "Hóa đơn";
			// 
			// accordionControlElement5
			// 
			this.accordionControlElement5.Name = "accordionControlElement5";
			this.accordionControlElement5.Text = "Thoát";
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
			// frmQuanLy
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(691, 473);
			this.ControlContainer = this.MainControl;
			this.Controls.Add(this.MainControl);
			this.Controls.Add(this.accordionControl1);
			this.Controls.Add(this.fluentDesignFormControl1);
			this.FluentDesignFormControl = this.fluentDesignFormControl1;
			this.Name = "frmQuanLy";
			this.NavigationControl = this.accordionControl1;
			this.Text = "Quản lý siêu thị mini";
			((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer MainControl;
		private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
		private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
		private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
		private DevExpress.XtraBars.Navigation.AccordionControlElement btnKhachHang;
		private DevExpress.XtraBars.Navigation.AccordionControlElement btnNhanVien;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
	}
}