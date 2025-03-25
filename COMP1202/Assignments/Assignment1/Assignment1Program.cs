
namespace Assignment1
{
	/* 
	 * Elizabeth House
	 * StudentID: 101465946
	 * Date: 02/05/2025
	 */
	internal class Assignment1Program
	{
		private static DateTime todaysDate = DateTime.Now;
		private static DateTime birthdate;
		private static string reversedString = string.Empty;

		// Print Main menu
		public static string? Menu()
		{
			Console.WriteLine("-----------------------------------");
			Console.WriteLine("             MAIN MENU             ");
			Console.WriteLine("-----------------------------------");
			Console.WriteLine(" 1 - Display Information");
			Console.WriteLine(" 2 - Date and Time Operations");
			Console.WriteLine(" 3 - Text Operations");
			Console.WriteLine(" 4 - Exit");
			Console.WriteLine("-----------------------------------\n");
			Console.WriteLine("Enter a number 1-4:");

			return Console.ReadLine();
		}

		// Print Submenu for Date & Time Operations
		public static string? PrintSubmenuDateTime()
		{

			Console.WriteLine("------------------------------------");
			Console.WriteLine("       DATE & TIME OPERATIONS       ");
			Console.WriteLine("------------------------------------");
			Console.WriteLine(" 1 - Display Current Date & Time");
			Console.WriteLine(" 2 - Add Days to Current Date");
			Console.WriteLine(" 3 - Calculate Age from Birthdate");
			Console.WriteLine(" 4 - Return to Main Menu");
			Console.WriteLine("-----------------------------------\n");
			Console.WriteLine("Enter a number 1-4:");

			return Console.ReadLine();
		}

		// Print Submenu for Text Operations
		public static string? PrintSubmenuTextOperations()
		{
			Console.WriteLine("-----------------------------------");
			Console.WriteLine("          TEXT OPERATIONS          ");
			Console.WriteLine("-----------------------------------");
			Console.WriteLine(" 1 - Reverse Text");
			Console.WriteLine(" 2 - Convert to Uppercase");
			Console.WriteLine(" 3 - Convert to Lowercase");
			Console.WriteLine(" 4 - Return to Main Menu");
			Console.WriteLine("-----------------------------------\n");
			Console.WriteLine("Enter a number 1-4:");

			return Console.ReadLine();
		}

		/* Do I reverse the characters? Or do I reverse the words? Those are 2 diff things.
		Method 1: Manual processing by looping backwards through array 
		Method 2: Using built-in method
		*/
		public static string? Reverse(string input)
		{
			char[] charArray = input.ToCharArray();

			/*for (int i = charArray.Length - 1; i > -1; i--)
			{

				reversedString += charArray[i];
			}*/

			Array.Reverse(charArray);
			reversedString = new string(charArray);

			return reversedString;
		}

		// Prompt and return a line read from console input by user for processing 
		public static string? GetUserInput(string prompt)
		{
			Console.WriteLine(prompt);

			return Console.ReadLine();
		}

		// Check if the string is null or empty before we process it
		public static bool IsValidString(string input)
		{
			if (string.IsNullOrEmpty(input))
				return false;

			return true;
		}

		// Check if the user input a valid date string and try to parse that to date time
		public static bool IsValidDate(string date)
		{
			while (true)
			{
				if (!DateTime.TryParse(date, out birthdate))
				{
					Console.WriteLine("Incorrect format. Please enter your birthdate:");
					date = Console.ReadLine();
				}
				else
					break;
			}

			return true;
		}

		// Do math and calculate the age from the given birthdate 
		public static int GetAge()
		{
			int age = todaysDate.Year - birthdate.Year;

			// Adjust age if birthday has not passed yet
			if (todaysDate.Month < birthdate.Month && todaysDate.Day < birthdate.Day)
				age--;

			return age;
		}

