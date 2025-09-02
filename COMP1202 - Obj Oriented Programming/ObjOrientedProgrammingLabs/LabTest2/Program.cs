/* Elizabeth House
 * Student ID 101465946
 * Lab Test 2 - COMP 1202
 * 03/18/2025
 * Submit by 1 PM Atlantic time
 */

namespace LabTest2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create an array of products 
			Product[] inventory = new Product[7];
			double totalRatings = 0.0;
			int ratedProducts = 0;

			inventory[0] = new Product(); // default with empty values
			inventory[1] = new Product("Pizza", 7.99, new double[] {9.8}); // all args
			inventory[2] = new Product(3.99); // 1 arg
			inventory[3] = new Product(.89); // 1 arg
			inventory[4] = new Product("Sugar", 3.99, new double[] { 7.0 }); // all args
			inventory[5] = new Product("Vanilla", 6.49, new double[] { 7.6 }); // all args
			inventory[6] = new Product(6.99); // 1 arg

			for (int i = 0; i < inventory.Length; i++)
			{
				double productAvgRating = inventory[i].GetAverageRating();
				if (productAvgRating > 0) 
				{
					totalRatings += productAvgRating;
					ratedProducts++;
				}
			}

			double avgRating = (ratedProducts > 0) ? totalRatings / ratedProducts : 0.0; // Calculate overall average
			Console.WriteLine($"Average Rating: {avgRating:N}");

			// Output inventory to console for length of inventory
			for (int i = 0; i < inventory.Length; i++)
			{
				Console.WriteLine(inventory[i]);
			}
		}
	}
}
