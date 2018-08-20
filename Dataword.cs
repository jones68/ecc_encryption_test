/*
 * Created by SharpDevelop.
 * Author: Jordan Jones
 * Date: 2018-06-27
 * Time: 8:34 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ecc_encryption_test
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Dataword
	{
		
		bool[] bits;
		readonly int datawordLength;
		
		public Dataword(string data, int dwordLength)
		{
			datawordLength = data.Length;
			assert(datawordLength == dwordLength);
			
			bits = new bool[datawordLength];
			
			validateData(data);
			setBits(data);
		}
		
		
		//TODO: actual exceptions/error messages
		private void validateData(string data)
		{
		
			for (int i = 0; i < datawordLength; i++)
			{
				assert(data[i] == "1" || data[i] == "0");
			}
		
		}
		
		
		
		private void setBits(string data)
		{
			
			for (int i = 0; i < datawordLength; i++)
			{
				if(data[i] == "0")
				{
					bits[i] = false;
				}
				else
				{
					bits[i] = true;
				}
					
			}
		
		}
		
		
		//Operations we can do on datawords
		//for now, datawords must be the same length
		//TODO
		private Dataword xor(Dataword d2)
		{
			//write xor function
			
			assert(datawordLength == d2.datawordLength);
		}
		
		
		private Dataword and(Dataword d2)
		{
		
			assert(datawordLength == d2.datawordLength);
		}
		
		
		private Dataword or(Dataword d2)
		{
			assert(datawordLength == d2.datawordLength);
			
			
		
		}

		
	}
}
