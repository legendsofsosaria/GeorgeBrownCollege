/* 
 * /*
Elizabeth House 101465946
Munir Howlader 101172332
Assignment 2
*/

using MessagePack;

namespace Assignment2
{
	 /* Used MessagePack serialization
	* Our registration dictionary wasn't supported by JSON serialization. Rather than troubleshoot how to make it work
	* I opted to try out a different serializer that is more flexible, and is supposed to be much faster than JSON serializer
	* source: https://msgpack.org/index.html#nuget-packages
	*/
	[MessagePackObject(AllowPrivate = true)]
	/* Since I'm serializing private members, it requires allow private to be set and make the class partial
	* Didn't want to make the indexes public members since they are being auto incremented */
	internal partial class College
	{
		// Create student list, course list, and registration dictionary. One for Students, one for courses, and a 2D dictionary to store registrations (Students and courses aggregated)
		[Key(0)]
		public List<Student> Students { get; set; }
		[Key(1)]
		public List<Course> Courses { get; set; }
		[Key(2)]
		public Dictionary<(int, int), string> Registrations { get; set; }

		// Store an index to increment for each new student and course added, to track what index to add the new student/course to
		[Key(3)]
		private int studentIndex = 0;
		[Key(4)]
		private int courseIndex = 100;

		// Constructor initializes the lists for Students & Courses and registration dictonary
		public College()
		{
			Students = new List<Student>();
			Courses = new List<Course>();
			Registrations = new Dictionary<(int, int), string>();
		}

		// Prompts user for info to create a new student, adds the student to the student list
		public void AddStudent()
		{
			string? firstName;
			string? lastName;
			string? email;

			// Validate user input
			while (true)
			{
				Console.WriteLine("Enter the student's first name: ");
				firstName = Console.ReadLine();

				if (!string.IsNullOrEmpty(firstName))
					break;

				Console.WriteLine("First name cannot be empty! Enter a valid name.");
			}
			// Validate user input
			while (true)
			{
				Console.WriteLine("Enter the student's last name: ");
				lastName = Console.ReadLine();

				if (!string.IsNullOrEmpty(lastName))
					break;

				Console.WriteLine("Last name cannot be empty! Enter a valid name.");
			}

			int id = studentIndex + 1; // auto increment index for studentID

			// Validate user input
			while (true)
			{
				Console.WriteLine("Enter the student's email address: ");
				email = Console.ReadLine();

				if (!string.IsNullOrEmpty(email))
					break;

				Console.WriteLine("Email cannot be empty! Enter a valid email.");
			}

			// Create a new student and add it to the Students array
			Students.Add(new Student(id, firstName, lastName, email)); // Add the student obj to the student list 
			studentIndex++; // Increase the student index

			Console.WriteLine("Student added successfully.");
			Save(); // Save the data to the file 
		}

		// Display all the students in the student list 
		public void DisplayStudents()
		{
			// Checks if there are students to display by checking the list count
			if (Students.Count == 0)
			{
				Console.WriteLine("No students to display.");
				return;
			}

			// For each student in the student list, display the students info
			foreach (var student in Students)
			{
				if (student != null)
					Console.WriteLine(student.DisplayInfo());
			}
		}

		// Prompts user for info to create a new course, adds the course to the course list
		public void AddCourse()
		{
			string? courseName;

			while (true)
			{
				Console.WriteLine("Enter the course name: ");
				courseName = Console.ReadLine();

				if (!string.IsNullOrEmpty(courseName))
					break;

				Console.WriteLine("Course name cannot be empty! Enter a valid course name:");
			}

			//Console.WriteLine("Enter the course ID: "); // I left this because it says in the assignment to auto increment, but also to ask for user data which is contradictory
			//int id = int.Parse(Console.ReadLine());
			int id = courseIndex + 1;

			Console.WriteLine("Enter the course credit hours: ");
			string? creditsInput = Console.ReadLine();

			// Check if the input is a valid number for course credits
			if (int.TryParse(creditsInput, out int credits))
			{
				Courses.Add(new Course(id, courseName, credits)); // Add the course obj to the course list
				courseIndex++; // Increase the course index
			}
			else
			{
				Console.WriteLine("Invalid input for course credit hours. Please enter a valid number.");
			}

			Save(); // Save the data
		}

