/* Week 6, Exercise 6
* Elizabeth Gress
*/

#include <iostream>

int compNumbers(double a, double b)
{
	if (a == b)
	{
		return 0;
	}
	else if (a > b)
	{
		return 1;
	}
	else
		return -1;
}
int main()
{
	double num1, num2;
	std::cout << "Enter the first number: \n";
	std::cin >> num1;
	std::cout << "Enter the second number: \n";
	std::cin >> num2;
	int result = compNumbers(num1, num2);
	if (result == 0)
		std::cout << "The numbers are the same.";
	else if (result == 1)
		std::cout << "The first number is larger.";
	else
		std::cout << "The second number is larger.";

	return 0;
}