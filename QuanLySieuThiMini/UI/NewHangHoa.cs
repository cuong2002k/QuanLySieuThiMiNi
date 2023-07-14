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
	public partial class NewHangHoa : DevExpress.XtraEditors.XtraForm
	{
		public NewHangHoa()
		{
			InitializeComponent();
		}

		private void NewHangHoa_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'sieuThiMiniDataSet.NhaCungCap' table. You can move, or remove it, as needed.
			this.nhaCungCapTableAdapter.Fill(this.sieuThiMiniDataSet.NhaCungCap);
			// TODO: This line of code loads data into the 'sieuThiMiniDataSet.NhomHang' table. You can move, or remove it, as needed.
			this.nhomHangTableAdapter.Fill(this.sieuThiMiniDataSet.NhomHang);

		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			HangHoa hh = new HangHoa();
			hh.TenHang = txtTenHangHoa.Text.Trim();
			hh.MaNH = int.Parse(cboNhomHang.SelectedValue.ToString());
			hh.XuatXu = txtXuatXu.Text.Trim();
			hh.GiaNhap = int.Parse(txtGiaNhap.Text.Trim());
			hh.GiaBan = int.Parse(txtGiaBan.Text.Trim());
			hh.DonViTinh = cboDonViTinh.Text.Trim();
			hh.NhaCungCap = int.Parse(cboNhaCungCap.SelectedValue.ToString());
			hh.MaVach = txtMaVach.Text.Trim();
			hh.SoLuong = int.Parse(txtSoLuong.Text.Trim());
			hh.DinhMuc = int.Parse(txtDinhMuc.Text.Trim());
			hh.VAT = int.Parse(txtVAT.Text.Trim());
			hh.TrangThaiBan = ckTrangThaiBan.Checked;
			BUS_HangHoa busHH = new BUS_HangHoa();
			busHH.AddHangHoa(hh);
			MessageBox.Show("Thêm hàng hóa thành công");
			UCHangHoa form = Application.OpenForms.OfType<UCHangHoa>().SingleOrDefault();
			form?.LoadDSHangHoa();
			this.Close();
		}
	}
}