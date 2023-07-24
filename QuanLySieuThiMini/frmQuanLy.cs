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
using QuanLySieuThiMini.Chard;
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
		ChardTongQuan uctq;
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

		private void accordionControlElement5_Click(object sender, EventArgs e)
		{
			DialogResult r = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo);

			if (r == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void btnTongQuan_Click(object sender, EventArgs e)
		{
			if (uctq == null)
			{
				uctq = new ChardTongQuan();
				uctq.Dock = DockStyle.Fill;
				MainControl.Controls.Add(uctq);
				uctq.BringToFront();
			}
			else
			{
				uctq.BringToFront();
			}
		}
	}
}
