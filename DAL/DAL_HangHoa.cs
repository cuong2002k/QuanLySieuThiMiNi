using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class DAL_HangHoa
	{
		SieuThiMiniEntities db;
		public DAL_HangHoa()
		{
			db = new SieuThiMiniEntities();
		}
		public List<HangHoa> getall()
		{
			db = new SieuThiMiniEntities();
			return db.HangHoa.ToList();
		}

		public void AddHangHoa(HangHoa hh)
		{
			db = new SieuThiMiniEntities();
			db.HangHoa.Add(hh);
			db.SaveChanges();
		}

		public void XoaHangHoa(HangHoa hh)
		{
			db = new SieuThiMiniEntities();
			HangHoa hanghoa = db.HangHoa.SingleOrDefault(n => n.MaHH == hh.MaHH);
			db.HangHoa.Remove(hanghoa);
			db.SaveChanges();

		}

		public void SuaHangHoa(HangHoa hh)
		{
			db = new SieuThiMiniEntities();
			HangHoa hanghoa = db.HangHoa.SingleOrDefault(n => n.MaHH == hh.MaHH);
			hanghoa.TenHang = hh.TenHang;
			hanghoa.MaNH = hh.MaNH;
			hanghoa.XuatXu = hh.XuatXu;
			hanghoa.GiaNhap = hh.GiaNhap;
			hanghoa.GiaBan = hh.GiaBan;
			hanghoa.DonViTinh = hh.DonViTinh;
			hanghoa.NhaCungCap = hh.NhaCungCap;
			hanghoa.MaVach = hh.MaVach;
			hanghoa.SoLuong = hh.SoLuong;
			hanghoa.DinhMuc = hh.DinhMuc;
			hanghoa.VAT = hh.VAT;
			hanghoa.TrangThaiBan = hh.TrangThaiBan;
			db.SaveChanges();
		}

		public HangHoa TimHangHoaTheoMaVach(string mavach)
		{
			using (db = new SieuThiMiniEntities())
			{
				return (db.HangHoa.SingleOrDefault(n => n.MaVach == mavach));
			}
		}

		public HangHoa TimHangHoaTheoMAHH(int mahh)
		{
			using (db = new SieuThiMiniEntities())
			{
				return (db.HangHoa.SingleOrDefault(n => n.MaHH == mahh));
			}
		}
	}
}
