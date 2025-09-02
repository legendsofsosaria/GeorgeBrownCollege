/* Elizabeth House
 * Student ID 101465946
 * Lab Test 2 - COMP 1202
 * 03/18/2025
 * Submit by 1 PM Atlantic time
 */

using System.Numerics;

namespace LabTest2
{
	internal class Product
	{
		// Private attributes
		private int productID;
		private string productName;
		private double price;
		private double[] ratings;
		public static int genId = 0;

		// Getters & setters
		public int ProductID { get => productID; }
		public string ProductName { get =>  productName; set => productName = value;}
		public double Price { get => price; set => price = value; }
		public double[] Ratings { get => ratings; set => ratings = value; }	

		// Default constructor with unnamed and default values of 0 
		public Product()
		{
			productID = 0;
			productName = "Unnamed";
			price = 0.0;
			ratings = Array.Empty<double>();
		}

		// Single parameter constructor, increments the gen ID to get product ID > 0
		public Product(double price)
		{
			productID = ++genId;
			productName = "Unnamed";
			this.price = price;
			ratings = Array.Empty<double>();
		}

		// Full parameter constructor 
		public Product(string productName, double price, double[] ratings)
		{
			productID = ++genId;
			this.productName = productName;
			this.price = price;
			this.ratings = ratings;
		}

		// Get the average rating of the product. To do: not working. I'm out of time so leaving as is
		public double GetAverageRating()
		{
			if (ratings.Length == 0) // Check for empty ratings array
			{
				return 0.0; // Or any appropriate default value
			}

			double sum = 0.0;
			for (int i = 0; i < ratings.Length; i++)
			{
				sum += ratings[i];
			}

			return sum / ratings.Length;
		}

		// Override to string to display product ID, name, and ratings [if applicable, otherwise say none]
		public override string ToString()
		{
			if (ratings.Length > 0)
			{
				string ratingsStr = string.Join(", ", ratings); // Join all ratings into a string
				return $"ProductID: {productID}, Product Name: {productName}, Product Price: {price}, Product Ratings: {ratingsStr}";
			}
			else
			{
				return $"ProductID: {productID}, Product Name: {productName}, Product Price: {price}, Product Ratings: None";
			}
		}
	}
}
