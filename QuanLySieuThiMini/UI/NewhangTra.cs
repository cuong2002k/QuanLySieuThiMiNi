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
	public partial class NewhangTra : DevExpress.XtraEditors.XtraForm
	{
		public static NewhangTra instance;
		public HangHoa curhanghoa;
		public NewhangTra()
		{
			instance = this;
			InitializeComponent();
		}

		private void ThemhangTra_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'sieuThiMiniDataSet.NhaCungCap' table. You can move, or remove it, as needed.
			this.nhaCungCapTableAdapter.Fill(this.sieuThiMiniDataSet.NhaCungCap);
			// TODO: This line of code loads data into the 'sieuThiMiniDataSet.NhomHang' table. You can move, or remove it, as needed.
			this.nhomHangTableAdapter.Fill(this.sieuThiMiniDataSet.NhomHang);
			loaddata();
		}
		void loaddata()
		{
			txtTenHangHoa.Text = curhanghoa.TenHang;
			cboNhomHang.SelectedValue = curhanghoa.MaNH;
			txtXuatXu.Text = curhanghoa.XuatXu;
			txtGiaNhap.Text = curhanghoa.GiaNhap.ToString();
			txtSLxuat.Text = "1";
			cboDonViTinh.Text = curhanghoa.DonViTinh;
			cboNhaCungCap.SelectedValue = curhanghoa.NhaCungCap;
			txtMaVach.Text = curhanghoa.MaVach;
			txtSoLuong.Text = curhanghoa.SoLuong.ToString();
			txtDinhMuc.Text = curhanghoa.DinhMuc.ToString();
			ckTrangThaiBan.Checked = (curhanghoa.TrangThaiBan == true) ? true : false;
		}
		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		bool checkemty(string s)
		{
			return string.IsNullOrEmpty(s);
		}
		private void btnLuu_Click(object sender, EventArgs e)
		{
			if(!checkemty(txtSLxuat.Text) && !checkemty(txtLydoXuat.Text))
			{
				HangTra ht = new HangTra();
				ht.MaHH = curhanghoa.MaHH;
				ht.TenHang = curhanghoa.TenHang;
				ht.SoLuongTra = int.Parse(txtSLxuat.Text);
				ht.Lydotra = txtLydoXuat.Text;

				try
				{
					UCTraHang.instance.addDShangTra(ht);
					MessageBox.Show("Thêm hang trả thành công !!!");
					this.Close();
				}
				catch(Exception ex)
				{
					MessageBox.Show("Thêm hang trả không thành công !!!");
				}
			}
		}
	}
}