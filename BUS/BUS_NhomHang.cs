using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
	public class BUS_NhomHang
	{
		DAL_NhomHang dalnh = new DAL_NhomHang();
		public List<NhomHang> getall()
		{
			return dalnh.getall();
		}

		public NhomHang TimNhomHang(int maNhomHang)
		{
			return dalnh.TimNhomHang(maNhomHang);
		}

		public void ThemnhomHang(NhomHang nhomhang)
		{
			dalnh.ThemnhomHang(nhomhang);
		}

		public void SuaNhomHang(NhomHang nhomhang)
		{
			dalnh.SuaNhomHang(nhomhang);
		}

		public void XoaNhomHang(int manhomhang)
		{
			dalnh.XoaNhomHang(manhomhang);
		}
	}
}
