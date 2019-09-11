#include <stdio.h>
#include <stdarg.h>

int g = 0;
extern int g2;

int Sum(int count_, ...)
{
    g2 += 1;
    register int s = 0;
    //int* ap = nullptr;
    va_list ap;
    //ap = &count_;
    va_start(ap, count_);
    for (int i = 0; i < count_; ++i)
    {
        int k;
        //k = *(ap + 1);
        //ap += 1;
        k = va_arg(ap, int);
        s += k;
    }
    va_end(ap);
    return s;
}

int main()
{
    1;
    'a';
    "Hello";
    1.2f;
    int i = Sum(3, 1, 2, 3);
    char c;
    long i2;
    long long i3;
    printf("%i, %i, %c\r\n", i, 2+3, 'a' );
}
