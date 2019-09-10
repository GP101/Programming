// ConsoleApplication.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <stdio.h>

void Swap(int* i, int* j) // call by value
{
    int t;
    t = *i;
    *i = *j;
    *j = t;
}

int main()
{
    int i;
    int j;
    i = 2;
    j = 3;
    Swap(&i, &j);
    printf("%i,%i\r\n", i, j);
}
