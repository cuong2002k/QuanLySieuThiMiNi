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
		private void FormTest_Load(object sender, EventArgs e)
		{
			if (ucnv == null)
			{
				ucnv = new UCNhanVien();
				ucnv.Dock = DockStyle.Fill;
				panel1.Controls.Add(ucnv);
				ucnv.BringToFront();
			}
			else
			{
				ucnv.BringToFront();
			}
		}
	}
}
