/* Week 4, Exercise 2
* Elizabeth Gress
*/

#include <iostream>

int main()
{
	int initialCost, ticketCost, buyerAge;
	double seniorDiscount = .75, childDiscount = .50;

	std::cout << "Enter the initial ticket cost: \n";
	std::cin >> initialCost;
	std::cout << "Enter the buyer's age: \n";
	std::cin >> buyerAge;

	if (buyerAge >= 65 || buyerAge <= 12)
	{
		if (buyerAge >= 65)
		{
			ticketCost = initialCost * seniorDiscount;
			std::cout << "Your total ticket cost is $" << ticketCost << ".";
		}
		else
		{
			ticketCost = initialCost * childDiscount;
			std::cout << "Your total ticket cost is $" << ticketCost << ".";
		}
	}
	else
	{
		ticketCost = initialCost;
		std::cout << "Your total ticket cost is $" << ticketCost << ".";
	}

	return 0;
}