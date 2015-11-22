/*
 * Created by SharpDevelop.
 * User: Robert
 * Date: 14/12/2014
 * Time: 16:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.IO;

namespace AirportTemperature
{
	/// <summary>
	/// this class handles saving and loading to file
	/// xml serializing would be arguably better, however loading by indexing strings is the more interesting programming challenge, and demonstrates ,more knowlege of basic algorithms.
	/// </summary>
	public class SaveToFile
	{
		//file dialogs to handle our opening and saving
		public OpenFileDialog ofd;
		public SaveFileDialog sfd;
		
		//characters that are added to our data when saved, this allows our data to be read and sorted from a txt file more easily
		// start char signifies the start of a new line
		private readonly char startChar;
		//endchar signifies the end of a line
		private readonly char endChar;
		//sepchar is a seperating character, to keep data isolated
		private readonly char sepChar;
		
		//a string stores our filepath
		public string myFilePath;
		
		public SaveToFile()
		{
			//init file dialogs
			ofd = new OpenFileDialog();
			sfd = new SaveFileDialog();
			
			//adding a filter requires users to save to txt 
			sfd.Filter = ".txt file|*.txt";
			
			//init chosen characters
			startChar = '>';
			endChar = '@';
			sepChar = ' ';
		}
		//this method handles saving our arrays data to file.
		public void SaveArray(string filePath, decimal[,] myArray)
		{
			try
			{
				StreamWriter sw = new StreamWriter(File.Create(filePath));
	            
				//nested for loops allow full traversal of our 2 dimensional array
				//this results in a textfile with each line representing a location, and each figure on that line represetning a months temperature
				for(int i=0; i<myArray.GetLength(0); i++)
				{
					for(int i1=0; i1<myArray.GetLength(1); i1++)
					{
						//if this is the first character on that line, add the start char
						if(i1 == 0)
						{
							sw.Write(startChar);
						}
						//if this is the last character on that line, add the last char and line break (uses writeline instead of write)
						if(i1 == (myArray.GetLength(1)-1))
						{
							sw.WriteLine((""+myArray[i,i1])+sepChar+endChar);
						}
						//writes data+seperator char onto the current line
						else
						{
							sw.Write((""+myArray[i,i1])+sepChar);
						}
					}
				}
				
	            sw.Dispose();
			}
			catch(Exception ee)
			{
				MessageBox.Show(ee.Message,"Alert");
			}
		}
		//this method handles saving our arrays data to file after launching a dialog.
		public void SaveArrayDialog(string initialFileName, decimal[,] myArray)
		{
			// settign the initial factors of our file keeps data consistenetly organised, however the user can still specifiy changes for special cases
			sfd.FileName = initialFileName;
			//saving to the current directory means the file is always in an existing location, and can be run portably
			sfd.InitialDirectory = Directory.GetCurrentDirectory();
			
			if (sfd.ShowDialog() == DialogResult.OK)
            {
				myFilePath = sfd.FileName;
                SaveArray(sfd.FileName, myArray);
            }
		}
		//this method handles loading our data to our array
		public void OpenArray(string filePath, decimal[,] myArray)
		{
			
			try{
				StreamReader sr = new StreamReader(File.OpenRead(filePath));
				string loadedContent = "";
				int location = 0;
				bool readFile = true;
				while(readFile)
				{
					loadedContent = sr.ReadLine();
					
					if(loadedContent!=null)
					{
						
						int month = 0;
						string no = "";
						for(int i=0; i<loadedContent.Length; i++)
						{
							if(loadedContent[i]!=endChar && loadedContent[i]!=sepChar && loadedContent[i]!=startChar)
							{
								no = no + loadedContent[i];
							}
							if(loadedContent[i]==sepChar)
							{
								MainForm.temperature[location,month] = Convert.ToDecimal(no);
								month++;
								no = "";
							}
						}
						location++;
					}
					else
					{
						readFile = false;
					}
					
				}
				sr.Dispose();
			}
			catch(Exception ee)
			{
				MessageBox.Show(ee.Message,"Alert");
				myFilePath = null;
			}
		}
		//this method handles loading our data to our array after launching a dialog
		public void OpenArrayDialog(decimal[,] myArray)
		{
			ofd.InitialDirectory = Directory.GetCurrentDirectory();
			
			if (ofd.ShowDialog() == DialogResult.OK)
            {
				myFilePath = ofd.FileName;
                OpenArray(ofd.FileName, myArray);
            }
		}
	}
}
