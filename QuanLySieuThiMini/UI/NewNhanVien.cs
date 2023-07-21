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
	public partial class NewNhanVien : DevExpress.XtraEditors.XtraForm
	{
		BUS_NhanVien busnv = new BUS_NhanVien();
		public NhanVien Snhanvien;
		public static NewNhanVien instance;
		int manv;
		public NewNhanVien()
		{
			instance = this;
			InitializeComponent();
		}

		private void NewNhanVien_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'sieuThiMiniDataSet.PhanQuyen' table. You can move, or remove it, as needed.
			this.phanQuyenTableAdapter.Fill(this.sieuThiMiniDataSet.PhanQuyen);
			if (Snhanvien != null)
			{
				txtTenNV.Text = Snhanvien.TenNV;
				if(Snhanvien.GioiTinh == true)
				{
					checknam.Checked = true;
				}
				else
				{
					checknu.Checked = true;
				}

				txtNgaySinh.Text = Snhanvien.NgaySinh.ToString();
				txtSDT.Text = Snhanvien.SDT;
				txtDiaChi.Text = Snhanvien.DiaChi;
				txtEmail.Text = Snhanvien.Email;
				txtUserName.Text = Snhanvien.UserName;
				txtPassword.Text = Snhanvien.Password;
				cboQuyen.SelectedValue = Snhanvien.MaQuyen;
				checkTT.Checked = (Snhanvien.TrangThaiTaiKhoan == true);
				txtLuong.Text = Snhanvien.Luong.ToString();
			}
		}



		private void btnLuu_Click(object sender, EventArgs e)
		{
			if(Snhanvien != null)
			{
				Snhanvien.TenNV = txtTenNV.Text;
				Snhanvien.GioiTinh = (checknam.Checked);
				Snhanvien.NgaySinh = DateTime.Parse(txtNgaySinh.Text);
				Snhanvien.SDT = txtSDT.Text;
				Snhanvien.DiaChi = txtDiaChi.Text;
				Snhanvien.Email = txtEmail.Text;
				Snhanvien.UserName = txtUserName.Text;
				Snhanvien.Password = txtPassword.Text;
				Snhanvien.MaQuyen = int.Parse(cboQuyen.SelectedValue.ToString());
				Snhanvien.TrangThaiTaiKhoan = checkTT.Checked;
				Snhanvien.Luong = int.Parse(txtLuong.Text);

				try
				{
					busnv.SuaNhanVien(Snhanvien);
					MessageBox.Show("Sửa nhân viên thành công!!");
					this.Close();
				}
				catch(Exception ex)
				{
					MessageBox.Show("Sửa nhân viên không thành công!!");
				}
			}
			else
			{
				Snhanvien = new NhanVien();
				Snhanvien.TenNV = txtTenNV.Text;
				Snhanvien.GioiTinh = (checknam.Checked);
				Snhanvien.NgaySinh = DateTime.Parse(txtNgaySinh.Text);
				Snhanvien.SDT = txtSDT.Text;
				Snhanvien.DiaChi = txtDiaChi.Text;
				Snhanvien.Email = txtEmail.Text;
				Snhanvien.UserName = txtUserName.Text;
				Snhanvien.Password = txtPassword.Text;
				Snhanvien.MaQuyen = int.Parse(cboQuyen.SelectedValue.ToString());
				Snhanvien.TrangThaiTaiKhoan = checkTT.Checked;
				Snhanvien.Luong = int.Parse(txtLuong.Text);
				try
				{
					busnv.ThemNhanVien(Snhanvien);
					MessageBox.Show("Thêm nhân viên thành công!!");
					this.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Thêm nhân viên không thành công!!");
				}

			}
			UCNhanVien.instance.loaddata();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}