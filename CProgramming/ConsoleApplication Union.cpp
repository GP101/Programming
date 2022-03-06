#include <iostream>

union Test {
    unsigned short a = 0x0030;
    char s[2];
};// union FLOAT

void main() {
    Test t;
    printf("%i\n", t.a);
    printf("%s\n", t.s);
    // output: 
    //  48
    //  0
}