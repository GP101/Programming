#include <iostream>

class KData
{
public:
	int _iData;
	float _fData;

	void AddIData(int i)
	{
		_iData += i;
	}
	void AddFData(float f)
	{
		_fData += f;
	}
	KData operator+(float f)
	{
		// pre: no side effect
		KData temp;
		temp._iData = _iData;
		temp._fData = _fData;
		temp._fData += f;
		return temp;
	}
};

int main()
{
	KData d;
	d._iData = 1;
	d._fData = 2.3f;
	d.AddIData(1);
	//d.operator+(1.0f); // explicit
	d = d + 1.0f; // implicit
	printf("%i,%g\r\n", d._iData, d._fData);
}