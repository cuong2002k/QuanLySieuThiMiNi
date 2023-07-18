using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class DAL_NhomHang
	{
		SieuThiMiniEntities db;

		public List<NhomHang> getall()
		{
			using (db = new SieuThiMiniEntities())
			{
				return db.NhomHang.ToList();
			}
		}

		public NhomHang TimNhomHang(int maNhomHang)
		{
			using (db = new SieuThiMiniEntities())
			{
				NhomHang nh = db.NhomHang.SingleOrDefault(n => n.MaNH == maNhomHang);
				return nh;
			}
		}

		public void ThemnhomHang(NhomHang nhomhang)
		{
			using (db = new SieuThiMiniEntities())
			{
				db.NhomHang.Add(nhomhang);
				db.SaveChanges();
			}
		}

		public void SuaNhomHang(NhomHang nhomhang)
		{
			using (db = new SieuThiMiniEntities())
			{
				NhomHang nh = db.NhomHang.SingleOrDefault(n => n.MaNH == nhomhang.MaNH);

				nh.TenNH = nhomhang.TenNH;

				db.SaveChanges();
			}
		}

		public void XoaNhomHang(int manhomhang)
		{
			using (db = new SieuThiMiniEntities())
			{
				NhomHang nh = db.NhomHang.SingleOrDefault(n => n.MaNH == manhomhang);
				db.NhomHang.Remove(nh);
				db.SaveChanges();
			}
		}




	}
}
