namespace QuanLySieuThiMini.Chard
{
	partial class ChardTongQuan
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lbTongDoanhThu = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lbDoanhThuThang = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbSoHoaDon = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.chart);
			this.layoutControl1.Controls.Add(this.panel3);
			this.layoutControl1.Controls.Add(this.panel2);
			this.layoutControl1.Controls.Add(this.panel1);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.Root;
			this.layoutControl1.Size = new System.Drawing.Size(859, 394);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// chart
			// 
			chartArea1.Name = "ChartArea1";
			this.chart.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart.Legends.Add(legend1);
			this.chart.Location = new System.Drawing.Point(12, 94);
			this.chart.Name = "chart";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "chartDoanhThu";
			this.chart.Series.Add(series1);
			this.chart.Size = new System.Drawing.Size(835, 288);
			this.chart.TabIndex = 7;
			this.chart.Text = "chart1";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.LightGreen;
			this.panel3.Controls.Add(this.lbTongDoanhThu);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Location = new System.Drawing.Point(285, 12);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(281, 78);
			this.panel3.TabIndex = 6;
			// 
			// lbTongDoanhThu
			// 
			this.lbTongDoanhThu.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbTongDoanhThu.AutoSize = true;
			this.lbTongDoanhThu.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
			this.lbTongDoanhThu.ForeColor = System.Drawing.Color.White;
			this.lbTongDoanhThu.Location = new System.Drawing.Point(46, 36);
			this.lbTongDoanhThu.Name = "lbTongDoanhThu";
			this.lbTongDoanhThu.Size = new System.Drawing.Size(23, 24);
			this.lbTongDoanhThu.TabIndex = 2;
			this.lbTongDoanhThu.Text = "0";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(46, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(195, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "TỔNG DOANH THU";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
			this.panel2.Controls.Add(this.lbDoanhThuThang);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new System.Drawing.Point(570, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(277, 78);
			this.panel2.TabIndex = 0;
			// 
			// lbDoanhThuThang
			// 
			this.lbDoanhThuThang.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbDoanhThuThang.AutoSize = true;
			this.lbDoanhThuThang.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
			this.lbDoanhThuThang.ForeColor = System.Drawing.Color.White;
			this.lbDoanhThuThang.Location = new System.Drawing.Point(37, 36);
			this.lbDoanhThuThang.Name = "lbDoanhThuThang";
			this.lbDoanhThuThang.Size = new System.Drawing.Size(23, 24);
			this.lbDoanhThuThang.TabIndex = 3;
			this.lbDoanhThuThang.Text = "0";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(37, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(209, 24);
			this.label3.TabIndex = 2;
			this.label3.Text = "DOANH THU THÁNG";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SteelBlue;
			this.panel1.Controls.Add(this.lbSoHoaDon);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(269, 78);
			this.panel1.TabIndex = 5;
			// 
			// lbSoHoaDon
			// 
			this.lbSoHoaDon.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbSoHoaDon.AutoSize = true;
			this.lbSoHoaDon.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
			this.lbSoHoaDon.ForeColor = System.Drawing.Color.White;
			this.lbSoHoaDon.Location = new System.Drawing.Point(63, 36);
			this.lbSoHoaDon.Name = "lbSoHoaDon";
			this.lbSoHoaDon.Size = new System.Drawing.Size(23, 24);
			this.lbSoHoaDon.TabIndex = 1;
			this.lbSoHoaDon.Text = "0";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(63, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "SỐ HÓA ĐƠN";
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(859, 394);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.panel1;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(273, 82);
			this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.panel2;
			this.layoutControlItem3.Location = new System.Drawing.Point(558, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(281, 82);
			this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem3.TextVisible = false;
			// 
			// layoutControlItem4
			// 
			this.layoutControlItem4.Control = this.panel3;
			this.layoutControlItem4.Location = new System.Drawing.Point(273, 0);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new System.Drawing.Size(285, 82);
			this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem4.TextVisible = false;
			// 
			// layoutControlItem5
			// 
			this.layoutControlItem5.Control = this.chart;
			this.layoutControlItem5.Location = new System.Drawing.Point(0, 82);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new System.Drawing.Size(839, 292);
			this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem5.TextVisible = false;
			// 
			// ChardTongQuan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutControl1);
			this.Name = "ChardTongQuan";
			this.Size = new System.Drawing.Size(859, 394);
			this.Load += new System.EventHandler(this.ChardTongQuan_Load);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
		private System.Windows.Forms.Label lbTongDoanhThu;
		private System.Windows.Forms.Label lbDoanhThuThang;
		private System.Windows.Forms.Label lbSoHoaDon;
	}
}