		// Display all the courses in the course list
		public void DisplayCourses()
		{
			// Check if there are courses to display by checking the count in the list
			if (Courses.Count == 0)
			{
				Console.WriteLine("No courses to display.");
				return;
			}

			// For each course in the Course list, display the course info
			foreach (var course in Courses)
			{
				if (course != null)
					Console.WriteLine(course.DisplayInfo());
			}
		}

		// Register students to courses and store in the dictionary
		public void RegisterStudent()  //Defining the RegisterStudent Method
		{
			// Prompt for student ID
			Console.Write("Enter the student ID: ");
			string? studentIdInput = Console.ReadLine();
			if (!int.TryParse(studentIdInput, out int studentId)) //Attempts to parse the input into an integer and put it into sutdetnID.
			{
				Console.WriteLine("Invalid student ID input."); // if that attempt fails-  give out this error. 
				return;
			}

			// Verify that student exists
			var selectedStudent = Students.FirstOrDefault(s => s.StudentID == studentId); //Using FirstOrDefault to search for student id
			if (selectedStudent == null)
			{
				Console.WriteLine($"No student found with ID: {studentId}"); // If the said student ID was not found- show this message. 
				return;
			}

			// Filter courses where the student isn't already registered
			var availableCourses = Courses.Where
				(c => !Registrations.ContainsKey((studentId, c.CourseID))).ToList(); //Creates list of courses where student is not already registered

			if (availableCourses.Count == 0)//Checks to see the previous function couldn't find any courses to add here. 
			{
				Console.WriteLine("The student is already registered for all available courses.");
				return;
			}

			// Display only the courses the student is not registered in
			Console.WriteLine("Available Courses:");
			foreach (var course in availableCourses)
			{
				Console.WriteLine(course.DisplayInfo()); // Calls information about each courses that was found and added to availableCourses
			}

			// Prompt for course ID the student will like to register for. 
			Console.Write("Enter the course ID to register the student: ");
			string? courseIdInput = Console.ReadLine();
			if (!int.TryParse(courseIdInput, out int courseId)) //Attempts to parse the input into an integer and put it into courseId.
            {
				Console.WriteLine("Invalid course ID input."); // if that attempt fails-  give out this error. 
                return;
			}

			// Make sure course ID selected is from the list of available course. 
			var selectedCourse = availableCourses.FirstOrDefault(c => c.CourseID == courseId); //FirstOrDefault will return the first matching  course  or null
			if (selectedCourse == null) // if null is returned show the below message
			{
				Console.WriteLine("Invalid course selection.");
				return;
			}

			// Register the student for the course
			Registrations.Add((studentId, courseId), "Registered"); //This line addes the Key Value pair (studentId,courseId) and Registered to the Registration dictionary
			Console.WriteLine(
				$"Student {selectedStudent.FirstName} {selectedStudent.LastName} " +
				$"has been registered for course {selectedCourse.CourseName}.");

			Save(); // Save the data. Calling the Save method. 
		}

		// Display all registrations stored in the 2D array
		public void DisplayRegistrationStudent() // Display all courses that any student is registered in. 
		{
			Console.Write("Enter the student ID: ");
			string? studentIdInput = Console.ReadLine();
			if (!int.TryParse(studentIdInput, out int studentId)) //Attempts to parse the input into an integer and put it into studentId.
            {
				Console.WriteLine("Invalid student ID. Please try again."); // if that attempt fails-  give out this error.
                return;
			}

			// Check if the student is registered in any course
			var studentRegistrations = Registrations.Where(r => r.Key.Item1 == studentId).ToList();

			if (studentRegistrations.Count == 0)
			{
				Console.WriteLine("This student is not registered in any courses.");
			}
			else
			{
				Console.WriteLine("This student is registered in the following courses:");

				foreach (var registration in studentRegistrations)
				{
					var course = Courses.FirstOrDefault(c => c.CourseID == registration.Key.Item2);

					if (course != null)
					{
						Console.WriteLine($"Course ID: {course.CourseID}, Course Name: {course.CourseName}");
					}
				}
			}
		}

