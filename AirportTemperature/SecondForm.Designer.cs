/*
 * Created by SharpDevelop.
 * User: Robert
 * Date: 13/12/2014
 * Time: 13:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AirportTemperature
{
	partial class SecondForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.SuspendLayout();
			// 
			// SecondForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Name = "SecondForm";
			this.Text = "SecondForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SecondFormFormClosing);
			this.ResumeLayout(false);

		}
	}
}
