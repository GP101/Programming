#include <iostream>

namespace mystd
{
	class myiostream
	{
	public:
		myiostream operator<<(int i)
		{
			printf("%i", i);
			return *this;
		}
		myiostream operator<<(const char* p)
		{
			printf("%s", p);
			return *this;
		}
	};

	myiostream cout;
}


int main()
{
	//std::cout << "Hello" << std::endl;
	mystd::cout.operator<<(3).operator<<("Hello\r\n").operator<<(9);
	(mystd::cout << 3) << "Hello\r\n";
	(mystd::cout << 3).operator<<("Hello\r\n");
	mystd::cout << 3 << "Hello\r\n" << 9; // implicit
}