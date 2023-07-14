using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;
namespace QuanLySieuThiMini.UI
{
	public partial class UCHangHoa : UserControl
	{
		HangHoa hh = new HangHoa();
		BUS.BUS_HangHoa bushanghoa = new BUS.BUS_HangHoa();
		public UCHangHoa()
		{
			InitializeComponent();
		}

		private void UCHangHoa_Load(object sender, EventArgs e)
		{
			LoadDSHangHoa();
		}

		private void btnThemHangHoa_Click(object sender, EventArgs e)
		{
			NewHangHoa ucnew = new NewHangHoa();
			ucnew.Show();
		}

		public void LoadDSHangHoa()
		{
			
			grcontrol.DataSource = bushanghoa.getall();
			scHanghoa.Client = grcontrol;
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			LoadDSHangHoa();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có muốn xóa không", "Thông Báo", MessageBoxButtons.YesNo);
			if(result == DialogResult.Yes)
			{
				bushanghoa.XoaHangHoa(hh);
				LoadDSHangHoa();
				MessageBox.Show("Xóa Hàng Hóa Thành Công!!!");
			}
		}

	

		private void dvDSHangHoa_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			hh.MaHH = int.Parse(dvDSHangHoa.GetFocusedRowCellValue("MaHH").ToString());
			hh.TenHang = dvDSHangHoa.GetFocusedRowCellValue("TenHang").ToString();
			hh.MaNH = int.Parse(dvDSHangHoa.GetFocusedRowCellValue("MaHH").ToString());
			hh.XuatXu = dvDSHangHoa.GetFocusedRowCellValue("XuatXu").ToString();
			hh.GiaNhap = int.Parse(dvDSHangHoa.GetFocusedRowCellValue("GiaNhap").ToString());
			hh.GiaBan = int.Parse(dvDSHangHoa.GetFocusedRowCellValue("GiaBan").ToString());
			hh.DonViTinh = dvDSHangHoa.GetFocusedRowCellValue("DonViTinh").ToString();
			hh.NhaCungCap = int.Parse(dvDSHangHoa.GetFocusedRowCellValue("NhaCungCap").ToString());
			hh.MaVach = dvDSHangHoa.GetFocusedRowCellValue("MaVach").ToString();
			hh.SoLuong = int.Parse(dvDSHangHoa.GetFocusedRowCellValue("SoLuong").ToString());
			hh.DinhMuc = int.Parse(dvDSHangHoa.GetFocusedRowCellValue("DinhMuc").ToString());
			hh.VAT = int.Parse(dvDSHangHoa.GetFocusedRowCellValue("VAT").ToString());
			hh.TrangThaiBan = bool.Parse(dvDSHangHoa.GetFocusedRowCellValue("TrangThaiBan").ToString());
			
		}

		private void dvDSHangHoa_DoubleClick(object sender, EventArgs e)
		{
			NewHangHoa ucnew = new NewHangHoa();
			ucnew.Show();
		}
	}
}
