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
	public partial class NewKhachHang : DevExpress.XtraEditors.XtraForm
	{
		public BUS_KhachHang buskh = new BUS_KhachHang();
		public static NewKhachHang instance;
		public KhachHang cKhachHang;
		public NewKhachHang()
		{
			instance = this;
			InitializeComponent();
			
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			DialogResult r = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo);
			if(r == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			if(cKhachHang == null)
			{
				cKhachHang = new KhachHang();
				cKhachHang.TenKH = txtTenKh.Text.Trim();
				cKhachHang.CMND = txtCMND.Text.Trim();
				cKhachHang.DiaChi = txtDiaChi.Text.Trim();
				cKhachHang.SDT = txtSDT.Text.Trim();
				cKhachHang.Diem = int.Parse(txtDiem.Text.Trim());
				cKhachHang.NgayTao = DateTime.Now;
				cKhachHang.NamGanBo = 0;
				
				try
				{
					buskh.ThemKhachHang(cKhachHang);
					MessageBox.Show("Thêm Khách Hàng Thành Công");
					this.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Thêm Khách Hàng Không Thành Công");
				}
			}
			else
			{
				cKhachHang.TenKH = txtTenKh.Text.Trim();
				cKhachHang.CMND = txtCMND.Text.Trim();
				cKhachHang.DiaChi = txtDiaChi.Text.Trim();
				cKhachHang.SDT = txtSDT.Text.Trim();
				cKhachHang.Diem = int.Parse(txtDiem.Text.Trim());
				try
				{
					buskh.SuaKhachHang(cKhachHang);
					MessageBox.Show("Sửa Khách Hàng Thành Công");
					this.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Sửa Khách Hàng Không Thành Công");
				}
			}

			UCKhachHang.instance.loadData();
			
		}

		private void NewKhachHang_Load(object sender, EventArgs e)
		{
			if (cKhachHang != null)
			{

				txtTenKh.Text = cKhachHang.TenKH;
				txtCMND.Text = cKhachHang.CMND;
				txtDiaChi.Text = cKhachHang.DiaChi;
				txtSDT.Text = cKhachHang.SDT;
				txtDiem.Text = cKhachHang.Diem.ToString();
			}
		}
	}
}