#include <iostream>
#include <stdlib.h>

class KPeople
{
public:
	int* _pData;
	int _age;

	KPeople() {
		printf("KPeople constructor\r\n");
	}
	~KPeople() {
		printf("KPeople destructor\r\n");
	}
	void Print() {
		printf("KPeople %i\r\n", _age);
	}
	void* operator new (unsigned int size_)
	{
		_pData = (int*)malloc(size_);
		return this;
	}
};

int main()
{
	KPeople* p;
	//p = (KPeople*)operator new(sizeof(KPeople));
	//p->KPeople::KPeople();
	p = new KPeople;

	(*p)._age = 50;
	//(*p).Print();
	p->Print();

	//p->~KPeople();
	//operator delete(p);
	delete p;
}