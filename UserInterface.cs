/*
 * Created by SharpDevelop.
 * Author: Jordan Jones
 * Date: 2018-06-27
 * Time: 8:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ecc_encryption_test
{
	/// <summary>
	/// Handles all interaction with the user. Asks for input parameters, and then presents results once tests are done.
	/// </summary>
	public class UserInterface
	{
		
		
		int custom = 0;
		
		//Constructor
		public UserInterface()
		{
			displayWelcomeMessage();
		}
		
		
		//gets from user whether we will be using custom or default params
		private int getCustom()
		{
			//will come from user input
			string custom;
			
			Console.WriteLine("Please enter 1 to use custom values and 0 to use default values.");
			custom = Console.ReadLine();
			
			assert(custom == "1" || custom == "0");
			
			this.custom = ToInt32(custom);
			return ToInt32(custom);
		}
		
		
		public Parameters createParams()
		{
			custom = getCustom();
			
			Parameters inputParams;
			
			if(custom != 0){
				//Then we are using user defined values
				int numDatawords = getNumDatawordsFromUser();
				int datawordLength = getDatawordLengthFromUser();
				int parityLength = getParityLengthFromUser();
				float errorStrength = getErrorStrengthFromUser();
			
				inputParams = new Parameters(1,numDatawords,datawordLength,parityLength,errorStrength);
			}
			
			else 
			//We are using defaults	
			{
				inputParams = new Parameters(0,0,0,0,0); //it doesn't matter what the other inputs are to Parameters() if the first entry is 0, as that is the signal to use defaults
			}
			
			return inputParams;
		
		}
		
		private void displayWelcomeMessage()
		{
			Console.WriteLine("Welcome to Jordan's ECC Encryption Engine! We are going to have a ton of fun today!");
		}
		
		
		private int getNumDatawordsFromUser()
		{
			bool validInput = false;
			int numDatawords;
			while(validInput == false)
			{
				Console.WriteLine("Please enter a number of datawords between {0} and {1}", Defaults.MIN_NUM_DATAWORDS, Defaults.MAX_NUM_DATAWORDS);
				numDatawords = ToInt32(Console.ReadLine());
				if(numDatawords <= Defaults.MAX_NUM_DATAWORDS && numDatawords >= Defaults.MIN_NUM_DATAWORDS)
				{
					validInput = true;
				}
				else 
				{
					Console.WriteLine("Error! That is not a valid number of datawords.\n\n");
				}
				
			}
			
			return numDatawords;
		}


		private int getDatawordLengthFromUser()
		{
			bool validInput = false;
			int datawordLength;
			while(validInput == false){
				Console.WriteLine("Please enter a dataword length between {0} and {1}", Defaults.MIN_DATAWORD_LENGTH, Defaults.MAX_DATAWORD_LENGTH);
				datawordLength = ToInt32(Console.ReadLine());
				
				if(datawordLength <= Defaults.MAX_DATAWORD_LENGTH && datawordLength >= Defaults.MIN_DATAWORD_LENGTH)
				{
					validInput = true;
				}
				else
				{
					Console.WriteLine("Error! That is not a valid dataword length.\n\n");
				}
			}
			
			return datawordLength;
		}


		private int getParityLengthFromUser()
		{
			bool validInput = false;
			int parityLength;
			
			while(validInput == false){
				Console.WriteLine("Please enter a parity length between {0} and {1}", Defaults.MIN_PARITY_LENGTH, Defaults.MAX_PARITY_LENGTH);
				parityLength = ToInt32(Console.ReadLine());
				
				if(parityLength <= Defaults.MAX_PARITY_LENGTH && parityLength >= Defaults.MIN_PARITY_LENGTH)
				{
					validInput = true;
				}
				else
				{
					Console.WriteLine("Error! That is not a valid parity length.\n\n");
				}
			}
			
			return parityLength;
		}

		
		private float getErrorStrengthFromUser()
		{
			bool validInput = false;
			float errorStrength;
			
			while(validInput == false){
				Console.WriteLine("Please select an error strength between {0} and {1}", Defaults.MIN_ERROR_STRENGTH, Defaults.MAX_ERROR_STRENGTH);
				errorStrength= ToFloat(Console.ReadLine());
				
				if(errorStrength <= Defaults.MAX_ERROR_STRENGTH && errorStrength >= Defaults.MIN_ERROR_STRENGTH)
				{
					validInput = true;
				}
				else
				{
					Console.WriteLine("Error! That is not a valid parity length.\n\n");
				}
			}
			
			return errorStrength;
			
		}		

	}
}
