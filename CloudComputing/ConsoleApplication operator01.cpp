#include <iostream>

class KData
{
public: // section
	int _iData;
	float _fData;

	void Print()
	{
		std::cout << _iData << std::endl;
		std::cout << _fData << std::endl;
	}

	//void AddInt(int i)
	void operator+(int i)
	{
		_iData += i;
	}
	void AddFloat(int f)
	{
		_fData += f;
	}
};

void operator+(int i, KData& d)
{
	d._iData += i;
}

void main()
{
	KData d;
	d._iData = 2;
	d._fData = 3.1f;
	d.Print();
	//d.operator+(3); // explicit
	d + 3; // implicit
	3 + d; // 3.operator+(d);
	//operator+(3, d);
	d.Print();
}
