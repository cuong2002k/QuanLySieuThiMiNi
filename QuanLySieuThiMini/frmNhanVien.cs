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
		//UCHangHoaNV uCHangHoaNV;
		//UCKhachHangNV uCKhachHangNV;
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

		private void btnHangHoa_Click(object sender, EventArgs e)
		{
			//if (uCHangHoaNV == null)
			//{
			//	uCHangHoaNV = new UCHangHoaNV();
			//	uCHangHoaNV.Dock = DockStyle.Fill;
			//	MainControl.Controls.Add(uCHangHoaNV);
			//	uCHangHoaNV.BringToFront();
			//}
			//else
			//{
			//	uCHangHoaNV.BringToFront();
			//}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			DialogResult r = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo);

			if(r == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void accordionControlElement2_Click(object sender, EventArgs e)
		{
			//if (uCKhachHangNV == null)
			//{
			//	uCKhachHangNV = new UCKhachHangNV();
			//	uCKhachHangNV.Dock = DockStyle.Fill;
			//	MainControl.Controls.Add(uCKhachHangNV);
			//	uCKhachHangNV.BringToFront();
			//}
			//else
			//{
			//	uCKhachHangNV.BringToFront();
			//}
		}
	}
}
