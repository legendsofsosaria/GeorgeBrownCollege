using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9Lab
{
	internal class Person
	{
		private static int personCount = 0;
		private int personID;
		private string? name;
		private int age;

		public int PersonID { get { return personID; } set { personID = value; } }
		public string Name { get { return name; } set { name = value; } }
		public int Age { get { return age; } set { age = value; } }

		public Person() 
		{
			personID = personCount++;
		}

		public Person(string? name, int age)
		{
			personID = personCount++;
			Name = name ?? throw new ArgumentNullException(nameof(name));
			Age = age;
		}

		public override string ToString()
		{
			return $"ID: {PersonID}, Name: {Name}, Age: {Age}";
		}
	}
}
