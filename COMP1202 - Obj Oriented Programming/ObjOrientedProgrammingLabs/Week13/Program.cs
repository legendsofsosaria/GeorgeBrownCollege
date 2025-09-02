
using System.Text.Json;

namespace Week13
{
	// Serialization
	internal class Program
	{
		// List to store the students
		static List<Student> students = new List<Student>();

		// Program Menu
		public static string? Menu()
		{
			Console.WriteLine("\n--------Program--------");
			Console.WriteLine("1 - Add Student to the List");
			Console.WriteLine("2 - View All Students in the List");
			Console.WriteLine("3 - View Specific Student in the List");
			Console.WriteLine("4 - Remove a Student from the List");
			Console.WriteLine("5 - Exit Program\n");

			return Console.ReadLine();
		}

		// Save to JSON file
		public static void Save()
		{
			string jsonString = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });

			File.WriteAllText("StudentList.json", jsonString);

		}

		// Load data from JSON file
		public static void Load()
		{
			try
			{
				string jsonString = File.ReadAllText("StudentList.json");

				students = JsonSerializer.Deserialize<List<Student>>(jsonString);

				Console.Clear();
				Console.WriteLine("FILE LOADED");
			}
			catch (Exception)
			{

				Console.WriteLine("FILE NOT LOADED");
			}
		}

		static void Main(string[] args)
		{
			bool running = false;
			Load();

			while (!running)
			{
				var choice = Menu();

				switch (choice)
				{
					case "1": AddStudent(); break;
					case "2": ViewStudents(); break;
					case "3": ViewSpecificStudent(); break;
					case "4": RemoveStudent(); break;
					case "5": running = true; Console.WriteLine("Thanks for using my program"); break;
					default:
						Console.WriteLine("Bad input.");
						break;
				}
			}

		}

		// View students in list
		private static void ViewStudents()
		{
			Console.Clear();

			foreach (var student in students)
			{
				Console.WriteLine(student);
				Console.WriteLine("---------------------");
			}
		}

		// View a specific student in the list by specific ID
		private static void ViewSpecificStudent()
		{
			Console.WriteLine("Student ID: ");
			var input = Console.ReadLine();

			if (string.IsNullOrEmpty(input) || !int.TryParse(input, out int id))
			{
				Console.WriteLine("Invalid student ID.");
				return;
			}

			foreach (var student in students)
			{
				if (student.Id == id)
				{
					Console.Clear();
					Console.WriteLine("Student found!");
					Console.WriteLine(student);
					return;
				}
			}

			Console.Clear();
			Console.WriteLine("Student Not found!");
		}

		// Add student to list
		private static void AddStudent()
		{
			Console.WriteLine("Enter the student name: ");
			var name = Console.ReadLine();

			if (string.IsNullOrEmpty(name))
			{
				Console.WriteLine("Student name cannot be empty.");
				return;
			}

			Console.WriteLine("How many courses for this student?");
			var numCourseInput = Console.ReadLine();

			if (string.IsNullOrEmpty(numCourseInput) || !int.TryParse(numCourseInput, out int numCourse))
			{
				Console.WriteLine("Invalid number of courses.");
				return;
			}

			string[] course = new string[numCourse];
			double[] marks = new double[numCourse];

			for (int i = 0; i < numCourse; i++)
			{
				Console.WriteLine($"Enter the course name for course #{i + 1}: ");

				var courseName = Console.ReadLine();
				if (string.IsNullOrEmpty(courseName))
				{
					Console.WriteLine("Course name cannot be empty.");
					return;
				}

				course[i] = courseName;

				Console.WriteLine("Enter the mark for this course: ");

				var markInput = Console.ReadLine();

				if (string.IsNullOrEmpty(markInput) || !double.TryParse(markInput, out double mark))
				{
					Console.WriteLine("Invalid mark.");
					return;
				}
				marks[i] = mark;
			}

			students.Add(new Student(name, marks, course));
			Console.Clear();
			Console.WriteLine("Student Added");
			Save();
		}

		// Remove student from the list
		private static void RemoveStudent()
		{
			Console.WriteLine("Enter the student ID to remove: ");
			var input = Console.ReadLine();
			if (string.IsNullOrEmpty(input) || !int.TryParse(input, out int id))
			{
				Console.WriteLine("Invalid student ID.");
				return;
			}
			for (int i = 0; i < students.Count; i++)
			{
				if (students[i].Id == id)
				{
					students.RemoveAt(i);
					Save();
					Console.Clear();
					Console.WriteLine("Student removed.");
					return;
				}
			}
			Console.Clear();
			Console.WriteLine("Student not found.");
		}
	}
}
