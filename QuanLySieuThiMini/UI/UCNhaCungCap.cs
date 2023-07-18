using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;
namespace QuanLySieuThiMini.UI
{
	public partial class UCNhaCungCap : UserControl
	{
		BUS_NhaCungCap busncc;
		NhaCungCap nhacungcap = new NhaCungCap();
		public UCNhaCungCap()
		{
			InitializeComponent();
		}

		private void UCNhaCungCap_Load(object sender, EventArgs e)
		{

			LoadData();

		}

		public void LoadData()
		{
			busncc = new BUS_NhaCungCap();
			
			gctDSNhaCungCap.DataSource = busncc.getall();
			scNhacungcap.Client = gctDSNhaCungCap;
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			LoadData();
		}

		private void btnThemHangHoa_Click(object sender, EventArgs e)
		{
			NewNhaCungCap frm = new NewNhaCungCap();
			NewNhaCungCap.instance.curNhacungcap = null;
			frm.Show();

		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			NewNhaCungCap frm = new NewNhaCungCap();
			NewNhaCungCap.instance.curNhacungcap = nhacungcap;
			frm.Show();
		}
		int ConvertInt(string txt)
		{
			return int.Parse(txt);
		}
		private void gvDsNhaCungCap_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			if(gvDsNhaCungCap.DataRowCount > 0)
			{
				nhacungcap.MaNCC = ConvertInt(gvDsNhaCungCap.GetFocusedRowCellValue("MaNCC").ToString());
				nhacungcap.TenNCC = gvDsNhaCungCap.GetFocusedRowCellValue("TenNCC").ToString();
				nhacungcap.DiaChi = gvDsNhaCungCap.GetFocusedRowCellValue("DiaChi").ToString();
				nhacungcap.SDT = gvDsNhaCungCap.GetFocusedRowCellValue("SDT").ToString();
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có muốn xóa nhà cung cấp này không !!!", "Thông Báo", MessageBoxButtons.YesNo);
			if(result == DialogResult.Yes)
			{
				try
				{
					busncc.XoaNhaCungCap(nhacungcap.MaNCC);
					LoadData();
					MessageBox.Show("Xóa Nhà cung cấp thành công!!!");

				}
				catch (Exception ex)
				{
					MessageBox.Show("Vui lòng thử lại !!!");
				}
			}
		}
	}
}
