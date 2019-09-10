// ConsoleApplication.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <stdio.h>

void Swap(int a, int b)
{
    int t;
    t = a;
    a = b;
    b = t;
}

int main()
{
    int i;
    int j;
    i = 2;
    j = i;
    int* ip; // * symbol to declare pointer
    ip = &i;
    printf("%x, %x, %x, %i\r\n", &i, ip, &ip, *ip ); // contents-of
    2 * 3; // multiplication op.
}