		public void DisplayRegistrationCourse()  //Display all students who are registered in any one course. 
		{
			Console.Write("Enter the course ID: ");
			string? courseIdInput = Console.ReadLine();

			if (!int.TryParse(courseIdInput, out int courseId)) //Attempts to parse the input into an integer and put it into courseId.
            {
				Console.WriteLine("Invalid course ID. Please try again.");// if that attempt fails-  give out this error.
                return;
			}

			// Show students registered for the course
			var registeredStudents = Registrations.Where(r => r.Key.Item2 == courseId).ToList();

			if (registeredStudents.Count == 0)
			{
				Console.WriteLine("No students are registered for this course.");
			}
			else
			{
				Console.WriteLine("The following students are registered for this course:");
				foreach (var registration in registeredStudents)
				{
					var student = Students.FirstOrDefault(s => s.StudentID == registration.Key.Item1);
					if (student != null)
					{
						Console.WriteLine(
							$"Student ID: {student.StudentID}, " +
							$"Name: {student.FirstName} {student.LastName}");
					}
				}
			}
		}

		public void DisplayNonRegistered() // Display all students that are not registered yet. 
		{
			var studentsNotRegistered = Students.Where
				(s => !Registrations.Any(r => r.Key.Item1 == s.StudentID)).ToList();

			if (studentsNotRegistered.Count == 0)
			{
				Console.WriteLine("All students are registered.");
			}
			else
			{
				Console.WriteLine("The following students are not registered for any course:");
				foreach (var student in studentsNotRegistered)
				{
					Console.WriteLine(
						$"Student ID: {student.StudentID}, " +
						$"Name: {student.FirstName} {student.LastName}");
				}
			}
		}


		// Remove student --> Student drops out of college
		public void RemoveStudent()
		{
			while (true)  //starts the loop to sucessfully remove a student or cancel the operation
			{
				Console.Write("Enter the student ID: ");
				string? studentIdInput = Console.ReadLine();
				if (!int.TryParse(studentIdInput, out int studentId)) //Attempts to parse the input into an integer and put it into studentId.
                {
					Console.WriteLine("Invalid student ID input. Please try again."); // if that attempt fails-  give out this error.
                    continue;
				}

				// Make sure student ID exists.
				var studentToRemove = Students.FirstOrDefault(s => s.StudentID == studentId); //FirstOrDefault will return the first matching  studentId  or null
                if (studentToRemove == null) // if null is returned show the below message
                {
					Console.WriteLine($"No student found with ID: {studentId}. Please try again.");
					continue;
				}

				// Check if the student is enrolled in any course by searching the Registrations dictionary
				if (Registrations.Any(r => r.Key.Item1 == studentId)) //Registration contains a key (studentId,courseId) and r.Key.Item1 represents studnetId
				{													//Any() checks if registration exists for given studentID
					Console.WriteLine("The student is currently enrolled in one or more courses and cannot be removed.");
					return;
				}

				// Ask for confirmation to remove the student.
				Console.Write("Are you sure you want to remove this student? (yes/no): ");
				string? confirmation = Console.ReadLine(); //Response is recorded in the confirmation variable. 
				if (confirmation?.Trim().ToLower() == "yes")//.Trim removes leading and trailing spaces and .ToLower converst to lower case
				{											// if the above result equals yes > proceed. 
					Students.Remove(studentToRemove);
					Console.WriteLine("Student removed successfully.");

					Save();
					return;
				}
				else
				{
					Console.WriteLine("Student removal cancelled. Let's try again.");

				}
			}
		}


		// Remove a course --> College removes a course
		public void RemoveCourse()
		{
			while (true)
			{
				Console.Write("Enter the course ID to remove: ");
				string? courseIdInput = Console.ReadLine();


				if (!int.TryParse(courseIdInput, out int courseId)) //Attempts to parse the input into an integer and put it into courseId.
                {	
					Console.WriteLine("Invalid course ID input. Please try again."); // if that attempt fails-  give out this error.
                    continue;
				}

				// Find the course to remove.
				var courseToRemove = Courses.FirstOrDefault(c => c.CourseID == courseId);//FirstOrDefault will return the first matching  course  or null

                if (courseToRemove == null) // if null is returned show the below message
                {
					Console.WriteLine($"No course found with ID: {courseId}. Please try again.");
					continue;
				}

				// Check if the course is registered by any student.
				if (Registrations.Any(r => r.Key.Item2 == courseId)) //Registration contains a key (studentId,courseId) and r.Key.Item2 represents courseID
                {                                                       //Any() checks if registration exists for given courseID
                    Console.WriteLine("Cannot remove this course because one or more students are registered in it.");
					return;
				}

				// Ask for confirmation
				Console.Write("Are you sure you want to remove this course? (yes/no): ");
				string? confirmation = Console.ReadLine(); //Response is recorded in the confirmation variable.

                if (confirmation?.Trim().ToLower() == "yes") //.Trim removes leading and trailing spaces and .ToLower converst to lower case
                {                                                   // if the above result equals yes > proceed.
                    Courses.Remove(courseToRemove);
					Console.WriteLine("Course removed successfully.");
					Save();;
					return;
				}
				else
				{
					Console.WriteLine("Course removal cancelled.");
					return;
				}
			}
		}

