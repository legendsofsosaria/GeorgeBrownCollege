/*
* Week 5, Lab Exercise 4
* Elizabeth Gress
*/
#include <iostream>

int main()
{
	int w, p, amountTaken, amountRemaining, day = 1;

	std::cout << "Enter the amount (in liters) of water in the well on Day 1.\n";
	std::cin >> w;
	std::cout << "Enter the percentage of water in the well taken out each day.\n";
	std::cin >> p;

	while (day <= 30 && w >= 100)
	{
		amountTaken = (w * p) / 100;
		amountRemaining = w - amountTaken;
		std::cout << "Day " << day << ", Amount Taken: " <<  amountTaken << ", Amount Remaining: " << amountRemaining << "\n";
		w = amountRemaining;
		day++;
	}
	return 0;
}