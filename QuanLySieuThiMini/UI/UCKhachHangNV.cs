using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace QuanLySieuThiMini.UI
{
	public partial class UCKhachHangNV : UserControl
	{
		BUS_KhachHang kh = new BUS_KhachHang();
		public UCKhachHangNV()
		{
			InitializeComponent();
		}

		private void UCKhachHangNV_Load(object sender, EventArgs e)
		{
			grcontrol.DataSource = kh.getall();
		}
	}
}
