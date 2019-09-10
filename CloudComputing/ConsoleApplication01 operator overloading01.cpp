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
	void operator+(float f)
	{
		_fData += f;
	}
};

int main()
{
	KData d;
	d._iData = 1;
	d._fData = 2.3f;
	d.AddIData(1);
	d.operator+(1.0f);
	printf("%i,%g\r\n", d._iData, d._fData);
}
