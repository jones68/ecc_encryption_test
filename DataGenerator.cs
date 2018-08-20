/*
 * Created by SharpDevelop.
 * User: J
 * Date: 2018-06-27
 * Time: 8:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ecc_encryption_test
{
	/// <summary>
	/// Once initialized, is capable of producing random datawords with one dataword length. If we want to 
	/// generate datawords with a variety of lengths, we need to instantiate multiple DataGenerators.
	/// </summary>
	public class DataGenerator
	{
		
		
		readonly int datawordLength;
		
		
		public DataGenerator(int datawordLength)
		{
			this.datawordLength = datawordLength;
		}
		
		
		public Dataword createRandomDataword() 
		{
			string data = "";
			Random random = new Random();
			int bitChooser;
			int nextBit;
			
			for (int i = 1; i < datawordLength; i++)
			{
				bitChooser = random.Next(1,101);
				
				if(bitChooser > 50.5)
				{
					nextBit = 1;
				}
				else
				{
					nextBit = 0;
				}
				
				data = data + nextBit.ToString();
			}
			
			return createKnownDataword(data);
		}
		
		
		//Creates a dataword with known entries based on a string input, eg "101010"
		public Dataword createKnownDataword(string data)
		{
		
			return new Dataword(data, datawordLength);
		
		}
		
	}
}
