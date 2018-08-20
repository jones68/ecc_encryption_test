/*
 * Created by SharpDevelop.
 * Author: Jordan Jones
 * Date: 2018-06-27
 * Time: 8:34 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;

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
			Debug.Assert(datawordLength == dwordLength);
			
			bits = new bool[datawordLength];
			
			validateData(data);
			setBits(data);
		}
		
		
		//TODO: actual exceptions/error messages
		private void validateData(string data)
		{
		
			for (int i = 0; i < datawordLength; i++)
			{
				Debug.Assert(data[i] == '1' || data[i] == '0');
			}
		
		}
		
		
		public bool[] getBits()
		{
		
			return this.bits;
		
		}
		
		
		private void setBits(string data)
		{
			bits = new bool[data.Length];
			for (int i = 0; i < datawordLength; i++)
			{
				if(data[i] == '0')
				{
					bits[i] = false;
				}
				else
				{
					bits[i] = true;
				}
					
			}
		
		}
		
		
		private void setBits(bool[] data)
		{
		
			Debug.Assert(data.Length == bits.Length);
			
			for (int i = 0; i < data.Length; i++)
			{
				bits = new bool[data.Length];
				bits[i] = data[i];
			}
			
		}
		
		
		private string bitsToString(bool[] bitsToConvert)
		{
		
			int[] intBits = new int[bitsToConvert.Length];
			for (int i = 0; i < bitsToConvert.Length; i++)
			{
			
				intBits[i] = Convert.ToInt32(bitsToConvert[i]);
			
			}
			
			return string.Join("", intBits);
		
		}
		
		
		//Operations we can do on datawords
		//for now, datawords must be the same length
		//TODO
		private Dataword xor(Dataword d2)
		{
			//write xor function
			
			Debug.Assert(datawordLength == d2.datawordLength);
			bool[] result_bits = new bool[datawordLength];
			
			for (int i = 0; i < datawordLength; i++)
			{
			
				result_bits[i] = bits[i] ^ d2.getBits()[i];
				
			}
			
			string result_data = bitsToString(result_bits);
			
			Dataword result = new Dataword(result_data, datawordLength);
			
			return result;
			
		}
		
		
		private Dataword and(Dataword d2)
		{
		
			Debug.Assert(datawordLength == d2.datawordLength);
			bool[] result_bits = new bool[datawordLength];
			
			for (int i = 0; i < datawordLength; i++)
			{
			
				result_bits[i] = bits[i] && d2.getBits()[i];
				
			}
			
			string result_data = bitsToString(result_bits);
			
			Dataword result = new Dataword(result_data, datawordLength);
			
			return result;
			
		}
		
		
		private Dataword or(Dataword d2)
		{
			Debug.Assert(datawordLength == d2.datawordLength);
			bool[] result_bits = new bool[datawordLength];
			
			for (int i = 0; i < datawordLength; i++)
			{
			
				result_bits[i] = bits[i] || d2.getBits()[i];
				
			}
			
			string result_data = bitsToString(result_bits);
			
			Dataword result = new Dataword(result_data, datawordLength);
			
			return result;
				
		
		}

		
	}
}
