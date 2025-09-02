/*
Elizabeth House 101465946
Munir Howlader 101172332
Assignment 2
*/

using MessagePack;

namespace Assignment2
{
	/*
	 * The course class handles the course information.
	 * It has properties for course ID, course name, and credit hours.
	 * The class includes a constructor to initialize these properties and a method to display the course's information.
	 * The class has the [MessagePackObject] attribute to enable serialization and deserialization using MessagePack.
	 */
	[MessagePackObject]
	public class Course
	{
		private int courseID;
		private string? courseName;
		private int creditHours;

		[Key(0)]
		public int CourseID { get => courseID; set => courseID = value; }
		[Key(1)]
		public string? CourseName { get => courseName; set => courseName = value; }
		[Key(2)]
		public int CreditHours { get => creditHours; set => creditHours = value; }

		public Course()
		{
			courseID = 0;
		}

		public Course(int id, string? courseName, int creditHours)
		{
			courseID = id;
			this.courseName = courseName;
			this.creditHours = creditHours;
		}

		/* Used in the main program to display course information.
		 * Returns a string with the course ID, course name, and credit hours.
		 */
		public string? DisplayInfo()
		{
			return $"Course ID: {courseID}, Course Name: {courseName}, Course Credit Hours: {creditHours}";
		}
	}
}
