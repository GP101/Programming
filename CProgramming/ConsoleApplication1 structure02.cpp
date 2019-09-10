#include <stdio.h>
#include <stdlib.h>
#include <string.h>

class People
{
public:
	int age;
	char name[20];

	void SetName(const char* name_) {
		strcpy_s(this->name, name_);
	}
	void SetAge(int age_) {
		age = age_;
	}
};

int main()
{
	People* s;
	s = (People*)malloc(sizeof(People));
	//s.age = 50;
	s->SetAge(50);
	//strcpy_s(s.name, "John");
	s->SetName("John");
	printf("%i,%s\r\n", s->age, s->name);
	printf("%i,%i\r\n", sizeof(People), sizeof(s));
	free(s);
}
