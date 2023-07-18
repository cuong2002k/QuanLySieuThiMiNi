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
	public partial class UCNhomHang : UserControl
	{
		BUS_NhomHang busnh;
		public UCNhomHang()
		{
			InitializeComponent();
		}

		private void UCNhomHang_Load(object sender, EventArgs e)
		{
			load();
		}
		 
		void load()
		{
			busnh = new BUS_NhomHang();

			grc.DataSource = busnh.getall();
			scsearch.Client = grc;
		}
	}
}
