/*
 * Elizabeth House
 * Student ID 101465946
 * Week 11, Lab Test 2 Practice
 * 03/17/2025
*/

namespace LabTest2Practice
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Product[] inventory = new Product[5];
			int count = 0;

			while (true)
			{
				Console.WriteLine("----------------------------------------");
				Console.WriteLine("1. Add Product");
				Console.WriteLine("2. List Products");
				Console.WriteLine("3. Apply Tax To Products");
				Console.WriteLine("4. Exit");
				Console.WriteLine("----------------------------------------");
				Console.Write("Choose an option: ");
				string choice = Console.ReadLine();

				switch (choice)
				{
					case "1":
						if (count < inventory.Length)
						{
							Console.WriteLine($"Enter a product ID for product # {count + 1}:");
							int productID = int.Parse(Console.ReadLine());

							Console.WriteLine($"Enter a name for product # {count + 1}:");
							string productName = Console.ReadLine();

							Console.WriteLine($"Enter a price for product # {count + 1}:");
							double productPrice = double.Parse(Console.ReadLine());

							inventory[count] = new Product(productID, productName, productPrice);
							count++;
						}
						else
						{
							Console.WriteLine("Inventory is full!");
						}
						break;
					case "2":
						if (count > 0)
						{
							for (int i = 0; i < inventory.Length; i++)
							{
								Console.WriteLine(inventory[i]);
							}
						}
						else
						{
							Console.WriteLine("Inventory is empty!\n");
						}
						break;
					case "3":
						for (int i = 0; i < count; i++)
						{
							inventory[i].GetTax();
						}
						break;
					case "4":
						return;
					default:
						Console.WriteLine("Invalid option. Try again.");
						break;
				}
			}
		}
	}
}
