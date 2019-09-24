#include <stdio.h>
#include <string.h>
#include <stdlib.h>

class KTest
{
public:
	int*	_pData;
	int		_size;

	KTest(int size_) {
		printf("constructor\r\n");
		_pData = new int[size_];
		_size = size_;
	}
	KTest(const KTest& rhs) {
		printf("copy constructor\r\n");
		_pData = new int[rhs._size];
		_size = rhs._size;
		memcpy(_pData, rhs._pData, sizeof(int)*_size);
	}
	KTest& operator=(const KTest& rhs) {
		release();
		_pData = new int[rhs._size];
		_size = rhs._size;
		memcpy(_pData, rhs._pData, sizeof(int)*_size);
		return *this;
	}
	~KTest() {
		printf("destructor\r\n");
		release();
	}
	void release() {
		if (_pData != nullptr)
		{
			delete _pData;
			_pData = nullptr;
			_size = 0;
		}
	}
	int& operator[](int index) {
		return _pData[index];
	}
	KTest& Foo(int i)
	{
		printf("%i", i);
		return *this;
	}
};

void Test(KTest t)
{
	printf("%i\r\n", t.operator[](1));
}

int main()
{
	KTest t(100); // constructor
	KTest t2(100); // constructor
	KTest t3(200); // constructor
	t.Foo(3).Foo(5).Foo(7);
	t3 = t2 = t; // t3.operator=(t);
	//t3.operator[](0) = 3; // explicit call
	t3[0] = 3; // implicit call
	//printf("%i\r\n", t3.operator[](0));
	printf("%i\r\n", t3[0]);
}
