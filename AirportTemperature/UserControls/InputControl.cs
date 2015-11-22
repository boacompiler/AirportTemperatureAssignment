/*
 * Created by SharpDevelop.
 * User: Robert
 * Date: 12/12/2014
 * Time: 16:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.Data;
using AirportTemperature;

namespace AirportTemperature.UserControls
{
	/// <summary>
	/// this user control allows the user to input information
	/// it displays the data in a table
	/// </summary>
	public partial class InputControl : UserControl
	{
		//we get the names of the months from myDateInfo. in theory this provides multilingual support
		DateTimeFormatInfo myDateInfo;
		//this is the table we will load our array's data into, this will then function as the data source for our datagridview
		DataTable table;
		
		public InputControl()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			myDateInfo = new DateTimeFormatInfo();
			table = GetTable();
			dataGridViewTemperature.DataSource = table;
			initComboBox();
			
			
		}
		
		//populate the comboBoxes
		void initComboBox()
		{
			for(int i = 0; i<12; i++)
			{
				comboBoxMonths.Items.Add(myDateInfo.GetMonthName(i+1));//gets months of the year without a hardcoded array!
			}
			for(int i = 0; i<MainForm.location.Length; i++)
			{
				comboBoxLocation.Items.Add(MainForm.location[i]);
			}
			comboBoxMonths.SelectedIndex = 0;
			comboBoxLocation.SelectedIndex = 0;
			
		}
		//init datatable
		static DataTable GetTable()
    	{	
			DataTable table = new DataTable();
			table.Columns.Add("Location", typeof(string));
			table.Columns.Add("Month", typeof(string));
			table.Columns.Add("Temperature", typeof(decimal));
			return table;
    	}
		//use of the mainforms AcceptButton affects all user controls that have been initialised
		//this overide provides the same functionality as AcceptButton but localised to this control
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData) 
		  {
		      if (keyData == Keys.Enter) 
		      {
		        buttonEnter.PerformClick();
		        return true;
		      }
		      return base.ProcessCmdKey(ref msg, keyData);
		    }
		//refresh tables displayed data
		public void updateTableRows()
		{
			table.Rows.Clear();
			
			for(int i = 0; i<MainForm.temperature.GetLength(0); i++)
			{
				for(int i1 = 0; i1<12; i1++)
				{
					if(MainForm.temperature[i,i1] != MainForm.erroneousFigure)
					{
						table.Rows.Add(MainForm.location[i],myDateInfo.GetAbbreviatedMonthName(i1+1),MainForm.temperature[i,i1]);
					}
				}
			}
		}
		
		void ButtonEnterClick(object sender, EventArgs e)
		{		
			StoreInfoToArray(MainForm.temperature);
			updateTableRows();
			// update the chart control, this keeps datavisulaisation consistent
			MainForm.chartMenu.UpdateChart(); 
			
			if(comboBoxMonths.SelectedIndex<11)
			{
				comboBoxMonths.SelectedIndex+=1;
			}
			else if(comboBoxLocation.SelectedIndex<(MainForm.location.Length-1))
			{
				comboBoxLocation.SelectedIndex+=1;
				comboBoxMonths.SelectedIndex=0;
			}
			else
			{
				comboBoxLocation.SelectedIndex = 0;
				comboBoxMonths.SelectedIndex = 0;
			}
			numericUpDownDegreesTemperature.Select(0,numericUpDownDegreesTemperature.Text.Length);
		}
		//stores data to a multidimensional array
		void StoreInfoToArray(decimal[,] tempArray)
		{
			tempArray[comboBoxLocation.SelectedIndex,comboBoxMonths.SelectedIndex] = numericUpDownDegreesTemperature.Value;
		}
	}
}
