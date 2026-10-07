#include <iostream>

#include "DynamicArray.h"

void DynamicArray::CheckCapacity()
{
	if (_capacity <= _size)
	{
		ExpendCapacity();
	}
	else
	{
		if (_size != 0)
		{
			if ((_capacity / _size) > _growthFactor)
			{
				ShrinkCapasity();
			}
		}
	}
}

void DynamicArray::MakeNewArray(int newCapacity)
{
	int* newArray = new int[newCapacity];

	for (int i = 0; i < _size; i++)
	{
		newArray[i] = _array[i];
	}

	delete[] _array;
	_array = newArray;
	_capacity = newCapacity;
}

void DynamicArray::ExpendCapacity()
{
	int newCapacity = _capacity * _growthFactor;
	// +TODO: Дубль
	MakeNewArray(newCapacity);
}

void DynamicArray::ShrinkCapasity()
{
	int newCapacity = _capacity / _growthFactor;
	// +TODO: Дубль
	MakeNewArray(newCapacity);
}

DynamicArray::~DynamicArray()
{
	delete[] _array;
}

int DynamicArray::GetSize()
{
	return _size;
}

int DynamicArray::GetCapacity()
{
	return _capacity;
}

int* DynamicArray::GetArray()
{
	return _array;
}

void DynamicArray::AppendElement(int element)
{
// +TODO: Лишняя реализация
	CheckCapacity();

	AddElementAt(_size, element);
}

void DynamicArray::PrependElement(int element)
{
// +TODO: Лишняя реализация
	CheckCapacity();

	AddElementAt(0, element);
}

int DynamicArray::AddElementAt(int index, int value)
{
	if (index < 0 || index > _size) return -1;

	CheckCapacity();

	for (int i = _size; i > index; i--)
	{
		_array[i] = _array[i - 1];
	}

	_array[index] = value;

	_size++;

	return 0;
}

int DynamicArray::RemoveByIndex(int index)
{
	if (index < 0 || index >= _size) return -1;

	for (int i = index; i < _size; i++)
	{
		_array[i] = _array[i + 1];
	}

	_size--;

	_array[_size] = 0;

	CheckCapacity();
	
	return 0;
}

void DynamicArray::RemoveByValue(int value)
{
	int index = -1;

	for (int i = 0; i < _size; i++)
	{
		if (_array[i] == value)
		{
			index = i;
			break;
		}
	}

	RemoveByIndex(index);

	CheckCapacity();
}

int DynamicArray::GetElement(int index)
{
	return _array[index];
}

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
		int pivot = Partition(array, left, right);
		QuickSort(array, left, pivot - 1);
		QuickSort(array, pivot, right);
	}
}

// +TODO: Сортировка по варианту
void DynamicArray::SortArray()
{
	int left = 0;
	int right = _size - 1;
	bool isSwapped = true;

	while (isSwapped)
	{
		isSwapped = false;
		for (int i = left; i < right; i++)
		{
			if (_array[i] > _array[i + 1])
			{
				std::swap(_array[i], _array[i + 1]);
				isSwapped = true;
			}
		}

		right--;

		if (!isSwapped) break;

		isSwapped = false;

		for (int i = right; i > left; i--)
		{
			if (_array[i] < _array[i - 1])
			{
				std::swap(_array[i], _array[i - 1]);
				isSwapped = true;
			}
		}
		left++;
	}
}

int DynamicArray::LinearSearch(int value)
{
	for (int i = 0; i < _size; i++)
	{
		if (_array[i] == value)
		{
			return i;
		}
	}

	return -1;
}

int DynamicArray::BinarySearch(int value)
{
	int left = 0;
	int right = _size;

	SortArray();

	// +TODO: Полльзовательский ввод должен быть вне СД.

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

		if (right == left)	return -1;
	}
}