		// Remove a registration --> Student registers and then drops a course
		public void DeRegisterStudent()
		{
			while (true)  //initiate the while loop to continue until deregistration is done or cancelled
			{
				Console.Write("Enter the student ID to de-register: ");
				string? studentIdInput = Console.ReadLine();
				if (!int.TryParse(studentIdInput, out int studentId)) //Attempts to parse the input into an integer and put it into studentId.
                {
					Console.WriteLine("Invalid student ID input. Please try again.");// if that attempt fails-  give out this error. 
                    continue; 
				}

				// Check if the student is registered in any course
				var studentRegistrations = Registrations.Where(r => r.Key.Item1 == studentId).ToList(); 
				// Where() will filter the registrations and find all instance where studentId matches
				//Registration contains a key (studentId,courseId) and r.Key.Item1 represents studentId
				//.ToList > make list of items found
                if (studentRegistrations.Count == 0) //if no student found > show below message
				{
					Console.WriteLine("This student is not registered in any courses.");
					return;
				}

				// Display the list of courses the student is registered in
				Console.WriteLine("The student is currently registered in the following courses:");
				foreach (var registration in studentRegistrations) //foreach loop goes through each registrations in studentRegistration
				{																					// Courses.FirstOrDefault() to find the courseId
					var course = Courses.FirstOrDefault(c => c.CourseID == registration.Key.Item2); //retrives courseId from registration.key.item2 
					if (course != null)
					{
						Console.WriteLine($"Course ID: {course.CourseID}, Course Name: {course.CourseName}");
					}
				}

				// Ask the user to select a course to de-register from
				Console.Write("Enter the course ID to de-register the student from: ");
				string? courseIdInput = Console.ReadLine();

				if (!int.TryParse(courseIdInput, out int courseId)) //Attempts to parse the input into an integer and put it into courseId.
                {
					Console.WriteLine("Invalid course ID input. Please try again."); // if that attempt fails-  give out this error.
                    continue;
				}

				// Check if the student is registered for the selected course
				var registrationToRemove = studentRegistrations.FirstOrDefault(r => r.Key.Item2 == courseId);
				if (registrationToRemove.Equals(default(KeyValuePair<(int, int), string>)))
				{
					Console.WriteLine("The student is not registered in the selected course.");
					continue;
				}

				// Remove the registration
				Registrations.Remove(registrationToRemove.Key);
				Console.WriteLine("Student has been de-registered from the course.");

				Save(); // Save the data

				return; // Exit the method and return to the main menu
			}
		}

		// Save data to binary file using MessagePack serializer
		public void Save()
		{
			byte[] data = MessagePackSerializer.Serialize(this);
			File.WriteAllBytes("CollegeData.bin", data);
			Console.WriteLine("Data has been saved.");
		}

		// Load data from the binary file and place into the lists/dictionary
		public void Load()
		{
			string collegeFile = "CollegeData.bin";
			if (File.Exists(collegeFile))
			{
				try
				{
					byte[] data = File.ReadAllBytes(collegeFile);
					College? loadedCollege = MessagePackSerializer.Deserialize<College>(data);

					if (loadedCollege != null)
					{
						// Add the loaded data into the list/dictionary
						Students = loadedCollege.Students ?? new List<Student>();
						Courses = loadedCollege.Courses ?? new List<Course>();
						Registrations = loadedCollege.Registrations ?? new Dictionary<(int, int), string>();

						// If the student count > 0, then find the max ID to set the index to start from there (so you don't overwrite existing student IDs)
						studentIndex = Students.Count > 0 ? Students.Max(s => s.StudentID) : 0;
						// If the course count > 0, then find the max ID to set the index to start from there (so you don't overwrite existing course IDs)
						courseIndex = Courses.Count > 0 ? Courses.Max(c => c.CourseID) : 100;

						Console.WriteLine("FILE LOADED");
					}
				}
				catch (Exception ex) // Catch exceptions
				{
					Console.WriteLine($"Error loading file: {ex.Message}");
				}
			}
			else
			{
				Console.WriteLine("FILE NOT FOUND"); // File doesn't exist, so file will be created 
			}
		}
	}
}