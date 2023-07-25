using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThiMini.UI
{
	public partial class UCHangHoaNV : UserControl
	{
		BUS.BUS_HangHoa hh = new BUS.BUS_HangHoa();
		public UCHangHoaNV()
		{
			InitializeComponent();
		}

		private void UCHangHoaNV_Load(object sender, EventArgs e)
		{
			grcontrol.DataSource = hh.getall();
		}
	}
}
