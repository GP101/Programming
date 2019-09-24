#include <stdio.h>
#include <string.h>
#include <stdlib.h>

class KPeople
{
public:
	int age;
	char name[20]; // data member == member variable
	char* pbuffer;

	KPeople() { // default constructor
		age = 0; name[0] = 0; printf("%s\r\n", __FUNCTION__);
		pbuffer = (char*)malloc(100);
	}
	KPeople( const KPeople& rhs ) { // copy constructor
		age = rhs.age;
		//pbuffer = rhs.pbuffer;
		pbuffer = (char*)malloc(100);
		memcpy(pbuffer, rhs.pbuffer, 100);
		printf("copy %s\r\n", __FUNCTION__);
	}
	~KPeople() // destructor
	{ 
		/**/ printf("%s\r\n", __FUNCTION__);
		free(pbuffer);
	}

	void SetName(const char* name) { // member function == method
		strcpy_s(this->name, name);
	}
	void SetAge(int age_) {
		this->age = age_;
	}
};

void Test(KPeople& p)
{
	p.age += 1;
	p.name;
}

int main()
{
	//KPeople* ps;
	//ps = new KPeople;
	KPeople p;

	p.SetAge(50);
	p.SetName("John");
	Test(p);
	printf("%i,%s\r\n", p.age, p.name);

	//delete ps;
}
