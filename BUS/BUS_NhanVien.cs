using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
	public class BUS_NhanVien
	{
		DAL_NhanVien dalnv = new DAL_NhanVien();

		public List<NhanVien> getall()
		{
			return dalnv.getall();
		}

		public void ThemNhanVien(NhanVien TNhanvien)
		{
			dalnv.ThemNhanVien(TNhanvien);
		}

		public void SuaNhanVien(NhanVien Snhanvien)
		{
			dalnv.SuaNhanVien(Snhanvien);
		}

		public void XoaNhanVien(int MaNhanVien)
		{
			dalnv.XoaNhanVien(MaNhanVien);
		}

		public NhanVien timNhanvien(int manv)
		{
			return dalnv.timNhanvien(manv);
		}
	}
}
