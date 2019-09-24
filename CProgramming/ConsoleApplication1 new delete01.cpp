#include <stdio.h>
#include <string.h>

class KPeople
{
public:
	int age;
	char name[20]; // data member == member variable

	KPeople() { age = 0; name[0] = 0; printf("%s\r\n", __FUNCTION__); } // constructor
	~KPeople() { /**/ printf("%s\r\n", __FUNCTION__);} // destructor
	void SetName(const char* name) { // member function == method
		strcpy_s(this->name, name);
	}
	void SetAge(int age_) {
		this->age = age_;
	}
};

int main()
{
	KPeople* ps;
	ps = new KPeople;
	//ps = (KPeople*)operator new(sizeof(KPeople));
	//ps->KPeople::KPeople();

	ps->KPeople::SetAge(50);
	ps->SetName("John");
	printf("%i,%s\r\n", ps->age, ps->name);

	delete ps;
	//ps->~KPeople();
	//operator delete(ps);
}
