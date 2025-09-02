/* Week 4, Exercise 1
* Elizabeth Gress
*/

#include <iostream>

int main()
{
	int hoursWorked, hourlyWage, weeklySalary, overtimeWages, overtimeHours;
	const int OVERTIME_MIN = 40;

	std::cout << "Enter the number of hours worked: \n";
	std::cin >> hoursWorked;
	std::cout << "Enter the hourly wage: \n";
	std::cin >> hourlyWage;

	double OVERTIME_PAY = 1.5 * hourlyWage;

	if (hoursWorked > OVERTIME_MIN)
	{
		overtimeHours = hoursWorked - OVERTIME_MIN;
		weeklySalary = OVERTIME_MIN * hourlyWage + overtimeHours * OVERTIME_PAY;
		std::cout << "Your weekly salary is: $" << weeklySalary << ".";
	}
	else
	{
		weeklySalary = hoursWorked * hourlyWage;
		std::cout << "Your weekly salary is: $" << weeklySalary << ".";
	}
	return 0;
}

