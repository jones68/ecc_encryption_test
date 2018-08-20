/*
 * Created by SharpDevelop.
 * User: J
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
	public class Encoder
	{
		
		Dataword bufferedDWord;
		private int parityLength;
		
		public Encoder(int parityLength)
		{
			this.parityLength = parityLength;
		}
		
		//Stores the dataword we want to encode internally in the encoder. To bear resemblance to a hardware implementation
		public void bufferDataword(Dataword dword)
		{
			this.bufferedDWord = dword;
		}
		
		
		public Dataword encode()
		{
			Dataword parity = calculateParity();
		
			Dataword codeword = concatenate(bufferedDWord,parity);
		
			return codeword;
		}
		
		//Dummy parity at the moment
		private Dataword calculateParity()
		{
			Dataword parity = new Dataword("1", parityLength);
			return parity;
		}
		
		
		//dummy return value at the moment
		private Dataword concatenate(Dataword d1, Dataword d2)
		{
		
			return d1;
		
		}
		
	}
}
