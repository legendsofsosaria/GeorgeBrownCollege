/*
 * Elizabeth House
 * Student ID 101465946
 * Week 11, Lab Test 2 Practice
 * 03/17/2025
*/

namespace LabTest2Practice
{
	internal class Product
	{
		private int productID;
		private string name;
		private double price;

		public int ProductID { get => productID; set => productID = value; }
		public string Name { get => name; set => name = value; }
		public double Price { get => price; set => price = value; }

		public Product()
		{
			productID = 0;
			name = string.Empty;
			price = 0;
		}

		public Product(int productID, string name, double price)
		{
			this.productID = productID;
			this.name = name;
			this.price = price;
		}

		public void GetTax()
		{
			double tax = price * .15;
			double finalCost = price + tax;
			Console.WriteLine($"Cost with Tax: {finalCost:C}");
		}


		public override string ToString()
		{
			return $"ProductID: {productID}, Product Name: {name}, Product Price: {price:C}";
		}
	}
}
