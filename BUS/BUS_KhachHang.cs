using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
	public class BUS_KhachHang
	{
		DAL_KhachHang dalKhachHang = new DAL_KhachHang();
		public List<KhachHang> getall()
		{
			return dalKhachHang.getall();
		}

		public KhachHang TimKhachHang(int makh)
		{
			return dalKhachHang.TimKhachHang(makh);
		}

		public void XoaKhachHang(int makh)
		{
			dalKhachHang.XoaKhachHang(makh);
		}

		public void SuaKhachHang(KhachHang sKhachHang)
		{
			dalKhachHang.SuaKhachHang(sKhachHang);
		}

		public void ThemKhachHang(KhachHang TKhachHang)
		{
			dalKhachHang.ThemKhachHang(TKhachHang);
		}

		public KhachHang TimKhachHang(string sdt)
		{
			return dalKhachHang.TimKhachHang(sdt);
		}
	}
}
