namespace LabTest1
{
	/* Elizabeth House
	 * Lab Test 1
	 * 2025/02/04
	 * Student ID: 101465946
	 * Due Time: 1 PM Atlantic
	 * 
	 */
	internal class LabTest1Program
	{
		private double m_heightInMeters;
		private double m_BMI;

		public double BMI { get { return m_BMI; } set { m_BMI = value; } }
		public double heightInMeters { get { return m_heightInMeters; } set { m_heightInMeters = value; } }

		public double ConvertHeightToMeters(double height)
		{
			m_heightInMeters = height / 10.0;

			return m_heightInMeters;
		}

		public double CalculateBMI(double weight, double height)
		{
			m_BMI = weight / Math.Pow(heightInMeters, 2);

			return m_BMI;
		}

		public static string DetermineLanguageProficiency(int language)
		{
			// Return the string for the language profiency
			switch (language)
			{
				case 1:
					return "Beginner";
				case 2:
					return "Bilingual";
				case 3: return "Polyglot";
				default:
					return "Invalid";
			}
		}

		// Print the user info and format it 
		public static void PrintUserProfile(string name, double BMI, int language)
		{
			Console.WriteLine($"Your BMI is: {BMI:F2}");
			string languageSkill = DetermineLanguageProficiency(language);
			Console.WriteLine($"Your language skill is: {languageSkill}");
		}

		static void Main(string[] args)
		{
			bool valid = false;
			bool restart = true;
			double height = 0.0;
			double weight = 0.0;
			int language = 0;

			// Repeat loop until user quits
			while (restart == true)
			{
				// Repeat loop until valid info is entered
				while (!valid)
				{
					try
					{
						Console.WriteLine("Enter your name: ");
						string name = Console.ReadLine();

						Console.WriteLine("Enter your height in cm: ");
						height = Convert.ToDouble(Console.ReadLine());

						Console.WriteLine("Enter your weight in kilograms: ");
						weight = Convert.ToDouble(Console.ReadLine());

						Console.WriteLine("Enter the number of languages you speak: ");
						language = Convert.ToInt32(Console.ReadLine());

						valid = true;

						ConvertHeightToMeters(height);
						CalculateBMI(weight, heightInMeters);
						PrintUserProfile(name, BMI, language);
					}
					catch (FormatException fe)
					{
						Console.WriteLine(fe.Message);
					}
					catch (OverflowException o)
					{
						Console.WriteLine($"The number is too big: {o.Message}");
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
					}
				}
				Console.WriteLine("Repeat the program? Yes or No");

				string input = Console.ReadLine();
				// Convert the input to uppercase so less cases have to be validated for correct input
				string upperInput = input.ToUpper();


				if (upperInput == "N" || upperInput == "NO")
				{
					restart = false;
				}


				else if (upperInput == "Y" || upperInput == "YES")
				{
					valid = false;
				}

				else
				{
					Console.WriteLine("Invalid input. Try again.");
				}
			}
		}
	}
}
