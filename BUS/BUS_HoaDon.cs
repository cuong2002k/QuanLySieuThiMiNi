using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
	public class BUS_HoaDon
	{
		DAL_HoaDon dalhd = new DAL_HoaDon();
		public List<HoaDon> getall()
		{
			return dalhd.getall();
		}

		public void ThemHoaDon(HoaDon thoadon)
		{
			dalhd.ThemHoaDon(thoadon);
		}
		public void ThemHoaDonCT(HoaDonCT ctHoaDon)
		{
			dalhd.ThemHoaDonCT(ctHoaDon);
		}
	}
}
