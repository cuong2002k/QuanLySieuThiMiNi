using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLySieuThiMini.UI;
namespace QuanLySieuThiMini
{
	public partial class frmNhanVien : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
	{
		public frmNhanVien()
		{
			InitializeComponent();
		}

		private void accordionControlElement1_Click(object sender, EventArgs e)
		{

		}
		UCBanHang ucbanhang;
		private void btnBanHang_Click(object sender, EventArgs e)
		{
			if (ucbanhang == null)
			{
				ucbanhang = new UCBanHang();
				ucbanhang.Dock = DockStyle.Fill;
				MainControl.Controls.Add(ucbanhang);
				ucbanhang.BringToFront();
			}
			else
			{
				ucbanhang.BringToFront();
			}
		}
	}
}
