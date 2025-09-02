namespace Week9
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Address address = new Address(1, "Yonge str", "Toronto", "ON", "L6A 2C9", "Canada");
			Console.WriteLine(address);

			Account account = new Account();
			account.Balance = 1000;
			Account acc1 = new Account("Tony", "Chopper", address, "TD", 1000);
			Account acc2 = new Account("Elizabeth", "House", address, "TD", 2000);
			Account acc3 = new Account("Luffy", "Monkey", 
				new Address(1, "Pirate Lane", "East Blue", "NS", "B0N 2T0", "Canada"), 
				"RBC", 4000);

			Account[] accList = { acc1, acc2, acc3 };

			Console.WriteLine("-----------------------------------------------------------------");
			foreach (Account acc in accList)
			{
				Console.WriteLine(acc);
			}
			Console.WriteLine("-----------------------------------------------------------------");

			Console.WriteLine(acc1 + "\n");
			Console.WriteLine(acc1.FirstName);
			Console.WriteLine(acc1.FirstName); // This is intentional :P
			Console.WriteLine(acc1.LastName);
			Console.WriteLine(acc1.Address);
			Console.WriteLine(acc1.Branch);
		}
	}
}
