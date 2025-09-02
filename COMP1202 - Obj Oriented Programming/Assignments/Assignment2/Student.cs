/*
Elizabeth House 101465946
Munir Howlader 101172332
Assignment 2
*/

using MessagePack;

namespace Assignment2
{
	/* Student class handles the student information.
	 * It contains properties for student ID, first name, last name, and email.
	 * The class also includes a constructor to initialize these properties and a method to display the student's information.
	 * The class has the [MessagePackObject] attribute to enable serialization and deserialization using MessagePack.
	 */
[MessagePackObject]
	public class Student
	{
		private int studentID;
		private string? firstName;
		private string? lastName;
		private string? email;

		[Key(0)]
		public int StudentID { get => studentID; set => studentID = value; }
		[Key(1)]
		public string? FirstName { get => firstName; set => firstName = value; }
		[Key(2)]
		public string? LastName { get => lastName; set => lastName = value; }
		[Key(3)]
		public string? Email { get => email; set => email = value; }

		public Student()
		{
			studentID = 0;
		}

		public Student(int id, string firstName, string lastName, string email)
		{
			studentID = id;
			this.firstName = firstName;
			this.lastName = lastName;
			this.email = email;
		}

		/* Used in the main program to display student information.
		 * Returns a string with the student ID, first name, last name, and email.
		 */
		public string? DisplayInfo()
		{
			return $"Student ID: {studentID}, First Name: {firstName}, Last Name: {LastName}, Email: {email}";
		}
	}
}
