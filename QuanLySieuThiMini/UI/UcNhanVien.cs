using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
namespace QuanLySieuThiMini.UI
{
	public partial class UCNhanVien : DevExpress.XtraEditors.XtraUserControl
	{
		BUS_NhanVien busnv = new BUS_NhanVien();
		public static UCNhanVien instance;
		int MaNV;
		public UCNhanVien()
		{
			instance = this;
			InitializeComponent();
		}

		private void UCNhanVien_Load(object sender, EventArgs e)
		{
			loaddata();
		}

		public void loaddata()
		{
			BUS_NhanVien busnv = new BUS_NhanVien();
			grcontrol.DataSource = busnv.getall();
			scSearch.Client = grcontrol;
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			NewNhanVien frm = new NewNhanVien();
			NewNhanVien.instance.Snhanvien = busnv.timNhanvien(MaNV);
			frm.Show();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			DialogResult r = MessageBox.Show("Bạn có muốn xóa nhân viên này không ?", "Thông báo", MessageBoxButtons.YesNo);
			if(r == DialogResult.Yes)
			{
				try
				{
					busnv.XoaNhanVien(MaNV);
					MessageBox.Show("Xóa nhân viên thành công!!!");
					loaddata();
				}
				catch(Exception ex)
				{
					MessageBox.Show("Xóa nhân viên không thành công!!!");
				}
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			NewNhanVien frm = new NewNhanVien();
			NewNhanVien.instance.Snhanvien = null;
			frm.Show();

		}

		private void dvDSNhanVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			if(dvDSNhanVien.RowCount > 0 )
			{
				MaNV = int.Parse(dvDSNhanVien.GetFocusedRowCellValue("MaNV").ToString());
				

			}
		}
	}
}
