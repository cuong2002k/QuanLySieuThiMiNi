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
	}
}
