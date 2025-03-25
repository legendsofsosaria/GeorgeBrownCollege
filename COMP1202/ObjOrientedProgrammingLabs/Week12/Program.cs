namespace Week12
{
	// Files Text --> Txt, CSV (Excel), JSON ...
	class Product
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public int Quantity { get; set; }
		public double Price { get; set; }

		public override string ToString()
		{
			return $"{Id}, {Name}, {Quantity}, {Price}"; // CSV
		}

		public static Product CollectUserInfo()
		{
			Product product = new Product();
			Console.WriteLine("Enter the product ID: ");
			product.Id = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the name of the product: ");
			product.Name = Console.ReadLine();
			Console.WriteLine("Enter the quantity of the product: ");
			product.Quantity = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the price of the product: ");
			product.Price = double.Parse(Console.ReadLine());

			return product;
		}
	}

	internal class Program
	{
		public static string? Menu()
		{
			Console.WriteLine("1 - Record Sales to a new file");
			Console.WriteLine("2 - Update Sales to an existing file");
			Console.WriteLine("3 - View the existing sales");
			Console.WriteLine("4 - Update existing sales in existing file");
			Console.WriteLine("5 - View Existing File Names");
			Console.WriteLine("6 - Exit");
			Console.WriteLine("Enter 1, 2, 3, 4, 5, or 6: ");
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
						RecordSalesNewFile();
						break;
					case "2":
						RecordSalesExistingFile();
						break;
					case "3":
						ViewExistingFile();
						break;
					case "4":
						UpdateExistingSales();
						break;
					case "5":
						ViewExistingFiles();
						break;
					case "6": return;
					default:
						Console.WriteLine("Invalid input.");
						break;
				}
			}
		}

		private static void ViewExistingFiles()
		{
			string[] fileNames = Directory.GetFiles("./");

			foreach (var file in fileNames)
			{
				var fileN = file.Split('/').Last();

				if (file.Contains(".txt") || file.Contains(".csv"))
				{
					Console.WriteLine(file);
				}
			}
		}

		private static void UpdateExistingSales()
		{
			/* Read the whole contents and store it in the memory
			Find the one that needs to be changed (using ID)
			change it
			rewrite the whole content from memory to file*/

			Console.WriteLine("Enter the file name (e.g January) :");
			var fileName = Console.ReadLine() + ".csv";

			if (!File.Exists(fileName))
			{
				Console.WriteLine($"The file {fileName} does not exist. Use menu #1 to create a new file.");
			}
			else
			{
				string[] output = File.ReadAllLines(fileName);
				Console.WriteLine("Enter the product ID: ");
				string? id = Console.ReadLine();
				bool found = false;

				for (int i = 0; i < output.Length && !found;  i++) 
				{
					if (output[i].Split(',').First() == id)
					{
						Console.WriteLine("Product Found");
						Console.WriteLine("Product will be replaced with entered information");
						output[i] = Product.CollectUserInfo().ToString();
						found = true;
						break;
					}
				}
				if (!found)
				{
					Console.WriteLine("The product ID was not found. No changes applied.");
				}
				else
				{
					File.WriteAllLines(fileName, output);
					Console.WriteLine("File changes complete");
				}
			}
		}

		private static void ViewExistingFile()
		{
			ViewExistingFiles();
			try
			{
				// Name of the file
				Console.WriteLine("Enter the file name (e.g January) :");
				var fileName = Console.ReadLine() + ".csv";

				if (File.Exists(fileName))
				{
					using (StreamReader sr = new StreamReader(fileName))
					{
						Console.WriteLine();
						string line = sr.ReadLine();

						while (line != null)
						{
							string[] option = line.Split(',');
							Console.WriteLine($"ID: {option[0]}, Name:{option[1]}, Quantity:{option[2]}, Price:{option[3]}");
							line = sr.ReadLine();
						}
						//Console.WriteLine(sr.ReadToEnd());
					}
				}
				else
				{
					Console.WriteLine($"The file {fileName} does not exist. Use menu #1 to create a new file.");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		
		}

		private static void RecordSalesExistingFile()
		{
			// Name of the file
			Console.WriteLine("Enter the file name (e.g January) :");
			var fileName = Console.ReadLine() + ".csv";

			if (!File.Exists(fileName))
			{
				Console.WriteLine($"The file {fileName} does not exist. Use menu #1 to create a new file.");
			}
			else
			{
				Console.WriteLine("How many sales would you like to record?");
				var count = int.Parse(Console.ReadLine());

				// using structure auto closes the file when it is done
				using (StreamWriter streamWriter = new StreamWriter(fileName, true)) // append the data at end of file
				{
					for (int i = 0; i < count; i++)
					{
						Console.WriteLine($"Enter sales # {i + 1} information");
						Product product = Product.CollectUserInfo();
						streamWriter.WriteLine(product.ToString());
					}

					//streamWriter.Close(); // Close stream writer, happens auto with using
				}
			}
		}

		private static void RecordSalesNewFile()
		{
			// Name of the file
			Console.WriteLine("Enter the file name (e.g January) :");
			var fileName = Console.ReadLine() + ".csv";

			if (File.Exists(fileName))
			{
				Console.WriteLine($"The file {fileName} already exists");
			}
			else
			{
				Console.WriteLine("How many sales would you like to record?");
				var count = int.Parse(Console.ReadLine());

				// using structure auto closes the file when it is done
				using (StreamWriter streamWriter = new StreamWriter(fileName))
				{
					for (int i = 0; i < count; i++)
					{
						Console.WriteLine($"Enter sales # {i + 1} information");
						Product product = Product.CollectUserInfo();
						streamWriter.WriteLine(product.ToString());
					}

					//streamWriter.Close(); // Close stream writer, happens auto with using
				}
			}
		}
	}
}
