using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL;
using BUS;
namespace QuanLySieuThiMini.Chard
{
	public partial class ChardTongQuan : DevExpress.XtraEditors.XtraUserControl
	{
		public ChardTongQuan()
		{
			InitializeComponent();
		}

		SieuThiMiniEntities db = new SieuThiMiniEntities();
		private void ChardTongQuan_Load(object sender, EventArgs e)
		{
			GetDoanhThu();
			Getchart();
		}

		void Getchart()
		{
			for(int i = 1; i<=12 ;i++)
			{
				int? value = db.HoaDon.Where(n => n.NgayLap.Value.Month == i && n.NgayLap.Value.Year == DateTime.Now.Year).Sum(x => x.ThanhTien);
				int DoanhThu = value.HasValue ? value.Value : 0;
				chart.Series["chartDoanhThu"].Points.AddXY("Tháng " + i, DoanhThu);
			}
		}

		void GetDoanhThu()
		{
			int sohoadon = db.HoaDon.Count();

			lbSoHoaDon.Text = sohoadon.ToString("N");

			int? value = db.HoaDon.Sum(n => n.ThanhTien);
			int TongDoanhThu = value.HasValue ? value.Value : 0;
			lbTongDoanhThu.Text = TongDoanhThu.ToString("N") + " VND";

			DateTime nows = DateTime.Now;
			
			int? values = db.HoaDon.Where(n => n.NgayLap.Value.Month == nows.Month && n.NgayLap.Value.Year == nows.Year).Sum(i => i.ThanhTien);
			int DoanhThuTheoThang = values.HasValue ? values.Value : 0;
			lbDoanhThuThang.Text = DoanhThuTheoThang.ToString("N") + " VND";


		}
	}
}
