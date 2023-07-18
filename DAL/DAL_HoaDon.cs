using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class DAL_HoaDon
	{
		SieuThiMiniEntities db;

		public DAL_HoaDon()
		{
			db = new SieuThiMiniEntities();
								
		}

		public List<HoaDon> getall()
		{
			using (db = new SieuThiMiniEntities())
			{
				return db.HoaDon.ToList();
			}	
		}

		public void ThemHoaDon(HoaDon thoadon, List<HoaDonCT> tLstHoadon)
		{
			using (db = new SieuThiMiniEntities())
			{
				db.HoaDon.Add(thoadon);
				db.HoaDonCT.AddRange(tLstHoadon);
				db.SaveChanges();
			}
		}


	}

}
