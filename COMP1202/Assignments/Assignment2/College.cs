namespace Assignment2
{
	internal class College
	{
		public List<Student> Students { get; set; }
		public List<Course> Courses { get; set; }

		// Constructor initializes the lists for Students & Courses
		public College()
		{
			Students = new List<Student>();
			Courses = new List<Course>();
		}

		// Prompts user for info to create a new student
		public void AddStudent()
		{
			Console.WriteLine("Enter the student's first name: ");
			string? firstName = Console.ReadLine();

			Console.WriteLine("Enter the student's last name: ");
			string? lastName = Console.ReadLine();

			//Console.WriteLine("Enter the student's ID: "); ??? should we include?? I don't know. It says auto increment but then also says to ask for this. 
			//int id = int.Parse(Console.ReadLine());
			int id = 0;

			Console.WriteLine("Enter the student's email address: ");
			string? email = Console.ReadLine();

			// Create a new student and add it to the Students list
			Student student = new Student(id, firstName ?? "None", lastName ?? "None", email ?? "None");
			Students.Add(student);  // Add student to the existing Students list
		}

		public void DisplayStudents()
		{
			if (Students.Count == 0)
			{
				Console.WriteLine("No students to display.");
				return;
			}

			foreach (var student in Students)
			{
				Console.WriteLine(student.DisplayInfo());
			}
		}

		public void RemoveStudent()
		{
			// Implement logic for removing a student
		}

		// Prompts user for info to create a new course
		public void AddCourse()
		{
			Console.WriteLine("Enter the course name: ");
			string? name = Console.ReadLine();

			Console.WriteLine("Enter the course ID: ");
			int id = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter the course credit hours: ");
			int credits = int.Parse(Console.ReadLine());

			Course course = new Course(id, name, credits);
			Courses.Add(course);
		}

		public void RemoveCourse()
		{
			// Implement logic for removing a course
		}
	}
}