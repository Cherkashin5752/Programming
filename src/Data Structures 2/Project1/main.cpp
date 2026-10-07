#include <iostream>

void AddElement(int* arr, int& size, int index, int value)
{
	for (int i = size - 1; i > index; i--)
	{
		arr[i] = arr[i - 1];
	}

	arr[index] = value;

	size++;
}

int main()
{
	int size = 5;
	int capacity = 6;
	int* arr = new int[capacity] {1, 2, 3, 4, 5, 0};

	for (int i = 0; i < capacity; i++)
	{
		std::cout << arr[i] << '\t';
	}
	std::cout << std::endl;

	AddElement(arr, size, 2, 10);

	for (int i = 0; i < capacity; i++)
	{
		std::cout << arr[i] << '\t';
	}
	std::cout << std::endl;

	return 0;
}