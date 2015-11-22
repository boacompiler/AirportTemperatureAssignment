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
	partial class MainControl
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControl));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanelInput = new System.Windows.Forms.TableLayoutPanel();
			this.comboBoxLocation = new System.Windows.Forms.ComboBox();
			this.comboBoxMathType = new System.Windows.Forms.ComboBox();
			this.buttonEnter = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tableLayoutPanelInput.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelInput, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(362, 372);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(184, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(175, 326);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// tableLayoutPanelInput
			// 
			this.tableLayoutPanelInput.ColumnCount = 3;
			this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanelInput, 2);
			this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanelInput.Controls.Add(this.comboBoxLocation, 0, 0);
			this.tableLayoutPanelInput.Controls.Add(this.comboBoxMathType, 1, 0);
			this.tableLayoutPanelInput.Controls.Add(this.buttonEnter, 2, 0);
			this.tableLayoutPanelInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelInput.Location = new System.Drawing.Point(3, 335);
			this.tableLayoutPanelInput.Name = "tableLayoutPanelInput";
			this.tableLayoutPanelInput.RowCount = 1;
			this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.tableLayoutPanelInput.Size = new System.Drawing.Size(356, 34);
			this.tableLayoutPanelInput.TabIndex = 1;
			// 
			// comboBoxLocation
			// 
			this.comboBoxLocation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBoxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxLocation.FormattingEnabled = true;
			this.comboBoxLocation.Location = new System.Drawing.Point(3, 3);
			this.comboBoxLocation.Name = "comboBoxLocation";
			this.comboBoxLocation.Size = new System.Drawing.Size(112, 21);
			this.comboBoxLocation.TabIndex = 0;
			// 
			// comboBoxMathType
			// 
			this.comboBoxMathType.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBoxMathType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMathType.FormattingEnabled = true;
			this.comboBoxMathType.Location = new System.Drawing.Point(121, 3);
			this.comboBoxMathType.Name = "comboBoxMathType";
			this.comboBoxMathType.Size = new System.Drawing.Size(112, 21);
			this.comboBoxMathType.TabIndex = 1;
			// 
			// buttonEnter
			// 
			this.buttonEnter.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonEnter.Location = new System.Drawing.Point(239, 3);
			this.buttonEnter.Name = "buttonEnter";
			this.buttonEnter.Size = new System.Drawing.Size(114, 23);
			this.buttonEnter.TabIndex = 2;
			this.buttonEnter.Text = "Enter";
			this.buttonEnter.UseVisualStyleBackColor = true;
			this.buttonEnter.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "MainControl";
			this.Size = new System.Drawing.Size(362, 372);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tableLayoutPanelInput.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button buttonEnter;
		private System.Windows.Forms.ComboBox comboBoxMathType;
		private System.Windows.Forms.ComboBox comboBoxLocation;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInput;
	}
}
