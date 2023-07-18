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
using BUS;
namespace QuanLySieuThiMini.UI
{
	public partial class NewNhaCungCap : DevExpress.XtraEditors.XtraForm
	{
		BUS_NhaCungCap busncc;
		public NhaCungCap curNhacungcap;
		public static NewNhaCungCap instance;
		public NewNhaCungCap()
		{
			instance = this;
			InitializeComponent();
		}

		private void NewNhaCungCap_Load(object sender, EventArgs e)
		{
			
			if (curNhacungcap != null)
			{
				txtTenNhaCungCap.Text = curNhacungcap.TenNCC;
				txtSoDienThoai.Text = curNhacungcap.SDT;
				TxtDiaChi.Text = curNhacungcap.DiaChi;
			} 
		}

		

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			busncc = new BUS_NhaCungCap();
			NhaCungCap nhacungcap = new NhaCungCap();
			if (curNhacungcap != null)
			{
				
				nhacungcap.MaNCC = curNhacungcap.MaNCC;
				nhacungcap.TenNCC = txtTenNhaCungCap.Text;
				nhacungcap.SDT = txtSoDienThoai.Text;
				nhacungcap.DiaChi = TxtDiaChi.Text;
				busncc.SuaNhaCungCap(nhacungcap);
				
			}
			else
			{
				nhacungcap.TenNCC = txtTenNhaCungCap.Text;
				nhacungcap.SDT = txtSoDienThoai.Text;
				nhacungcap.DiaChi = TxtDiaChi.Text;
				busncc.ThemNhaCungCap(nhacungcap);
			}

			MessageBox.Show("Lưu Nhà Cung Cấp Thành Công");
			this.Close();
		}
	}
}