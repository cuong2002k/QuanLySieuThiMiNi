using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
	public class BUS_NhaCungCap
	{
		DAL_NhaCungCap dalNhacungcap;

		public BUS_NhaCungCap()
		{
			dalNhacungcap = new DAL_NhaCungCap();
		}

		public List<NhaCungCap> getall()
		{
			return dalNhacungcap.getall();
		}

		public NhaCungCap TimNhaCungCap(int MaNhaCungCap)
		{
			return dalNhacungcap.TimNhaCungCap(MaNhaCungCap);
		}

		public void XoaNhaCungCap(int MaNhaCungCap)
		{
			dalNhacungcap.XoaNhaCungCap(MaNhaCungCap);
		}

		public void SuaNhaCungCap(NhaCungCap nhacungcap)
		{
			dalNhacungcap.SuaNhaCungCap(nhacungcap);
		}

		public void ThemNhaCungCap(NhaCungCap nhacungcap)
		{
			dalNhacungcap.ThemNhaCungCap(nhacungcap);
		}
	}
}
