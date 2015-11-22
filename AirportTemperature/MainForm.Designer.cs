/*
 * Created by SharpDevelop.
 * User: Robert
 * Date: 12/12/2014
 * Time: 16:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AirportTemperature
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem temperatureEntryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MainMenuToolStripItem;
		private System.Windows.Forms.ToolStripMenuItem openInWindowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem temperatureEntryToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		
		/// <summary>
		/// Disposes resources used by the form.
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenuToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
			this.temperatureEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openInWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.temperatureEntryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.chartToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.viewToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(552, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newToolStripMenuItem,
									this.openToolStripMenuItem,
									this.saveToolStripMenuItem,
									this.saveAsToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.newToolStripMenuItem.Text = "New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItemClick);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.saveAsToolStripMenuItem.Text = "Save As";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItemClick);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.MainMenuToolStripItem,
									this.temperatureEntryToolStripMenuItem,
									this.chartToolStripMenuItem,
									this.openInWindowToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// MainMenuToolStripItem
			// 
			this.MainMenuToolStripItem.Name = "MainMenuToolStripItem";
			this.MainMenuToolStripItem.Size = new System.Drawing.Size(172, 22);
			this.MainMenuToolStripItem.Text = "Main Menu";
			this.MainMenuToolStripItem.Click += new System.EventHandler(this.MainMenuToolStripItemClick);
			// 
			// temperatureEntryToolStripMenuItem
			// 
			this.temperatureEntryToolStripMenuItem.Name = "temperatureEntryToolStripMenuItem";
			this.temperatureEntryToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.temperatureEntryToolStripMenuItem.Text = "Temperature Entry";
			this.temperatureEntryToolStripMenuItem.Click += new System.EventHandler(this.TemperatureEntryToolStripMenuItemClick);
			// 
			// chartToolStripMenuItem
			// 
			this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
			this.chartToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.chartToolStripMenuItem.Text = "Chart";
			this.chartToolStripMenuItem.Click += new System.EventHandler(this.ChartToolStripMenuItemClick);
			// 
			// openInWindowToolStripMenuItem
			// 
			this.openInWindowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.temperatureEntryToolStripMenuItem1,
									this.chartToolStripMenuItem1});
			this.openInWindowToolStripMenuItem.Name = "openInWindowToolStripMenuItem";
			this.openInWindowToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.openInWindowToolStripMenuItem.Text = "Open In Window";
			// 
			// temperatureEntryToolStripMenuItem1
			// 
			this.temperatureEntryToolStripMenuItem1.Name = "temperatureEntryToolStripMenuItem1";
			this.temperatureEntryToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
			this.temperatureEntryToolStripMenuItem1.Text = "Temperature Entry";
			this.temperatureEntryToolStripMenuItem1.Click += new System.EventHandler(this.TemperatureEntryToolStripMenuItem1Click);
			// 
			// chartToolStripMenuItem1
			// 
			this.chartToolStripMenuItem1.Name = "chartToolStripMenuItem1";
			this.chartToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
			this.chartToolStripMenuItem1.Text = "Chart";
			this.chartToolStripMenuItem1.Click += new System.EventHandler(this.ChartToolStripMenuItem1Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(552, 418);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "AirportTemperature";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
