/* Lab 2 Question 2
Elizabeth Gress
01/22/2023 */
#include <iostream>
using namespace std;

int main()
{
	int bread, milk, cheese;
	double total, hst = .13, grandTotal;
	cout << "Please enter the total number of bread bought: ";
	cin >> bread;
	cout << "Please enter the total number of cartons of milk: ";
	cin >> milk;
	cout << "Please enter the total number of cheese: ";
	cin >> cheese;
	const double BREAD_COST = 1.99, MILK_COST = 3.99, CHEESE_COST = 9.99;
	total = bread * BREAD_COST + milk * MILK_COST + cheese * CHEESE_COST;
	double totalTax = total * hst;
	grandTotal = total + totalTax;
	cout << "\n\nThe total before tax is " << total;
	cout << "\n\nThe total amount of tax is " << totalTax;
	cout << "\n\n The grand total after tax is " << grandTotal;

	return 0;
}