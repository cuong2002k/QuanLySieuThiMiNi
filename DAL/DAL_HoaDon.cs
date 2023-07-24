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

		public void ThemHoaDon(HoaDon thoadon)
		{
			using (db = new SieuThiMiniEntities())
			{
				db.HoaDon.Add(thoadon);
				db.SaveChanges();
			}
		}

		public void ThemHoaDonCT(HoaDonCT ctHoaDon)
		{
			using (db = new SieuThiMiniEntities())
			{
				db.HoaDonCT.Add(ctHoaDon);
				db.SaveChanges();
			}
		}
	}

}
