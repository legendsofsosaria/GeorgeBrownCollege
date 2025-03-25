namespace Assignment2
{
	internal class Program
	{
		public static string? Menu()
		{
			Console.WriteLine("1 ");
			Console.WriteLine("2 ");
			Console.WriteLine("3 ");
			Console.WriteLine("4 ");
			Console.WriteLine("5 ");
			Console.WriteLine("6 ");
			Console.WriteLine("7 ");
			Console.WriteLine("8 ");
			Console.WriteLine("9 ");
			Console.WriteLine("Enter number 1-9: ");
			return Console.ReadLine();
		}

		static void Main(string[] args)
		{
			while (true)
			{
				var choice = Menu();
				switch (choice)
				{
					case "1":
						
						break;
					case "2":
						
						break;
					case "3":
						
						break;
					case "4":
						
						break;
					case "5":
						
						break;
					case "6":
						break;
					case "7":
						break;
					case "8":
						break;
					case "9": return;
					default:
						Console.WriteLine("Invalid input.");
						break;
				}
			}
		}
	}
}
