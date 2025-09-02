/*
Elizabeth House 101465946
Munir Howlader 101172332
Assignment 2
*/

using Assignment2;

namespace Assignment2
{
	internal class Program
	{
		// Menu options to print to the console
		public static string? Menu()
		{
			Console.WriteLine("\n-------------------------------------------");
			Console.WriteLine("Main Menu:");
			Console.WriteLine("----------");
			Console.WriteLine("1: Student Management");
			Console.WriteLine("2: Course Management");
			Console.WriteLine("3: Course Registration");
			Console.WriteLine("4: Display All Students");
			Console.WriteLine("5: Display All Courses");
			Console.WriteLine("6: Display All Registrations");
			Console.WriteLine("7: Save Data");
			Console.WriteLine("8: Load Data");
			Console.WriteLine("9: Exit");
			Console.WriteLine("-------------------------------------------");
			Console.WriteLine("Enter number 1-9: ");
			return Console.ReadLine();
		}

		public static string? StudentManagementMenu()
		{
			Console.WriteLine("\n-------------------------------------------");
			Console.WriteLine("Student Management:");
			Console.WriteLine("-------------------");
			Console.WriteLine("1: Add New Student");
			Console.WriteLine("2: Remove a Student");
			Console.WriteLine("3: Go back to main menu");
			Console.WriteLine("-------------------------------------------");
			Console.Write("Enter number 1-3: ");
			return Console.ReadLine();
		}

		public static string? CourseManagementMenu()
		{
			Console.WriteLine("\n-------------------------------------------");
			Console.WriteLine("Course Management:");
			Console.WriteLine("------------------");
			Console.WriteLine("1: Add New Course");
			Console.WriteLine("2: Remove a Course");
			Console.WriteLine("3: Go back to main menu");
			Console.WriteLine("-------------------------------------------");
			Console.Write("Enter number 1-3: ");
			return Console.ReadLine();
		}

		public static string? CourseRegistrationMenu()
		{
			Console.WriteLine("\n-------------------------------------------");
			Console.WriteLine("Course Registration:");
			Console.WriteLine("--------------------");
			Console.WriteLine("1: Register Student To Course");
			Console.WriteLine("2: De-Register Student From Course");
			Console.WriteLine("3: Go back to main menu");
			Console.WriteLine("-------------------------------------------");
			Console.Write("Enter number 1-3: ");
			return Console.ReadLine();
		}

		public static string? DisplayRegistrationMenu()
		{
			Console.WriteLine("\n-------------------------------------------");
			Console.WriteLine("Display All Registrations:");
			Console.WriteLine("--------------------------");
			Console.WriteLine("1: Display Registration Status Of A Student");
			Console.WriteLine("2: Display All Registered Students Of A Course");
			Console.WriteLine("3: Display All Students That Have Not Yet Registered To Any Course");
			Console.WriteLine("4: Go back to main menu");
			Console.WriteLine("-------------------------------------------");
			Console.Write("Enter number 1-4: ");
			return Console.ReadLine();
		}

		// Main handles creating the college instance and calling methods for the menu options
		static void Main(string[] args)
		{
			College college = new College();
			college.Load();
			Console.WriteLine($"Loaded {college.Students.Count} students, {college.Courses.Count} courses, {college.Registrations.Count} registrations.");

			while (true)
			{
				var choice = Menu();

				switch (choice)
				{
					case "1": // Student Management submenu
						while (true)
						{
							Console.Clear();
							var studentChoice = StudentManagementMenu();

							if (studentChoice == "3")
							{
								break;
							}

							switch (studentChoice)
							{
								case "1":
									college.AddStudent();
									MenuHelper();
									break;
								case "2":
									college.RemoveStudent();
									MenuHelper();
									break;
								default:
									Console.WriteLine("Invalid input. Please choose 1-3.");
									break;
							}
						}
						break;

					case "2": // Course Management submenu
						while (true)
						{
							Console.Clear();
							var courseChoice = CourseManagementMenu();

							if (courseChoice == "3")
							{
								break;
							}

							switch (courseChoice)
							{
								case "1":
									college.AddCourse();
									MenuHelper();
									break;
								case "2":
									college.RemoveCourse();
									MenuHelper();
									break;
								default:
									Console.WriteLine("Invalid input. Please choose 1-3.");
									break;
							}
						}
						break;

					case "3": // Course Registration submenu
						while (true)
						{
							Console.Clear();
							var registrationChoice = CourseRegistrationMenu();

							if (registrationChoice == "3")
							{
								break;
							}

							switch (registrationChoice)
							{
								case "1":
									college.RegisterStudent();
									MenuHelper();
									break;
								case "2":
									college.DeRegisterStudent();
									MenuHelper();
									break;
								default:
									Console.WriteLine("Invalid input. Please choose 1-3.");
									break;
							}
						}
						break;

					case "4":
						college.DisplayStudents();
						MenuHelper();
						break;
					case "5":
						college.DisplayCourses();
						MenuHelper();
						break;
					case "6": // Display Registrations info
						while (true)
						{
							var registrationChoice = DisplayRegistrationMenu();

							if (registrationChoice == "4")
							{
								break;
							}

							switch (registrationChoice)
							{
								case "1":
									college.DisplayRegistrationStudent();
									MenuHelper();
									break;
								case "2":
									college.DisplayRegistrationCourse();
									MenuHelper();
									break;
								case "3":
									college.DisplayNonRegistered();
									MenuHelper();
									break;
								default:
									Console.WriteLine("Invalid input. Please choose 1-4.");
									break;
							}
						}
						break;

					case "7":
						// Save Data functionality here ---> May remove this later
						college.Save();
						Console.WriteLine("Data saved");
						MenuHelper();
						break;
					case "8":
						// Load Data functionality here ---> May remove this later
						college.Load();
						Console.WriteLine("Data loaded");
						MenuHelper();
						break;
					case "9":
						return; // Exit the program
					default:
						Console.WriteLine("Invalid input. Please choose a valid option.");
						break;
				}
			}
		}

		public static void MenuHelper()
		{
			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();
			Console.Clear(); 
		}
	}
}