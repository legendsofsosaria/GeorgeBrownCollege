/*
 * Elizabeth House
 * Student ID 101465946
 * Week 6, Lab 4
 * 02/11/2025
*/

namespace WeekSix
{
	internal class Student
	{
		// Private fields
		private int id;
		private int birthYear;
		private string major;
		private string firstName;
		private string lastName;

		// Getters and setters
		public string FirstName {  get => firstName; set => firstName = value; }
		public string LastName { get => lastName; set => lastName = value; }

		// Default constructor initializes student w/ default values
		public Student()
		{
			id = 0;
			birthYear = 0;
			major = string.Empty;
			firstName = string.Empty;
			lastName = string.Empty;
		}

		// Parameterized constuctor initalizes students w/ specific values
		public Student(int id, string firstName, string lastName, int birthYear, string major)
		{
			this.id = id;
			FirstName = firstName;
			LastName = lastName;
			this.birthYear = birthYear;
			this.major = major;
		}

		/* Calculates the student's age from birth year
		 (NOTE: This really isn't correct because we should have the M/D to adjust for birthday not passing) */
		public int getAge(int year)
		{

			return (DateTime.Today.Year - birthYear);
		}

		// Outputs the student information to console in a formatted string
		public void toString()
		{
			Console.WriteLine($"First Name:  {FirstName}, Last Name: {LastName}, Student ID: {id}, Major: {major}, Age:  {getAge(birthYear)}");
		}
	}
}
