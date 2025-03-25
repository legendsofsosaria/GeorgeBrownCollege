namespace Assignment2
{
	internal class Program
	{
		public static string? Menu()
		{
			Console.WriteLine("1: Add Student");
			Console.WriteLine("2: Add Course");
			Console.WriteLine("3: Register Student to Course");
			Console.WriteLine("4: Display All Students");
			Console.WriteLine("5: Display All Courses");
			Console.WriteLine("6: Display Registrations");
			Console.WriteLine("7: Save Data");
			Console.WriteLine("8: Load Data");
			Console.WriteLine("9: Exit");
			Console.WriteLine("Enter number 1-9: ");
			return Console.ReadLine();
		}

		static void Main(string[] args)
		{
			while (true)
			{
				var choice = Menu();
				switch (choice)
				{
					case "1":
						College.AddStudent();
						break;
					case "2":
						
						break;
					case "3":
						
						break;
					case "4":
						
						break;
					case "5":
						
						break;
					case "6":
						break;
					case "7":
						break;
					case "8":
						break;
					case "9": return;
					default:
						Console.WriteLine("Invalid input.");
						break;
				}
			}
		}
	}
}
