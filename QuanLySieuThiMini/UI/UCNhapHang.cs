using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using BUS;
using DAL;
namespace QuanLySieuThiMini.UI
{
	public partial class UCNhapHang : UserControl
	{
		int MANV = 3;
		public UCNhapHang()
		{
			InitializeComponent();
			this.Dock = DockStyle.Fill;
		}
		private BUS_HangHoa bushh = new BUS_HangHoa();
		private void btnNhapFile_Click(object sender, EventArgs e)
		{
			try
			{
				if (openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					using (OleDbConnection myConnect = new OleDbConnection(string.Format(@"provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0;", openFileDialog1.FileName)))
					{
						DataTable dt = new DataTable();
						OleDbDataAdapter cmd = new OleDbDataAdapter("select * from [Sheet1$]", myConnect);
						cmd.Fill(dt);
						grDsHangNhap.DataSource = dt;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			try
			{
				int rowCount = gvHangNhap.RowCount;
				PhieuNhapHang hd = new PhieuNhapHang();
				hd.MaNV = MANV;
				hd.NgayTao = DateTime.Now;
				// Lặp qua từng dòng trong GridView
				for (int i = 0; i < rowCount; i++)
				{
					// Lấy dữ liệu từng dòng
					var row = gvHangNhap.GetRow(i);
					var TenHang = gvHangNhap.GetRowCellValue(i, "TenHang");
					var MaNH = gvHangNhap.GetRowCellValue(i, "MaNH");
					var XuatXu = gvHangNhap.GetRowCellValue(i, "XuatXu");
					var GiaNhap = gvHangNhap.GetRowCellValue(i, "GiaNhap");
					var GiaBan = gvHangNhap.GetRowCellValue(i, "GiaBan");
					var DonViTinh = gvHangNhap.GetRowCellValue(i, "DonViTinh");
					var NhaCungCap = gvHangNhap.GetRowCellValue(i, "NhaCungCap");
					var MaVach = gvHangNhap.GetRowCellValue(i, "MaVach");
					var SoLuong = gvHangNhap.GetRowCellValue(i, "SoLuong");
					var DinhMuc = gvHangNhap.GetRowCellValue(i, "DinhMuc");
					var VAT = gvHangNhap.GetRowCellValue(i, "VAT");
					var TrangThaiBan = gvHangNhap.GetRowCellValue(i, "TrangThaiBan");

					HangHoa hanghoa = new HangHoa();

					hanghoa.TenHang = TenHang.ToString();
					hanghoa.MaNH = int.Parse(MaNH.ToString());
					hanghoa.XuatXu = XuatXu.ToString();
					hanghoa.GiaNhap = int.Parse(GiaNhap.ToString());
					hanghoa.GiaBan = int.Parse(GiaBan.ToString());
					hanghoa.DonViTinh = DonViTinh.ToString();
					hanghoa.NhaCungCap = int.Parse(NhaCungCap.ToString());
					hanghoa.MaVach = MaVach.ToString();
					hanghoa.SoLuong = int.Parse(SoLuong.ToString());
					hanghoa.DinhMuc = int.Parse(DinhMuc.ToString());
					hanghoa.VAT = int.Parse(VAT.ToString());
					hanghoa.TrangThaiBan = TrangThaiBan.ToString() == "1" ? true : false;


					bushh = new BUS_HangHoa();
					if (bushh.TimHangHoaTheoMaVach(hanghoa.MaVach) != null)
					{
						HangHoa fhanghoa = bushh.TimHangHoaTheoMaVach(hanghoa.MaVach);
						fhanghoa.SoLuong += hanghoa.SoLuong;
						bushh.SuaHangHoa(fhanghoa);
					}
					else
					{
						bushh.AddHangHoa(hanghoa);
					}
				}
				MessageBox.Show("Thêm Hàng Hóa Thành Công!!");
				grDsHangNhap.DataSource = null;
			}
			catch(Exception ex)
			{
				MessageBox.Show("Vui Lòng kiểm tra File!!");
			}

		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			grDsHangNhap.DataSource = null;
		}
	}
}
