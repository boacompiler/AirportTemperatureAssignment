/*
 * Created by SharpDevelop.
 * User: Robert
 * Date: 13/12/2014
 * Time: 13:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AirportTemperature
{
	/// <summary>
	/// this is our secondform
	/// initialised when a user needs to display a user control in a seaparate window.
	/// 
	/// </summary>
	public partial class SecondForm : Form
	{
		public SecondForm(UserControl userControl)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			
			InitializeComponent();
			this.Text = ""+userControl.Name;
			DisplayControl(userControl);

		}
		
		void DisplayControl(UserControl uControl)
		{
			this.Controls.Add(uControl);
			uControl.Dock = DockStyle.Fill;
			uControl.Enabled = true;
			uControl.Visible = true;
			uControl.BringToFront();
		}
		void SecondFormFormClosing(object sender, FormClosingEventArgs e)
		{
			//we have to clear the controls we 'borrowed' so that they are not disposed
			this.Controls.Clear(); 
		}
	}
}
