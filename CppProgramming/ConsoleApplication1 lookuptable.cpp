#include <stdio.h>
#include <conio.h>
#include <string.h>
#include <stdlib.h>

class KeyName {
public:
	int _key;
	char _name[20];

	KeyName(int key_, const char* name_) {
		_key = key_;
		strcpy_s(_name, name_);
	}
};

int main()
{
	KeyName table[] = {// look-up table
		KeyName('1', "One"),
		KeyName('2', "Two"),
		KeyName('3', "Three"),
		KeyName('4', "Four"),
		KeyName('5', "Five"),
		KeyName('6', "Six"),
		KeyName('7', "Seven"),
		KeyName('8', "Eight"),
		KeyName('9', "Nine"),
		KeyName('h', "Hello"),
		KeyName('w', "World"),
	};

	bool bExitFlag = false;
	int ch = 0;
	while (ch != '0') {
		ch = _getch();
		for (int i = 0; i < _countof(table); ++i) {
			if (ch == table[i]._key) 
			{
				printf("%s\r\n", table[i]._name);
				bExitFlag = true; // flag variable
				break;
			}
		}
		if (bExitFlag == true)
			break;
	}
	return 0;
}