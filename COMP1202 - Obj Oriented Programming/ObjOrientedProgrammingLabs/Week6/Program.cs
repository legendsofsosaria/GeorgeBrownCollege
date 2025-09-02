/*
 * Elizabeth House
 * Student ID 101465946
 * Week 6, Lab 4
 * 02/11/2025
*/

namespace WeekSix
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Instatiate 2 student objects
			Student firstStudent = new Student(3829, "Elizabeth", "House", 1989, "Programming and Analysis");
			Student secondStudent = new Student(3183, "Dave", "House", 1975, "Game Design");

			// Print the students information to the console
			firstStudent.toString();
			secondStudent.toString();
		}
	}
}
