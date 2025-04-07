using Assignment2;

namespace Assignment2
{
	internal class Program
	{
		public static string? Menu()
		{
			Console.WriteLine("1: Add New Student");
			Console.WriteLine("2: Add New Course");
			Console.WriteLine("3: Register Student to Course");
			Console.WriteLine("4: Display All Students");
			Console.WriteLine("5: Display All Courses");
			Console.WriteLine("6: Display All Registrations");
			Console.WriteLine("7: Save Data");
			Console.WriteLine("8: Load Data");
			Console.WriteLine("9: Exit");
			Console.WriteLine("Enter number 1-9: ");
			return Console.ReadLine();
		}

		static void Main(string[] args)
		{
			College college = new College();

			while (true)
			{
				var choice = Menu();
				switch (choice)
				{
					case "1":
						college.AddStudent();
						break;
					case "2":
						college.AddCourse();
						break;
					case "3":

						break;
					case "4":
						college.DisplayStudents();
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