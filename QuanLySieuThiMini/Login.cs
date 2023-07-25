using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL;
namespace QuanLySieuThiMini
{
	public partial class Login : DevExpress.XtraEditors.XtraForm
	{
		public Login()
		{
			InitializeComponent();
		}
		
		private void Login_Load(object sender, EventArgs e)
		{

		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string userName = txtUserName.Text.Trim();
			string password = txtPassword.Text.Trim();
			SieuThiMiniEntities db = new SieuThiMiniEntities();
			if(string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
			{
				MessageBox.Show("Tài Khoản Mật Khẩu Không Được Trống !!!");
			}
			else
			{
				NhanVien nv = db.NhanVien.SingleOrDefault(n => n.UserName == userName && n.Password == password);
				if(nv != null)
				{
					if(nv.MaQuyen == 1)
					{
						frmQuanLy frmqu = new frmQuanLy();
						frmqu.Show();
					}
					else if(nv.MaQuyen == 2)
					{
						frmQuanLyKho frmkho = new frmQuanLyKho();
						frmkho.Show();
					}
					else
					{
						frmNhanVien frmnv = new frmNhanVien();
						frmnv.Show();
					}
					
				}
				else
				{
					MessageBox.Show("Thông tin tài khoản hoặc mật khẩu không chính xác!!!");
				}
			}
		

		}
	}
}