		// Main menu {outer menu} selection
		static void Main(string[] args)
		{
			while (true)
			{
				var choice = Menu();

				switch (choice)
				{
					case "1": // Display student information ✓
						Console.WriteLine("\nElizabeth House");
						Console.WriteLine("COMP1202");
						Console.WriteLine("CRN: 48944");
						Console.WriteLine("Student ID: 101465946\n");
						break;
					// Get selection for Date & Time Operations ✓
					case "2":
						DateTimeSelection();
						break;
					// Get selection for Text Operations ✓
					case "3":
						TextMenuSelection();
						break;
					// Exit the program ✓
					case "4":
						Console.WriteLine("Exiting...");
						return;
					// Handle invalid input ✓
					default:
						Console.WriteLine("Invalid input.\n");
						break;
				}
			}
		}

		// DateTime operations submenu {inner menu} selection 
		static void DateTimeSelection()
		{
			while (true)
			{
				// Print the submenu
				var choice = PrintSubmenuDateTime();

				switch (choice)
				{
					// Display current date and time ✓
					case "1":
						Console.WriteLine($"\nThe date is: {todaysDate}\n");
						break;
					// Add days to current date, loop until valid input is given ✓
					case "2":
						{
							int days = 0;
							Console.WriteLine("\nHow many days would you like to add?");

							while (true)
							{
								try
								{
									days = Convert.ToInt32(Console.ReadLine());
									break;
								}
								catch (FormatException ex)
								{
									Console.WriteLine($"{ex.Message} You must enter an integer.");
								}
								catch (OverflowException of)
								{
									Console.WriteLine($"{of.Message} Enter a new integer.");
								}
							}

							DateTime newDate = todaysDate.AddDays(days);
							Console.WriteLine($"New Date is: {newDate}\n");
						}
						break;
					// Calculate the age from user's birthdate 
					case "3":
						{

							Console.WriteLine("Enter your birthdate: ");
							string dateString = Console.ReadLine();

							while (!IsValidDate(dateString))
							{
								Console.WriteLine("Enter your birthdate: ");
								dateString = Console.ReadLine();
							}

							int age = GetAge();
							Console.WriteLine($"You are {age} years old.");
						}
						break;

					// Return to main menu ✓
					case "4":
						return;
					// User entered something other than 1-4 ✓
					default:
						Console.WriteLine("Invalid input.\n");
						break;
				}
			}
		}

		// Text operations submenu {inner menu} selection
		static void TextMenuSelection()
		{
			while (true)
			{
				var choice = PrintSubmenuTextOperations();
				string textInput;

				switch (choice)
				{
					// Reverse text ✓
					case "1":
						{
							textInput = GetUserInput("\nEnter a line of text to reverse: ");

							while (!IsValidString(textInput))
							{
								Console.WriteLine("\nEnter a line of text: ");
								textInput = Console.ReadLine();
							}

							Reverse(textInput);
							Console.WriteLine($"Reversed String: {reversedString}");
							//textInput = String.Empty;
						}
						break;
					// Convert to uppercase ✓
					case "2":
						{
							textInput = GetUserInput("\nEnter a line of text to convert to uppercase: ");

							while (!IsValidString(textInput))
							{
								Console.WriteLine("\nEnter a line of text: ");
								textInput = Console.ReadLine();
							}

							string inputToUpper = textInput.ToUpper();
							Console.WriteLine($"{inputToUpper}\n");
						}

						break;
					// Convert to lowercase ✓
					case "3":
						{
							textInput = GetUserInput("\nEnter a line of text to convert to lowercase: ");

							while (!IsValidString(textInput))
							{
								Console.WriteLine("\nEnter a line of text: ");
								textInput = Console.ReadLine();
							}

							string inputToLower = textInput.ToLower();
							Console.WriteLine($"{inputToLower}\n");
						}
						break;
					// Return to main menu ✓
					case "4":
						return;
					// User entered something other than 1-4
					default:
						Console.WriteLine("Invalid input.\n");
						break;
				}
			}
		}
	}
}
