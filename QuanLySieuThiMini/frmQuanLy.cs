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
	public partial class frmQuanLy : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
	{
		public frmQuanLy()
		{
			InitializeComponent();
		}
		UCKhachHang ucKhachHang;
		UCNhanVien ucNhanVien;
		private void btnKhachHang_Click(object sender, EventArgs e)
		{
			if (ucKhachHang == null)
			{
				ucKhachHang = new UCKhachHang();
				ucKhachHang.Dock = DockStyle.Fill;
				MainControl.Controls.Add(ucKhachHang);
				ucKhachHang.BringToFront();
			}
			else
			{
				ucKhachHang.BringToFront();
			}
		}

		private void btnNhanVien_Click(object sender, EventArgs e)
		{
			if (ucNhanVien == null)
			{
				ucNhanVien = new UCNhanVien();
				ucNhanVien.Dock = DockStyle.Fill;
				MainControl.Controls.Add(ucNhanVien);
				ucNhanVien.BringToFront();
			}
			else
			{
				ucNhanVien.BringToFront();
			}
		}
	}
}
