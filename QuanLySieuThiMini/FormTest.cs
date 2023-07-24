using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThiMini.UI;
namespace QuanLySieuThiMini
{
	public partial class FormTest : Form
	{
		public FormTest()
		{
			InitializeComponent();
		}
		UCNhaCungCap ucnhacungcap;
		UCNhomHang ucnhomhang;
		UCTraHang uctrahang;
		UCKhachHang ucKhachHang;
		UCNhanVien ucnv;
		UCBanHang bh;
		private void FormTest_Load(object sender, EventArgs e)
		{
			if (bh == null)
			{
				bh = new UCBanHang();
				bh.Dock = DockStyle.Fill;
				panel1.Controls.Add(bh);
				bh.BringToFront();
			}
			else
			{
				bh.BringToFront();
			}
		}
	}
}
