/*
 * Created by SharpDevelop.
 * User: Robert
 * Date: 12/12/2014
 * Time: 16:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AirportTemperature.UserControls
{
	partial class ChartControl
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartTemperature;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ComboBox comboBoxType;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.chartTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.comboBoxType = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.chartTemperature, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.comboBoxType, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(385, 385);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// chartTemperature
			// 
			chartArea2.Name = "ChartArea1";
			this.chartTemperature.ChartAreas.Add(chartArea2);
			this.tableLayoutPanel1.SetColumnSpan(this.chartTemperature, 2);
			this.chartTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
			legend2.Name = "Legend1";
			this.chartTemperature.Legends.Add(legend2);
			this.chartTemperature.Location = new System.Drawing.Point(3, 3);
			this.chartTemperature.Name = "chartTemperature";
			series2.ChartArea = "ChartArea1";
			series2.Legend = "Legend1";
			series2.Name = "Series1";
			this.chartTemperature.Series.Add(series2);
			this.chartTemperature.Size = new System.Drawing.Size(379, 349);
			this.chartTemperature.TabIndex = 0;
			this.chartTemperature.Text = "chart1";
			// 
			// comboBoxType
			// 
			this.comboBoxType.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxType.FormattingEnabled = true;
			this.comboBoxType.Location = new System.Drawing.Point(195, 358);
			this.comboBoxType.Name = "comboBoxType";
			this.comboBoxType.Size = new System.Drawing.Size(187, 21);
			this.comboBoxType.TabIndex = 1;
			this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTypeSelectedIndexChanged);
			// 
			// ChartControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "ChartControl";
			this.Size = new System.Drawing.Size(385, 385);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).EndInit();
			this.ResumeLayout(false);
		}
	}
}
