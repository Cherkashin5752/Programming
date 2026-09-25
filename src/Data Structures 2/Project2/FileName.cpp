#include <iostream>

int Partition(int* array, int left, int right)
{
	int pivot = array[(left + right) / 2];

	int i = left;
	int j = right;

	while (i <= j)
	{
		while (array[i] < pivot && i <= right)
		{
			i++;
		}
		while (array[j] > pivot && j >= left)
		{
			j--;
		}

		if (i <= j)
		{
			std::swap(array[i], array[j]);
			i++;
			j--;
		}
	}
	return i;
}

void QuickSort(int* array, int left, int right)
{
	if (left < right)
	{
		int support = Partition(array, left, right);
		QuickSort(array, left, support - 1);
		QuickSort(array, support, right);
	}
}

int BinarySearch(int* _array, int _size, int value)
{
	int left = 0;
	int right = _size;

	QuickSort(_array, 0, _size-1);

	std::cout << std::endl;

	while (true)
	{
		int index = (left + right) / 2;
		if (_array[index] == value)
		{
			return index;
		}
		else
		{
			if (_array[index] > value)
			{
				right = index - 1;
			}
			else
			{
				left = index + 1;
			}
		}
	}
}

int main()
{
	int size = 3;
	int* a = new int[size] {7, 2, 5};

	QuickSort(a, 0, size-1);

	for (int i = 0; i < size; i++)
	{
		std::cout << a[i] << std::endl;
	}

	delete[] a;

	return 0;
}