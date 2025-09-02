/* Lab 3 Question 2
Elizabeth Gress
01/30/2023 */

#include <iostream>

int main()
{
	const int INSPECT_COST = 75;
	const int HOURLY_RATE = 75;
	const int MIN = 120;
	int hoursWorked;
	int costParts;
	int cost;
	int totalCost;

	std::cout << "Please enter the number of hours worked: \n";
	std::cin >> hoursWorked;
	std::cout << "Please enter the cost of parts: \n";
	std::cin >> costParts;

	if (hoursWorked == 0 && costParts == 0)
	{
		totalCost = INSPECT_COST;
		std::cout << "The total charge for the job is $" << totalCost << ".";
	}
	else
	{
		cost = (hoursWorked * HOURLY_RATE) + costParts;

		if (cost < MIN)
		{
			totalCost = MIN;
			std::cout << "The total charge for the job is $" << totalCost << ".";
		}
		else
		{
			totalCost = cost;
			std::cout << "The total charge for the job is $" << totalCost << ".";
		}

	}
	return 0;
}