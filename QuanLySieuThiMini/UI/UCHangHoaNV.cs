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
namespace QuanLySieuThiMini.UI
{
	public partial class UCHangHoaNV : DevExpress.XtraEditors.XtraUserControl
	{
		BUS_HangHoa hh = new BUS_HangHoa();
		public UCHangHoaNV()
		{
			InitializeComponent();
		}

		private void grcontrol_Load(object sender, EventArgs e)
		{
			grcontrol.DataSource = hh.getall();
		}
	}
}
