/*
 * Created by SharpDevelop.
 * User: Robert
 * Date: 12/12/2014
 * Time: 16:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
//my usings follow
using AirportTemperature.UserControls;
using AirportTemperature.CustomControls;
using System.Globalization;

namespace AirportTemperature
{
	/// <summary>
	/// This is the MainForm. 
	/// all major variables are stored and initialised here
	/// this is the primary form for displaying user controls and handling user input
	/// </summary>
	public partial class MainForm : Form
	{
		//all of these static variables are only initialised once
		//our user controls hold the content of our forms
		public static MainControl mainMenu;
		public static InputControl inputMenu;
		public static ChartControl chartMenu;
		
		//the erroneousFigure is a reference variable only so should be readonly
		public static readonly decimal erroneousFigure  = 10000;
		//this is a string array to hold all our location names
		// to aid usability, adding to this list will not break the code, it will work with a new location
		public static readonly String[] location = {"Crew Lounge","Passenger Lounge","Private Lounge","Service Area","The Terminal"};
		//decimal to store temperatures at each location.
		//first index is for location, second index is for month
		public static decimal[,] temperature = new decimal[location.Length,12]; // locations amount could change, but there will always be 12 months
		
		public static SaveToFile stf;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//init userControls
			mainMenu = new MainControl();
			this.Controls.Add(mainMenu);
			inputMenu = new InputControl();
			this.Controls.Add(inputMenu);
			chartMenu = new ChartControl();
			this.Controls.Add(chartMenu);
			//init saveToFile class
			stf = new SaveToFile();
			//init my array ready to be populated with data.	
			InitArray(temperature, erroneousFigure);
			
			saveToolStripMenuItem.Enabled = false; // can't save before save as is pressed, so we "grey" the option
		
			// display main menu control at init
			DisplayControl(mainMenu);

		}
		//method to setup our array, called at init
		public void InitArray(decimal[,] myArray, decimal defaultFigure)
		{
			for(int i=0; i<myArray.GetLength(0); i++)
			{
				for(int i1=0; i1<myArray.GetLength(1); i1++)
				{
					//as decimal is not nullable, set every variable outside of acceptable bounds so we can identify erroneous data
					//0 is the default variable, however it is within acceptable bounds. a temperature of 10000 degrees is unlikely to occur
					myArray[i,i1] = defaultFigure;
				}
			}
		}
		//overide the key presses so shortcuts can be processed
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
			//ctrl+s: save
			//if attempting to save before choosing a file location, dialog is launched, and saving is performed as though save as has been initiated
            if (keyData == (Keys.Control | Keys.S))
            {
            	try
            	{
                	stf.SaveArray(stf.myFilePath, temperature);
            	}
            	catch(Exception ee)
            	{
            		if(ee.Message.Contains("cannot be null"))
            		{
            			stf.SaveArrayDialog(""+DateTime.Now.Year,temperature);
						saveToolStripMenuItem.Enabled = true;
            		}
            		else
            		{
            			MessageBox.Show(ee.Message);
            		}
            		
            	}
                return true;
            }
            //ctrl+alt+s: save as
            if (keyData == (Keys.Control | Keys.Alt | Keys.S))
            {
                stf.SaveArrayDialog(""+DateTime.Now.Year,temperature);
				saveToolStripMenuItem.Enabled = true;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
		//this method handles displaying user controls
		public void DisplayControl(UserControl uControl)
		{
			//the if is required because our second form may have taken ownership of our control
			//if so we need to give 'this' ownership
			if(!this.Controls.Contains(uControl))
			{
				this.Controls.Add(uControl);
			}
			foreach(Control cont in this.Controls)
			{
				if(cont is UserControl)
				{
					cont.Enabled = false;
				}
			}
			
			uControl.Dock = DockStyle.Fill;
			uControl.Enabled = true;
			uControl.Visible = true;
			uControl.BringToFront();
		}
		//this method launches the secondform 
		public void DisplayNewWindow(UserControl uControl, ToolStripMenuItem[] toolStripItem)
		{
			//we cannot display a user control in more than one form since we only initiate once, so we disable the options to display it until our second form is closed
			for(int i=0; i<toolStripItem.Length; i++)
			{
				toolStripItem[i].Enabled = false;
			}
			foreach(Control cont in this.Controls)
			{
				if(cont is UserControl)
				{
					cont.Enabled = true;
				}
			}
			//init secondform
			SecondForm newWindow = new SecondForm(uControl);
			newWindow.Size = this.Size;
			
			// the delegate enables the disabled controls once the form displaying them is closed
			newWindow.FormClosing += delegate {
				for(int i=0; i<toolStripItem.Length; i++)
				{
					toolStripItem[i].Enabled = true;
				}
			};
			
			newWindow.Show();
		}
		// display about box
		void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{	
			//the message written while preserving line breaks. this method is better than a string literal because it preserves tab formatting.
			String message = String.Join(Environment.NewLine,
			                             "Gatwick Temperature Analysis",
			                             "Version 1.0",
			                             "Copyright © 2014 'Robs Software Emporium'");
			//the message content is shown in a messagebox.
			MessageBox.Show(message,"About",MessageBoxButtons.OK);
		}
		void TemperatureEntryToolStripMenuItemClick(object sender, EventArgs e)
		{
			DisplayControl(inputMenu);
			
		}
		void ChartToolStripMenuItemClick(object sender, EventArgs e)
		{
			DisplayControl(chartMenu);
		}
		void MainMenuToolStripItemClick(object sender, EventArgs e)
		{
			DisplayControl(mainMenu);
		}
		void TemperatureEntryToolStripMenuItem1Click(object sender, EventArgs e)
		{
			ToolStripMenuItem[] toolStripArray = {temperatureEntryToolStripMenuItem, temperatureEntryToolStripMenuItem1};
			DisplayNewWindow(inputMenu, toolStripArray);
		}
		void ChartToolStripMenuItem1Click(object sender, EventArgs e)
		{
			ToolStripMenuItem[] toolStripArray = {chartToolStripMenuItem, chartToolStripMenuItem1};
			DisplayNewWindow(chartMenu, toolStripArray);
		}
		void NewToolStripMenuItemClick(object sender, EventArgs e)
		{
			//displays a warning message before resetting data
			DialogResult dialogResult = MessageBox.Show("Are you sure, all unsaved data will be lost","Alert",MessageBoxButtons.OKCancel);
			//if the user clicks ok, reset all data
			if(dialogResult == DialogResult.OK)
			{
				InitArray(temperature, erroneousFigure);
				inputMenu.updateTableRows();
				chartMenu.UpdateChart();
				stf.myFilePath = null;
			}
			
		}
		void OpenToolStripMenuItemClick(object sender, EventArgs e)
		{
			stf.OpenArrayDialog(temperature);
			inputMenu.updateTableRows();
			chartMenu.UpdateChart();
			saveToolStripMenuItem.Enabled = true;
		}
		void SaveAsToolStripMenuItemClick(object sender, EventArgs e)
		{
			stf.SaveArrayDialog(""+DateTime.Now.Year,temperature);
			if(stf.sfd.FileName != null){
				saveToolStripMenuItem.Enabled = true;
			}
			
		}
		void SaveToolStripMenuItemClick(object sender, EventArgs e)
		{
			stf.SaveArray(stf.myFilePath, temperature);
		}
	}
}
