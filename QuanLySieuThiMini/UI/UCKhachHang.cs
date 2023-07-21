using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
namespace QuanLySieuThiMini.UI
{
	public partial class UCKhachHang : UserControl
	{
		BUS_KhachHang buskh = new BUS_KhachHang();
		public static UCKhachHang instance;
		int MaKH;
		KhachHang sKhachHang;
		public UCKhachHang()
		{
			instance = this;
			InitializeComponent();
		}

		private void UCKhachHang_Load(object sender, EventArgs e)
		{
			loadData();
		}

		public void loadData()
		{
			buskh = new BUS_KhachHang();
			grcontrol.DataSource = buskh.getall();
			scSearch.Client = grcontrol;
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			NewKhachHang frm = new NewKhachHang();
			NewKhachHang.instance.cKhachHang = null;
			frm.Show();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			NewKhachHang frm = new NewKhachHang();
			sKhachHang = buskh.TimKhachHang(MaKH);
			NewKhachHang.instance.cKhachHang = sKhachHang;
			frm.Show();
		}

		private void dvDSKhachHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			if(dvDSKhachHang.RowCount > 0)
			{
				MaKH = int.Parse(dvDSKhachHang.GetFocusedRowCellValue("MaKH").ToString());
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			DialogResult r = MessageBox.Show("Bạn có muốn Xóa Khách Hàng không ?", "Thông báo", MessageBoxButtons.YesNo);
			if (r == DialogResult.Yes)
			{
				try
				{
					buskh.XoaKhachHang(MaKH);
					MessageBox.Show("Xóa Khách Hàng Thành Công");
					loadData();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Xóa Khách Hàng Không Thành Công");
				}
			}
		}
	}
}
