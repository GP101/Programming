#include <stdio.h>
#include <stdlib.h>

int Sum(int a, int b)
{
	return a + b;
}
int Sum3(int a, int b, int b)
{
	return a + b + c;
}

int main()
{
	printf("%i\r\n", Sum(1, 2));
	1;
	1 + 2;
	int(*fp)(int a, int b);
	int* fp2(int a, int b);
	int fp3(int a, int b);
	fp = Sum;
	printf("%i\r\n", fp(3, 4)); // ( : function call operator
}
