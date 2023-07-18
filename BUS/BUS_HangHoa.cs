using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
	public class BUS_HangHoa
	{
		DAL_HangHoa dalhh = new DAL_HangHoa();
		public List<HangHoa> getall()
		{
			return dalhh.getall();
		}

		public void AddHangHoa(HangHoa hh)
		{
			dalhh.AddHangHoa(hh);
		}
		 public void XoaHangHoa(HangHoa hh)
		{
			dalhh.XoaHangHoa(hh);
		}
		public void SuaHangHoa(HangHoa hh)
		{
			dalhh.SuaHangHoa(hh);
		}
		public HangHoa TimHangHoaTheoMaVach(string mavach)
		{
			return dalhh.TimHangHoaTheoMaVach(mavach);
		}

		public HangHoa TimHangHoaTheoMAHH(int mahh)
		{
			return dalhh.TimHangHoaTheoMAHH(mahh);
		}
	}
}
