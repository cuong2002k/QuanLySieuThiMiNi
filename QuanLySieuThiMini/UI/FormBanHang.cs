using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL;
using BUS;
using DevExpress.XtraReports.UI;

namespace QuanLySieuThiMini.UI
{
	public partial class FormBanHang : DevExpress.XtraEditors.XtraForm
	{
		BUS_HoaDon bushd = new BUS_HoaDon();
		BUS_NhanVien nv = new BUS_NhanVien();
		BUS_KhachHang buskh = new BUS_KhachHang();
		public static FormBanHang instance;
		public int TongTien;
		int MaNV = 3;
		public FormBanHang()
		{
			instance = this;
			InitializeComponent();
		}

		private void FormBanHang_Load(object sender, EventArgs e)
		{
			load();
		}

		void load()
		{
			txtTongTien.Text = TongTien.ToString();
			txtVAT.Text = 0.ToString();
		}
		bool check()
		{
			if(string.IsNullOrEmpty(txtTienKhachDua.Text))
			{
				MessageBox.Show("Tiền Khách Đưa Không Được Trống !!!");
				return false;
			}

			int Money = int.Parse(txtTienKhachDua.Text);
			int TMoney = TongTien;
			if (Money < TongTien)
			{
				MessageBox.Show("Tiền Khách Đưa Không Được Nhỏ Hơn Số Tiền Thanh Toán !!!");
				return false;
			}

			
			return true;
		}
		private void btnThanhToan_Click(object sender, EventArgs e)
		{
			if(!check())
			{
				return;
			}
			HoaDon hd = new HoaDon();
			if(string.IsNullOrEmpty(txtTenKhach.Text))
			{
				hd.MaNV = MaNV;
				hd.NgayLap = DateTime.Now;
				hd.MaKH = -1;
				hd.VAT = int.Parse(txtVAT.Text.Trim());
				hd.TienKhachDua = int.Parse(txtTienKhachDua.Text.Trim());
				hd.TienGuiKhach = (hd.TienKhachDua - TongTien);
				hd.TongTienKM = 0;
				hd.ThanhTien = TongTien;
				bushd.ThemHoaDon(hd);
				HoaDonRp rp = new HoaDonRp();
				rp.txtTenNv.Text = nv.timNhanvien(MaNV).TenNV;
				rp.txtNgay.Text = DateTime.Now.ToString("dd/MM/yyyy");
				rp.txtmaHd.Text = hd.SoHD.ToString();
				rp.DataSource = UCBanHang.instance.getdata();
				rp.txtTongTien.Text = TongTien.ToString();
				UCBanHang.instance.AddHoaDonCT(hd.SoHD);
				ReportPrintTool revew = new ReportPrintTool(rp);
				revew.ShowPreview();
				this.Close();
			}
			else
			{
				hd.MaNV = MaNV;
				hd.NgayLap = DateTime.Now;
				string sdt = txtSDT.Text.Trim();
				KhachHang kh = buskh.TimKhachHang(sdt);
				hd.MaKH = kh.MaKH;
				hd.VAT = int.Parse(txtVAT.Text.Trim());
				hd.TienKhachDua = int.Parse(txtTienKhachDua.Text.Trim());
				hd.TienGuiKhach = (hd.TienKhachDua - TongTien);
				hd.TongTienKM = 0;
				hd.ThanhTien = TongTien;
				bushd.ThemHoaDon(hd);
				HoaDonRp rp = new HoaDonRp();
				rp.txtTenNv.Text = "Tên Nhân Viên: " + nv.timNhanvien(MaNV).TenNV;
				rp.txtNgay.Text =  "Ngày Xuất: " + DateTime.Now.ToString("dd/MM/yyyy");
				rp.txtmaHd.Text =  "Số Hóa Đơn: " + hd.SoHD.ToString();
				rp.txtTongTien.Text = TongTien.ToString();
				UCBanHang.instance.AddHoaDonCT(hd.SoHD);
				rp.DataSource = UCBanHang.instance.getdata();
				ReportPrintTool revew = new ReportPrintTool(rp);
				revew.ShowPreview();
				this.Close();
			}
			UCBanHang.instance.Restart();
		}

		private void txtSDT_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				if(string.IsNullOrEmpty(txtSDT.Text))
				{
					MessageBox.Show("Vui lòng nhập SDT khách Hàng");
				}
				string sdt = txtSDT.Text.Trim();
				KhachHang kh = buskh.TimKhachHang(sdt);
				if(kh == null)
				{
					MessageBox.Show("Khách Hàng không Tồn Tại !!!");
				}
				else
				{
					txtTenKhach.Text = kh.TenKH;
					txtSDT.Enabled = false;
					txtSDT.ReadOnly = true;
				}

			}
		}
	}
}