/*
 * Created by SharpDevelop.
 * Author: Jordan Jones
 * Create Date: 2018-06-27
 * Create Time: 8:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;

namespace ecc_encryption_test
{
	/// <summary>
	/// Object to encapsulate all input params.
	/// </summary>
	public class Parameters
	{
		
		//Will add more as needed
		readonly int numDatawords;
		readonly int datawordLength;
		readonly int parityLength;
		readonly float errorStrength;
		
		
		public Parameters(int custom, int numDatawords, int datawordLength, int parityLength, float errorStrength)
		{
			if (custom == 0){
				this.numDatawords = Defaults.DEFAULT_NUM_DATAWORDS;
				this.datawordLength = Defaults.DEFAULT_DATAWORD_LENGTH;
				this.parityLength = Defaults.DEFAULT_PARITY_LENGTH;
				this.errorStrength = Defaults.DEFAULT_ERROR_STRENGTH;
			}
			
			else {
				this.numDatawords = numDatawords;
				this.datawordLength = datawordLength;
				this.parityLength = parityLength;
				this.errorStrength = errorStrength;
			}
			
			checkParamsValid();
			
		}
		
		private void checkParamsValid()
		{
			Debug.Assert(numDatawords <= Defaults.MAX_NUM_DATAWORDS && numDatawords >= Defaults.MIN_NUM_DATAWORDS);
			Debug.Assert(datawordLength <= Defaults.MAX_DATAWORD_LENGTH && datawordLength >= Defaults.MIN_DATAWORD_LENGTH);
			Debug.Assert(parityLength <= Defaults.MAX_PARITY_LENGTH && numDatawords >= Defaults.MIN_PARITY_LENGTH);
			Debug.Assert(errorStrength <= Defaults.MAX_ERROR_STRENGTH && errorStrength >= Defaults.MIN_ERROR_STRENGTH);		
			
		}
	}
}
