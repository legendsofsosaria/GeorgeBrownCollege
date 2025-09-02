namespace Week13
{
	internal class Student
	{
		static int idGenerator = 0;

		// Properties
		public int Id { get; set; }
		public string? Name { get; set; }
		public double[]? Marks { get; set; }
		public string[]? Courses { get; set; }

		public Student()
		{
			Id = ++idGenerator;
		}

		public Student(string name, double[] marks, string[] courses)
		{
			if (marks.Length == courses.Length)
			{
				Id = ++idGenerator;
				Name = name;
				Marks = marks;
				Courses = courses;
			}
			else throw new Exception("The courses do not match the marks.");
		}

		public double GetAverageCourse()
		{
			if (Marks == null || Marks.Length == 0)
				return 0;

			return Marks.Average();
		}

		public override string? ToString()
		{
			var marksString = Marks != null ? string.Join(", ", Marks) : "No Marks";
			var coursesString = Courses != null ? string.Join(", ", Courses) : "No Courses";
			string output = $"Student ID: {Id}, \nName: {Name ?? "No Name"}, \nMarks: {marksString}, \nCourses: {coursesString}";
			output += $"\nAverage = {GetAverageCourse():F2}\n";

			return output;
		}
	}
}
