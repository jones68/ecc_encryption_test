/*
 * Created by SharpDevelop.
 * User: J
 * Date: 2018-06-27
 * Time: 8:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ecc_encryption_test
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public static class Defaults
	{
		
		//Do we need a constructor?
		//public Defaults()
		//{
		//}
		
		public static int DEFAULT_NUM_DATAWORDS = 1;
		public static int DEFAULT_DATAWORD_LENGTH = 8;
		public static int DEFAULT_PARITY_LENGTH = 4;
		public static float DEFAULT_ERROR_STRENGTH = 1;
		
		public static int MAX_NUM_DATAWORDS = 100;
		public static int MAX_DATAWORD_LENGTH = 128;
		public static int MAX_PARITY_LENGTH = 128;
		public static float MAX_ERROR_STRENGTH = 10;
		
		public static int MIN_NUM_DATAWORDS = 1;
		public static int MIN_DATAWORD_LENGTH = 4;
		public static int MIN_PARITY_LENGTH = 2;
		public static int MIN_ERROR_STRENGTH = 0;
		
		
		
	}
}
