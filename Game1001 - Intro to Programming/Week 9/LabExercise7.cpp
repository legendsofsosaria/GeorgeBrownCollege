/*
Elizabeth Gress
Lab Exercise 7, Week 9
*/

#include <iostream>

const int NUMS = 10;
double num[NUMS];

void computeNumbers()
{
	for (int i = 0; i < NUMS; ++i) //for 10 numbers in the array
	{
		std::cout << "Please enter a number: "; //ask user to input the number

		while (!(std::cin >> num[i])) //while there are less than 10 entries.....
		{
			std::cout << "Invalid number.  Try again.\n"; //user input something that is not a decimal or integer
			std::cout << "Please enter a number: "; 
			std::cin.clear(); // Clear the error.
			std::cin.ignore(80, '\n'); 
		}
	}

	double smallest = num[0];
	for (int tnum = 1; tnum < NUMS; tnum++) 
	{
		if (num[tnum] < smallest) //checking for the smallest number
			smallest = num[tnum];
	}
	std::cout << "Lowest number is " << smallest; 
}
int main()
{
	computeNumbers();
	return 0;
}