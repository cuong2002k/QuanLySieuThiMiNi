using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class DAL_KhachHang
	{
		SieuThiMiniEntities db;

		public List<KhachHang> getall()
		{
			using (db = new SieuThiMiniEntities())
			{
				return db.KhachHang.ToList();
			}
		}

		public KhachHang TimKhachHang(int makh)
		{
			using (db = new SieuThiMiniEntities())
			{
				KhachHang fkhachhang = db.KhachHang.SingleOrDefault(n => n.MaKH == makh);
				return fkhachhang;
			}
		}

		public void XoaKhachHang(int makh)
		{
			using (db = new SieuThiMiniEntities())
			{
				KhachHang fkhachhang = db.KhachHang.SingleOrDefault(n => n.MaKH == makh);
				
				db.KhachHang.Remove(fkhachhang);
				db.SaveChanges();
			}
		}

		public void SuaKhachHang(KhachHang sKhachHang)
		{
			using (db = new SieuThiMiniEntities())
			{
				KhachHang fKhachHang = db.KhachHang.SingleOrDefault(n => n.MaKH == sKhachHang.MaKH);
				if(fKhachHang != null)
				{
					fKhachHang.TenKH = sKhachHang.TenKH;
					fKhachHang.CMND = sKhachHang.CMND;
					fKhachHang.DiaChi = sKhachHang.DiaChi;
					fKhachHang.SDT = sKhachHang.SDT;
					fKhachHang.Diem = sKhachHang.Diem;
					fKhachHang.NgayTao = sKhachHang.NgayTao;
					fKhachHang.NamGanBo = sKhachHang.NamGanBo;
					db.SaveChanges();
				}
			}
		}

		public void ThemKhachHang(KhachHang TKhachHang)
		{
			using (db = new SieuThiMiniEntities())
			{
				db.KhachHang.Add(TKhachHang);
				db.SaveChanges();
			}
		}

		public KhachHang TimKhachHang(string sdt)
		{
			using (db = new SieuThiMiniEntities())
			{
				KhachHang fkhachhang = db.KhachHang.SingleOrDefault(n => n.SDT == sdt);
				return fkhachhang;
			}
		}
	}
}
