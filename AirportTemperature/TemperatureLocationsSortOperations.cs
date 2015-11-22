/*
 * Created by SharpDevelop.
 * User: Robert
 * Date: 13/12/2014
 * Time: 11:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Globalization;

namespace AirportTemperature
{
	/// <summary>
	/// this is a class that handles manipulating data stored in our main array
	/// the array.sort method exists, but i don't want to modify the actual arrays structure, so liberal use of loops is applied
	/// assumes arrays in the format decimal[location, month]
	/// </summary>
	public class TemperatureLocationsSortOperations
	{
		decimal ignore;
		
		
		public TemperatureLocationsSortOperations(decimal ignoreFig)
		{
			ignore = ignoreFig;
			
		}
		public decimal GetAverageTemperatureByLocation(decimal[,] myArray, int indexLocation)
		{
			decimal average = 0;
			int count = 0;
			
			for(int i=0; i<myArray.GetLength(1); i++)
			{
				if(myArray[indexLocation,i] != ignore)
				{
					average += myArray[indexLocation,i];
					count++;
				}
				
			}
			
			try
			{
				average = average/count;
			}
			catch(Exception ee)
			{
				
			}

			return Math.Round(average,2);
		}
		public decimal GetAverageTemperatureByMonth(decimal[,] myArray, int indexMonth)
		{
			decimal average = 0;
			int count = 0;
			
			for(int i=0; i<myArray.GetLength(0); i++)
			{
				if(myArray[i,indexMonth] != ignore)
				{
					average += myArray[i,indexMonth];
					count++;
				}
				
			}
			
			try
			{
				average = average/count;
			}
			catch(Exception ee)
			{
				
			}
			
			return Math.Round(average,2);
		}
		public decimal GetHighestTemperatureByLocation(decimal[,] myArray, int indexLocation)
		{
			decimal highest = -100;
			
			for(int i=0; i<myArray.GetLength(1); i++)
			{
				if(highest<myArray[indexLocation,i] && myArray[indexLocation,i] != ignore)
				{
					highest = myArray[indexLocation,i];
				}
			}
			
			return highest;
		}
		public decimal GetHighestTemperatureByMonth(decimal[,] myArray, int indexMonth)
		{
			decimal highest = -100;
			
			for(int i=0; i<myArray.GetLength(0); i++)
			{
				if(highest<myArray[i,indexMonth] && myArray[i,indexMonth] != ignore)
				{
					highest = myArray[i,indexMonth];
				}
			}
			
			return highest;
		}
		public string GetHighestTemperatureMonthByLocation(decimal[,] myArray, int indexLocation)
		{
			int highestIndex = 0;
			decimal highest = -100;
			
			for(int i=0; i<myArray.GetLength(1); i++)
			{
				if(highest<myArray[indexLocation,i] && myArray[indexLocation,i] != ignore)
				{
					highest = myArray[indexLocation,i];
					highestIndex = i;
				}
			}
			DateTimeFormatInfo myDateInfo = new DateTimeFormatInfo();
			return myDateInfo.GetMonthName(highestIndex+1);
		}
		public decimal GetLowestTemperatureByLocation(decimal[,] myArray, int indexLocation)
		{
			decimal lowest = 100;
			
			for(int i=0; i<myArray.GetLength(1); i++)
			{
				if(lowest>myArray[indexLocation,i] && myArray[indexLocation,i] != ignore)
				{
					lowest = myArray[indexLocation,i];
				}
			}
			
			return lowest;
		}
		public decimal GetLowestTemperatureByMonth(decimal[,] myArray, int indexMonth)
		{
			decimal lowest = 100;
			
			for(int i=0; i<myArray.GetLength(0); i++)
			{
				if(lowest>myArray[i,indexMonth] && myArray[i,indexMonth] != ignore)
				{
					lowest = myArray[i,indexMonth];
				}
			}
			
			return lowest;
		}
		public string GetLowestTemperatureMonthByLocation(decimal[,] myArray, int indexLocation)
		{
			int lowestIndex = 0;
			decimal lowest = 100;
			
			for(int i=0; i<myArray.GetLength(1); i++)
			{
				if(lowest>myArray[indexLocation,i] && myArray[indexLocation,i] != ignore)
				{
					lowest = myArray[indexLocation,i];
					lowestIndex = i;
				}
			}
			DateTimeFormatInfo myDateInfo = new DateTimeFormatInfo();
			return myDateInfo.GetMonthName(lowestIndex+1);
		}
		//TODO maybe implement?
		public string GetHighestTemperatureMonth(decimal[,] myArray)
		{
			int highestIndex = 0;
			decimal highest = -100;
			
			for(int i=0; i<myArray.GetLength(0); i++)
			{
				for(int i1=0; i1<myArray.GetLength(1); i1++)
				{
					if(highest<myArray[i,i1] && myArray[i,i1] != ignore)
					{
						highest = myArray[i,i1];
						highestIndex = i1;
					}
				}
			}
			
			DateTimeFormatInfo myDateInfo = new DateTimeFormatInfo();
			
			return  myDateInfo.GetMonthName(highestIndex+1);
			
		}
	}
}
