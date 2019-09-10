#include <stdio.h>
#include <stdlib.h>

#define max(a,b)	((a)>(b)?(a):(b))
#define min(a,b)	((a)<(b)?(a):(b))

int Maximize(int a, int b, int c)
{
	return max(a, max(b, c));
}

int main()
{
	int a = 1;
	int b = 2;
	//b = b + a + 1;
	b += a + 1;
	b = 2;
	b += (a * 3);
	b = 2;
	b *= (a + 3);
	printf("%i\r\n", b);
	if (a > b)
		printf("%i", a);
	else
		printf("%i", b);
	printf("%i", a > b ? a : b);

	for (int i = 1; i <= 100; ++i)
	{
		if (i % 3 == 0 && i % 2 == 1)
			printf("%i, ", i);
	}
	int i = 3;
	int j = 2;

	printf("%i,%i,%i,%i\r\n", i / j, i * j, i - j, i + j);
	printf("%i,%i,%i,%i\r\n", i == j, i < j, i != j, i <= j);
	// 0, 0, 1, 0
	printf("%i,%i,%i,%i\r\n", i == j || i > j, i && j, !(i > j), !-1);
		// 1, 1, 0, 0
	printf("%i, %i\r\n", i << 1, i << 2);
		// i*(2^1), i*(2^2)
		// 6, 12
}
