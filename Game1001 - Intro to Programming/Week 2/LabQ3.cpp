/* Lab 2 Question 3
Elizabeth Gress
01/23/2023 */
#include <iostream>
using namespace std;

int main()
{
	double hoursWorked, hourlyRate, totalPay;
	cout << "Please enter the total number of hours worked: ";
	cin >> hoursWorked;
	cout << "Please enter the hourly rate: ";
	cin >> hourlyRate;
	totalPay = hoursWorked * hourlyRate;
	cout << "\n\nThe total pay is $" << totalPay;

	return 0;
}