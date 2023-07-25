﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace QuanLySieuThiMini.UI
{
	public partial class UCHoaDon : UserControl
	{
		public UCHoaDon()
		{
			InitializeComponent();
		}
		BUS_HoaDon bushd = new BUS_HoaDon();
		private void UCHoaDon_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		void LoadData()
		{
			gridControl.DataSource = bushd.getall();
		}
	}
}
