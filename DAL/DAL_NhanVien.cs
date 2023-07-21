using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class DAL_NhanVien
	{
		SieuThiMiniEntities db;

		public DAL_NhanVien()
		{
			db = new SieuThiMiniEntities();
		}

		public List<NhanVien> getall()
		{
			using (db = new SieuThiMiniEntities())
			{
				return db.NhanVien.ToList();
			}
		}

		public void ThemNhanVien(NhanVien TNhanvien)
		{
			using (db = new SieuThiMiniEntities())
			{
				db.NhanVien.Add(TNhanvien);
				db.SaveChanges();
			}
		}

		public void SuaNhanVien(NhanVien Snhanvien)
		{
			using (db = new SieuThiMiniEntities())
			{
				NhanVien fnhanvien = db.NhanVien.SingleOrDefault(n => n.MaNV == Snhanvien.MaNV);
				fnhanvien.TenNV = Snhanvien.TenNV;
				fnhanvien.GioiTinh = Snhanvien.GioiTinh;
				fnhanvien.NgaySinh = Snhanvien.NgaySinh;
				fnhanvien.SDT = Snhanvien.SDT;
				fnhanvien.DiaChi = Snhanvien.DiaChi;
				fnhanvien.Email = Snhanvien.Email;
				fnhanvien.UserName = Snhanvien.UserName;
				fnhanvien.Password = Snhanvien.Password;
				fnhanvien.MaQuyen = Snhanvien.MaQuyen;
				fnhanvien.NgayVaoLam = Snhanvien.NgayVaoLam;
				fnhanvien.TrangThaiTaiKhoan = Snhanvien.TrangThaiTaiKhoan;
				fnhanvien.Luong = Snhanvien.Luong;
				db.SaveChanges();
			}
		}

		public void XoaNhanVien(int MaNhanVien)
		{
			using (db = new SieuThiMiniEntities())
			{
				NhanVien fnhanvien = db.NhanVien.SingleOrDefault(n => n.MaNV == MaNhanVien);
				db.NhanVien.Remove(fnhanvien);
				db.SaveChanges();
			}
		}

		public NhanVien timNhanvien(int manv)
		{
			using (db = new SieuThiMiniEntities())
			{
				return db.NhanVien.SingleOrDefault(n => n.MaNV == manv);
			}
		}
	}
 
}
