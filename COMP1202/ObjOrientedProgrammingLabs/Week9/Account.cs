using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9
{
	internal class Account
	{
		/* Attributes --> Private by default
		 * Encapsulation --> Protects scope, make the attr private and access
		 * through public functions (accessors and mutators aka getters and setters)
		 */
		private int accId; // ---> Primary Key
		private string? firstName;
		private string? lastName;
		private Address address;
		private string? branch;
		private double balance;
		public static int generatorId = 0;

		public int AccId { get => accId; set => accId = value; }
		public string FirstName { get => firstName; set => firstName = value; }
		public string LastName { get => lastName; set => lastName = value; }
		public Address Address { get => address; set => address = value; }
		public string Branch { get => branch; set => branch = value; }
		public double Balance { get => balance; set => balance = value; }

		// Default constructor
		public Account() 
		{
			AccId = ++generatorId;
		}

		public Account(string? firstName, string? lastName, Address address, string? branch, double balance) 
		{ 
			FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
			LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
			Address = address;
			Branch = branch ?? throw new ArgumentNullException(nameof(branch));
			Balance = balance;
			AccId = ++generatorId;
		}

		public Account(string? firstName, string? lastName, Address address, string? branch)
		{
			FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
			LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
			Address = address;
			Branch = branch ?? throw new ArgumentNullException(nameof(branch));
			Balance = 0.0;
			AccId = ++generatorId;
		}

		public override string? ToString()
		{
			return $"Account ID: {AccId}, First Name: {FirstName}, Last Name: {LastName}, " +
				$"Address: {Address}, Branch: {Branch}, Balance: {Balance:C}";
		}
	}
}
