/*
 * Created by SharpDevelop.
 * User: Robert
 * Date: 12/12/2014
 * Time: 16:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AirportTemperature.UserControls
{
	/// <summary>
	/// this user control is the 'main' menu.
	/// it contains a logo and tools to analyse information quickly (average, lowest, highest tools)
	/// </summary>
	public partial class MainControl : UserControl
	{
		
		private static readonly String[] mathTypes = {"Highest Temperature","Lowest Temperature","Average Temperature"};
		
		TemperatureLocationsSortOperations tlso;
		
		public MainControl()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			tlso = new TemperatureLocationsSortOperations(MainForm.erroneousFigure);
			initComboBox();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		//populate the comboboxes
		void initComboBox()
		{
			for(int i = 0; i<MainForm.location.Length; i++)
			{
				comboBoxLocation.Items.Add(MainForm.location[i]);
			}
			for(int i = 0; i<mathTypes.Length; i++)
			{
				comboBoxMathType.Items.Add(mathTypes[i]);
			}
			comboBoxLocation.SelectedIndex = 0;
			comboBoxMathType.SelectedIndex = 0;
		}
		//constructs and displays a message with the users input
		void DisplayMathMessage()
		{
			if(MainForm.stf.myFilePath == null)
			{
				MessageBox.Show("please load/save a file", "Alert");
			}
			else
			{
				String message = comboBoxLocation.Text + " " + comboBoxMathType.Text + " temperature: ";
				
				switch(comboBoxMathType.SelectedIndex)
				{
					case 0:
						message += tlso.GetHighestTemperatureMonthByLocation(MainForm.temperature, comboBoxLocation.SelectedIndex);
						message += ", ";
						message += tlso.GetHighestTemperatureByLocation(MainForm.temperature, comboBoxLocation.SelectedIndex);
						break;
					case 1:
						message += tlso.GetLowestTemperatureMonthByLocation(MainForm.temperature, comboBoxLocation.SelectedIndex);
						message += ", ";
						message += tlso.GetLowestTemperatureByLocation(MainForm.temperature, comboBoxLocation.SelectedIndex);
						break;
					case 2:
						message += tlso.GetAverageTemperatureByLocation(MainForm.temperature, comboBoxLocation.SelectedIndex);
						break;
					default:
						message = "Error";
						break;
				}
				
				message += "°C";
				
				MessageBox.Show(message, "Temperature");
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			DisplayMathMessage();
		}
		
	}
}
