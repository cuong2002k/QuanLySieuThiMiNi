using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLySieuThiMini.UI;
namespace QuanLySieuThiMini
{
	public partial class frmQuanLyKho : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
	{
		public frmQuanLyKho()
		{
			InitializeComponent();
		}
		UCHangHoa uchanghoa;
		UCNhaCungCap ucnhacungcap;
		UCNhapHang ucnhaphang;
		UCNhomHang ucnhomhang;
		private void btnHangHoa_Click(object sender, EventArgs e)
		{
			if(uchanghoa == null)
			{
				uchanghoa = new UCHangHoa();
				uchanghoa.Dock = DockStyle.Fill;
				MainContainer.Controls.Add(uchanghoa);
				uchanghoa.BringToFront();
			}
			else
			{
				uchanghoa.BringToFront();
			}
		}

		private void btnNhaCungCap_Click(object sender, EventArgs e)
		{
			if (ucnhacungcap == null)
			{
				ucnhacungcap = new UCNhaCungCap();
				ucnhacungcap.Dock = DockStyle.Fill;
				MainContainer.Controls.Add(ucnhacungcap);
				ucnhacungcap.BringToFront();
			}
			else
			{
				ucnhacungcap.BringToFront();
			}
		}

		private void btnNhapHang_Click(object sender, EventArgs e)
		{
			if(ucnhaphang == null )
			{
				ucnhaphang = new UCNhapHang();
				ucnhaphang.Dock = DockStyle.Fill;
				MainContainer.Controls.Add(ucnhaphang);
				ucnhaphang.BringToFront();
			}
			else
			{
				ucnhaphang.BringToFront();
			}
		}

		private void frmQuanLyKho_Load(object sender, EventArgs e)
		{

		}

		private void accordionControlElement3_Click(object sender, EventArgs e)
		{
			if (ucnhomhang == null)
			{
				ucnhomhang = new UCNhomHang();
				ucnhomhang.Dock = DockStyle.Fill;
				MainContainer.Controls.Add(ucnhomhang);
				ucnhomhang.BringToFront();
			}
			else
			{
				ucnhomhang.BringToFront();
			}

		}

		private void accordionControlElement6_Click(object sender, EventArgs e)
		{
			DialogResult r = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo);

			if (r == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
	}
}
