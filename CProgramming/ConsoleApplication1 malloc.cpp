#include <stdio.h>
#include <stdlib.h>

void MyAlloc(int* jp, unsigned int size_) {
	jp = (int*)malloc(size_);
}

int main()
{
	//int* jp = (int*)malloc(sizeof(int) * 10);
	int* jp = nullptr;
	MyAlloc(jp, sizeof(int) * 10);

	int d = 1;
	for (int i = 0; i < 10; ++i)
	{
		jp[i] = d;
		d += 2;
	}
	printf("%i,%i\r\n", jp[0], jp[9]);
	free(jp);
	return 0;
}
