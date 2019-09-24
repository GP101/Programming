#include <stdio.h>
#include <string.h>
#include <stdlib.h>

class KTest
{
public:
	int _iData;
	float _fData;

	void Print()
	{
		printf("%i,%g\r\n", _iData, _fData);
	}
};

class KItem
{
public:
	char _cData;
	KItem() { _cData = 0;  }

	void PrintItem()
	{
		printf("Item\r\n");
	}
};

class KNewTest : public KTest
{
private:
	int		_dData[10];
	KItem	_item;

public:
	void Test()
	{
		printf("Hello\r\n");
		_item.PrintItem();
		_TestFunction();
	}
private:
	void _TestFunction() {
		printf("World\r\n");
	}
};

int main()
{
	KNewTest t;
	t.Test();
	//t._dData[0] = 1; // not possible
	t.Print();
	//t._TestFunction(); // not possible
	printf("%i\r\n", sizeof(KNewTest));
}
