using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class DAL_NhaCungCap
	{
		SieuThiMiniEntities db;

		public List<NhaCungCap> getall()
		{
			using (db = new SieuThiMiniEntities())
			{
				return db.NhaCungCap.ToList();
			}
		}

		public NhaCungCap TimNhaCungCap(int MaNhaCungCap)
		{
			using (db = new SieuThiMiniEntities())
			{
				NhaCungCap ncc = db.NhaCungCap.SingleOrDefault(n => n.MaNCC == MaNhaCungCap);
				return ncc;
			}
		}

		public void XoaNhaCungCap(int MaNhaCungCap)
		{
			using (db = new SieuThiMiniEntities())
			{
				NhaCungCap ncc = db.NhaCungCap.SingleOrDefault(n => n.MaNCC == MaNhaCungCap);
				db.NhaCungCap.Remove(ncc);
				db.SaveChanges();
			}	
		}

		public void SuaNhaCungCap(NhaCungCap nhacungcap)
		{
			using (db = new SieuThiMiniEntities())
			{
				NhaCungCap ncc = db.NhaCungCap.SingleOrDefault(n => n.MaNCC == nhacungcap.MaNCC);
				ncc.TenNCC = nhacungcap.TenNCC;
				ncc.DiaChi = nhacungcap.DiaChi;
				ncc.SDT = nhacungcap.SDT;
				db.SaveChanges();
			}
		}

		public void ThemNhaCungCap(NhaCungCap nhacungcap)
		{
			using (db = new SieuThiMiniEntities())
			{
				db.NhaCungCap.Add(nhacungcap);
				db.SaveChanges();
			}
		}
	}
}
