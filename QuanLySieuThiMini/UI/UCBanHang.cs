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
using DAL;
namespace QuanLySieuThiMini.UI
{
	public partial class UCBanHang : DevExpress.XtraEditors.XtraUserControl
	{
		BUS_HangHoa bushh = new BUS_HangHoa();
		BUS_HoaDon bushd = new BUS_HoaDon();
		List<HangBan> lstHangBan;
		int MANV = 1;
		int stt = 1;
		int MaHH;
		int TongTien = 0;

		public static UCBanHang instance;
		public UCBanHang()
		{
			instance = this;
			InitializeComponent();
		}

		private void UCBanHang_Load(object sender, EventArgs e)
		{
			LoadData();
			if (lstHangBan == null) lstHangBan = new List<HangBan>();
		}

		void LoadData()
		{
			grDsHH.DataSource = bushh.getall();

		}

		void LoadHHBan()
		{
			grDSHHBan.DataSource = null;
			grDSHHBan.DataSource = lstHangBan;
			TongTien = 0;
			foreach (HangBan item in lstHangBan)
			{
				TongTien += item.tongtien;
			}
			lbTongTien.Text = TongTien.ToString();
		}

		public void Restart()
		{
			grDSHHBan.DataSource = null;
			lstHangBan.Clear();
			grDSHHBan.DataSource = lstHangBan;
			TongTien = 0;
			lbTongTien.Text = TongTien.ToString();
		}

		private void gvDSHH_DoubleClick(object sender, EventArgs e)
		{
			
		}
		private void gvDSHH_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			if(gvDSHH.RowCount > 0)
			{
				MaHH = int.Parse(gvDSHH.GetFocusedRowCellValue("MaHH").ToString());
			}
		}

		private void gvDSHH_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter && txtBarcode.Text == "") 
			{
				if (gvDSHH.RowCount > 0)
				{
					HangHoa hh;
					hh = bushh.TimHangHoaTheoMAHH(MaHH);
					if (hh != null)
					{
						int stt = lstHangBan.Count + 1;
						string name = hh.TenHang;
						string dvt = hh.DonViTinh;
						int soluong = 1;
						int dongia = hh.GiaBan.HasValue ? hh.GiaBan.Value : 0;
						int VAT = hh.VAT.HasValue ? hh.VAT.Value : 0;
						HangBan hb = new HangBan(stt, name, dvt, soluong, dongia, VAT, hh.MaHH);
						bool check = true;
						foreach (HangBan item in lstHangBan)
						{
							if (item.mahh == hb.mahh)
							{
								if (item.soluong + 1 > hh.SoLuong)
								{
									MessageBox.Show("Số Hàng Không Được Lớn Hơn Số Lượng Hiện Tại!!!");
									return;
								}
								item.UpdataTien(hb.soluong);
								check = false;
								LoadHHBan();
							}
						}
						if (check)
						{
							lstHangBan.Add(hb);
							LoadHHBan();
						}

					}
				}
			}
		}

		private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter && txtBarcode.Text != "")
			{

					HangHoa hh;
					hh = bushh.TimHangHoaTheoMaVach(txtBarcode.Text.Trim());
					if (hh != null)
					{
						int stt = lstHangBan.Count + 1;
						string name = hh.TenHang;
						string dvt = hh.DonViTinh;
						int soluong = 1;
						int dongia = hh.GiaBan.HasValue ? hh.GiaBan.Value : 0;
						int VAT = hh.VAT.HasValue ? hh.VAT.Value : 0;
						HangBan hb = new HangBan(stt, name, dvt, soluong, dongia, VAT, hh.MaHH);
						bool check = true;
						foreach (HangBan item in lstHangBan)
						{
							if (item.mahh == hb.mahh)
							{
								if(item.soluong + 1 > hh.SoLuong)
								{
									MessageBox.Show("Số Hàng Không Được Lớn Hơn Số Lượng Hiện Tại!!!");
									return;
								}
								item.UpdataTien(hb.soluong);
								check = false;
								LoadHHBan();
							}
						}
						if (check)
						{
							lstHangBan.Add(hb);
							LoadHHBan();
						}
					}
				else
				{
					MessageBox.Show("Không tìm thấy hàng hóa");
				}
			}
		}

		private void btnThanhToan_Click(object sender, EventArgs e)
		{
			if(gvDsHHBan.RowCount > 0)
			{
				FormBanHang banHang = new FormBanHang();
				FormBanHang.instance.TongTien = TongTien;
				banHang.Show();

			}
			else
			{
				MessageBox.Show("Vui lòng nhập hàng hóa bán!!");
			}
		}

		public DataTable getdata()
		{
			DataTable data = new DataTable();
			data.Columns.Add("STT", typeof(int));
			data.Columns.Add("TenHH", typeof(String));
			data.Columns.Add("DVT", typeof(String));
			data.Columns.Add("SoLuong", typeof(int));
			data.Columns.Add("DonGia", typeof(int));
			data.Columns.Add("TongTien", typeof(int));
			data.Columns.Add("VAT", typeof(int));
			foreach(HangBan item in lstHangBan)
			{
				DataRow newr = data.NewRow();
				newr["STT"] = item.stt;
				newr["TenHH"] = item.name;
				newr["DVT"] = item.dvt;
				newr["SoLuong"] = item.soluong;
				newr["DonGia"] = item.dongia;
				newr["TongTien"] = item.tongtien;
				newr["VAT"] = item.VAT;
				data.Rows.Add(newr);
			}
			return data;
		}

		public void AddHoaDonCT(int SoHD)
		{
			foreach(HangBan item in lstHangBan)
			{
				HoaDonCT hdct = new HoaDonCT();
				hdct.SoHD = SoHD;
				hdct.MaHH = item.mahh;
				hdct.Soluong = item.soluong;
				hdct.DonGia = item.dongia;
				hdct.ThanhTien = item.tongtien;
				hdct.VAT = item.VAT;
				bushd.ThemHoaDonCT(hdct);
				HangHoa hh = bushh.TimHangHoaTheoMAHH(hdct.MaHH);
				hh.SoLuong -= hdct.Soluong;
				bushh.SuaHangHoa(hh);
			}
		}

		private void btnlamMoi_Click(object sender, EventArgs e)
		{
			Restart();
		}
	}
	
}

public class HangBan
{
	public int stt { get; set; }
	public string name { get; set; }
	public int mahh { get; set; }
	public string dvt { get; set; }
	public int soluong { get; set; }
	public int dongia { get; set; }
	public int tongtien { get; set; }
	public int VAT { get; set; }

	public HangBan(int stt, string name, string dvt, int soluong, int dongia, int VAT, int mahh)
	{
		this.stt = stt;
		this.name = name;
		this.dvt = dvt;
		this.soluong = soluong;
		this.dongia = dongia;
		this.VAT = VAT;
		this.tongtien = soluong * dongia;
		this.mahh = mahh;
	}
	
	public HangBan ()
	{
	}

	public void UpdataTien(int soluong)
	{
		this.soluong += soluong;
		this.tongtien = this.soluong * this.dongia;
	}
}


