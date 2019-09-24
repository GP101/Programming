#include <iostream>
using namespace std;

typedef unsigned int	byte;
template<typename T, int SIZE = 100>
class kStack
{
private:
	T _buffer[SIZE];
	T _sp = 0;
public:
	bool push(int d)
	{
		_buffer[_sp] = d;
		//_sp += 1; <== this case and the following line have the same effect
		++_sp;
		return true;
	}
	void pop() 
	{
		--_sp;
	}
	T top()
	{
		return _buffer[_sp - 1];
	}
	bool isEmpty()
	{
		if (_sp >= 1)
			return false;
		else
			return true;
	}
	T isempty()
	{
		return _sp == 0;
	}
};

int main() {
	int n = 14;
	kStack<int> s;

	int index = 0;
	int r = 0;
	int cnt = 0;

	while (n >= 1)
	{
		r = n % 2;
		n = n / 2;
		s.push(r);
	}

	while (!s.isEmpty())
	{
		std::cout << s.top();
		s.pop();
	}
}