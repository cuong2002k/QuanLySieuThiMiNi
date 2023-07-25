namespace QuanLySieuThiMini
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
			this.txtPassword = new DevExpress.XtraEditors.TextEdit();
			this.txtUserName = new DevExpress.XtraEditors.TextEdit();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutcontrol = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutcontrol)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.layoutControl2);
			this.layoutControl1.Controls.Add(this.btnLogin);
			this.layoutControl1.Controls.Add(this.txtPassword);
			this.layoutControl1.Controls.Add(this.txtUserName);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.Root;
			this.layoutControl1.Size = new System.Drawing.Size(328, 95);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// layoutControl2
			// 
			this.layoutControl2.Location = new System.Drawing.Point(226, 60);
			this.layoutControl2.Name = "layoutControl2";
			this.layoutControl2.Root = this.layoutControlGroup1;
			this.layoutControl2.Size = new System.Drawing.Size(90, 23);
			this.layoutControl2.TabIndex = 7;
			this.layoutControl2.Text = "layoutControl2";
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(90, 23);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(103, 60);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(119, 22);
			this.btnLogin.StyleController = this.layoutControl1;
			this.btnLogin.TabIndex = 6;
			this.btnLogin.Text = "Đăng Nhập";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(99, 36);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Properties.UseSystemPasswordChar = true;
			this.txtPassword.Size = new System.Drawing.Size(217, 20);
			this.txtPassword.StyleController = this.layoutControl1;
			this.txtPassword.TabIndex = 5;
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(99, 12);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(217, 20);
			this.txtUserName.StyleController = this.layoutControl1;
			this.txtUserName.TabIndex = 4;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutcontrol,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.emptySpaceItem1});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(328, 95);
			this.Root.TextVisible = false;
			// 
			// layoutcontrol
			// 
			this.layoutcontrol.Control = this.txtUserName;
			this.layoutcontrol.Location = new System.Drawing.Point(0, 0);
			this.layoutcontrol.Name = "layoutcontrol";
			this.layoutcontrol.Size = new System.Drawing.Size(308, 24);
			this.layoutcontrol.Text = "Tên Đăng Nhập";
			this.layoutcontrol.TextSize = new System.Drawing.Size(75, 13);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.txtPassword;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(308, 24);
			this.layoutControlItem2.Text = "Mật Khẩu";
			this.layoutControlItem2.TextSize = new System.Drawing.Size(75, 13);
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.btnLogin;
			this.layoutControlItem3.Location = new System.Drawing.Point(91, 48);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(123, 27);
			this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem3.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.layoutControl2;
			this.layoutControlItem1.Location = new System.Drawing.Point(214, 48);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(94, 27);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// emptySpaceItem1
			// 
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.Location = new System.Drawing.Point(0, 48);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new System.Drawing.Size(91, 27);
			this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(328, 95);
			this.Controls.Add(this.layoutControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Login.IconOptions.Image")));
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng Nhập";
			this.Load += new System.EventHandler(this.Login_Load);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutcontrol)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraEditors.SimpleButton btnLogin;
		private DevExpress.XtraEditors.TextEdit txtPassword;
		private DevExpress.XtraEditors.TextEdit txtUserName;
		private DevExpress.XtraLayout.LayoutControlItem layoutcontrol;
		private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControl layoutControl2;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
	}
}