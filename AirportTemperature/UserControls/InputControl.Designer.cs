/*
 * Created by SharpDevelop.
 * User: Robert
 * Date: 12/12/2014
 * Time: 16:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AirportTemperature.UserControls
{
	partial class InputControl
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ComboBox comboBoxMonths;
		private System.Windows.Forms.Label label2;
		private AirportTemperature.CustomControls.NumericUpDownDegrees numericUpDownDegreesTemperature;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonEnter;
		private System.Windows.Forms.ComboBox comboBoxLocation;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridViewTemperature;
		
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.buttonEnter = new System.Windows.Forms.Button();
			this.numericUpDownDegreesTemperature = new AirportTemperature.CustomControls.NumericUpDownDegrees();
			this.comboBoxMonths = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxLocation = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridViewTemperature = new System.Windows.Forms.DataGridView();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownDegreesTemperature)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemperature)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Controls.Add(this.buttonEnter, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.numericUpDownDegreesTemperature, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.comboBoxMonths, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.comboBoxLocation, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.dataGridViewTemperature, 0, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(315, 315);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// buttonEnter
			// 
			this.buttonEnter.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonEnter.Location = new System.Drawing.Point(237, 23);
			this.buttonEnter.Name = "buttonEnter";
			this.buttonEnter.Size = new System.Drawing.Size(75, 24);
			this.buttonEnter.TabIndex = 6;
			this.buttonEnter.Text = "Enter";
			this.buttonEnter.UseVisualStyleBackColor = true;
			this.buttonEnter.Click += new System.EventHandler(this.ButtonEnterClick);
			// 
			// numericUpDownDegreesTemperature
			// 
			this.numericUpDownDegreesTemperature.Dock = System.Windows.Forms.DockStyle.Top;
			this.numericUpDownDegreesTemperature.Location = new System.Drawing.Point(159, 23);
			this.numericUpDownDegreesTemperature.Minimum = new decimal(new int[] {
			100,
			0,
			0,
			-2147483648});
			this.numericUpDownDegreesTemperature.Name = "numericUpDownDegreesTemperature";
			this.numericUpDownDegreesTemperature.Size = new System.Drawing.Size(72, 20);
			this.numericUpDownDegreesTemperature.TabIndex = 4;
			// 
			// comboBoxMonths
			// 
			this.comboBoxMonths.Dock = System.Windows.Forms.DockStyle.Top;
			this.comboBoxMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMonths.FormattingEnabled = true;
			this.comboBoxMonths.Location = new System.Drawing.Point(81, 23);
			this.comboBoxMonths.Name = "comboBoxMonths";
			this.comboBoxMonths.Size = new System.Drawing.Size(72, 21);
			this.comboBoxMonths.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(159, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Temperature";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Location = new System.Drawing.Point(81, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Month";
			// 
			// comboBoxLocation
			// 
			this.comboBoxLocation.Dock = System.Windows.Forms.DockStyle.Top;
			this.comboBoxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxLocation.FormattingEnabled = true;
			this.comboBoxLocation.Location = new System.Drawing.Point(3, 23);
			this.comboBoxLocation.Name = "comboBoxLocation";
			this.comboBoxLocation.Size = new System.Drawing.Size(72, 21);
			this.comboBoxLocation.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 20);
			this.label3.TabIndex = 8;
			this.label3.Text = "Location";
			// 
			// dataGridViewTemperature
			// 
			this.dataGridViewTemperature.AllowUserToAddRows = false;
			this.dataGridViewTemperature.AllowUserToDeleteRows = false;
			this.dataGridViewTemperature.AllowUserToResizeColumns = false;
			this.dataGridViewTemperature.AllowUserToResizeRows = false;
			this.dataGridViewTemperature.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewTemperature.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewTemperature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewTemperature, 4);
			this.dataGridViewTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewTemperature.Location = new System.Drawing.Point(3, 53);
			this.dataGridViewTemperature.Name = "dataGridViewTemperature";
			this.dataGridViewTemperature.ReadOnly = true;
			this.dataGridViewTemperature.Size = new System.Drawing.Size(309, 259);
			this.dataGridViewTemperature.TabIndex = 9;
			// 
			// InputControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "InputControl";
			this.Size = new System.Drawing.Size(321, 321);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownDegreesTemperature)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemperature)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
