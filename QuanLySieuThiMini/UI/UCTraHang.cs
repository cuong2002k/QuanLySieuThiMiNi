using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;
namespace QuanLySieuThiMini.UI
{
	public partial class UCTraHang : UserControl
	{
		public UCTraHang()
		{
			InitializeComponent();
		}
		public static UCTraHang instance;
		BUS_HangHoa bushh;
		int maHH;
		List<HangTra> lsthangtra = new List<HangTra>();
		private void UCTraHang_Load(object sender, EventArgs e)
		{
			instance = this;
			loadhh();
		}

		void loadhh()
		{
			bushh = new BUS_HangHoa();
			grcontrol.DataSource = bushh.getall();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			bushh = new BUS_HangHoa();
			ThemhangTra frm = new ThemhangTra();
			HangHoa fhanghoa = bushh.TimHangHoaTheoMAHH(maHH);
			if(fhanghoa != null)
			{
				ThemhangTra.instance.curhanghoa = fhanghoa;
			}
			frm.Show();
		}

		private void dvDSHangHoa_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			if(dvDSHangHoa.RowCount > 0)
			{
				maHH = int.Parse(dvDSHangHoa.GetFocusedRowCellValue("MaHH").ToString());
			}
		}

		public void addDShangTra(HangTra hangTra)
		{
			lsthangtra.Add(hangTra);
			grDsTrahang.DataSource = null;
			grDsTrahang.DataSource = lsthangtra;
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			DialogResult resul = MessageBox.Show("Bạn có muốn làm mới không ?", "Thông báo", MessageBoxButtons.YesNo);
			if(resul == DialogResult.Yes)
			{
				grDsTrahang.DataSource = null;
				lsthangtra = null;
			}
		}
	}

	public class HangTra
	{
		public int? MaHH { get; set; }
		public string TenHang { get; set; }
		public int? SoLuongTra { get; set; }
		public string Lydotra { get; set; }
	}
}
