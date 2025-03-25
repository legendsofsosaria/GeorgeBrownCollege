using System.Security.Principal;

namespace Assignment2
{
	internal class College
	{
		private const int STUDENTCOUNT = 5000;
		private const int COURSECOUNT = 50;
		public static int[,][,]? Registration;
		
		public static void AddStudent()
		{
			Student student = new Student();

			Console.WriteLine("Enter the student's name: ");
			string? name = Console.ReadLine();

			Student student1 = new Student(name);
		}

		public static void RemoveStudent()
		{

		}

		public static void AddCourse()
		{

		}

		public static void RemoveCourse()
		{

		}

		public static void RegisterStudent()
		{

		}

		public College()
		{

		}

		public College(int[,] student, int[,] course)
		{
		}
		
	}
}
