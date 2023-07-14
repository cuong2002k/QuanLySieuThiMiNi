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
			return db.HangHoa.ToList();
		}

		public void AddHangHoa(HangHoa hh)
		{
			db.HangHoa.Add(hh);
			db.SaveChanges();
		}

		public void XoaHangHoa(HangHoa hh)
		{
			HangHoa hanghoa = db.HangHoa.SingleOrDefault(n => n.MaHH == hh.MaHH);
			db.HangHoa.Remove(hanghoa);
			db.SaveChanges();

		}
	}
}
