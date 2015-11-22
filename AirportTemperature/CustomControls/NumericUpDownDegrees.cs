/*
 * Created by SharpDevelop.
 * User: Robert
 * Date: 12/12/2014
 * Time: 18:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AirportTemperature.CustomControls
{
	/// <summary>
	/// This is a custom control for the airport temperature assignment
	/// it inherits the numeric updown class and overides the 'text' by adding a degree symbol
	/// this makes the numericupdown more appropriate for our uses.
	/// </summary>
	/// 
	
	public partial class NumericUpDownDegrees : NumericUpDown
	{
		
		
		
		public NumericUpDownDegrees()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			
		}
		
		
		
		// overides the UpdateEditText method, adding a degree symbol
		protected override void UpdateEditText()
		{
			this.Text = this.Value + "°C";
		}
		
		
		
	}
	
}
