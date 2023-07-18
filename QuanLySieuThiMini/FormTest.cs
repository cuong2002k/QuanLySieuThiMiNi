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
		private void FormTest_Load(object sender, EventArgs e)
		{
			if (uctrahang == null)
			{
				uctrahang = new UCTraHang();
				uctrahang.Dock = DockStyle.Fill;
				panel1.Controls.Add(uctrahang);
				uctrahang.BringToFront();
			}
			else
			{
				uctrahang.BringToFront();
			}
		}
	}
}
