/*
Elizabeth Gress
Lab Exercise 8
*/

#include <iostream>
#include <cmath>

void partOne() // Sharing memory
{
	int x = 3, y = 4, z = 5;
	int* ptr = nullptr;

	std::cout << ptr << std::endl;
	ptr = &x;
	std::cout << *ptr << std::endl;
	ptr++; //increment
	ptr = &y;
	std::cout << *ptr << std::endl;
	ptr--; //decrement
	ptr = &z;
	std::cout << *ptr << std::endl;
	*ptr = pow(*ptr, 2); //squared
	std::cout << "x: " << x << " y: " << y << " z: " << z << std::endl;
}
void dynamicArray(int* array1, int size) //enter 10 numbers for the dynamic array
{
	std::cout << "Please enter 10 numbers: ";
	for (int i = 0; i < size; i++)
		std::cin >> *(array1 + i);
}
void printArray(int* array, int size) //print array
{
	for (int i = 0; i < size; i++)
		std::cout << *(array + i) << " ";
	std::cout << std::endl;
}
void printArrayReversed(int* array, int size) //print array in reverse
{
	for (int i = size - 1; i >= 0; i--)
		std::cout << *(array + i) << " ";
	std::cout << std::endl;
}
void staticArray(int* array2, int size) //enter 10 numbers for the static array
{
	std::cout << "Please enter 10 numbers: ";

	for (int i = 0; i < size; i++)
	{
		std::cin >> array2[i];
	}
}
int main()
{
	int size = 10;
	int* array1 = new int[size]; //creating the dynamic array
	partOne();
	dynamicArray(array1, size);
	printArray(array1, size);
	printArrayReversed(array1, size);
	int array2[10]; //creating the static array
	staticArray(array2, size);
	printArray(array2, size);
	printArrayReversed(array2, size);

	delete[] array1; //deleting the dynamically allocated memory
	return 0;
}
