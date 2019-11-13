#include <iostream>
#include <stack>
#include <conio.h>
#include "TorusDefines.h"
#include "KStack.h"
#include <deque>
#include "KQueue.h"

int main()
{
    KStack  s0;
    KQueue  q0;

    int ch = 0;
    while (ch != 27) {
        ch = _getch();
        if (ch == 'a')
        {
            q0.PopFront();
        }
        if (ch == 's')
        {
            q0.PopBack();
        }
        if (ch == 'x')
        {
            q0.PushBack(TORUS_RED);
            q0.PushBack(TORUS_GREEN);
            q0.PushBack(TORUS_BLUE);
            q0.PushBack(TORUS_MAGENTA);
        }
        q0.DrawDeque(10, 6);
        //s0.Draw(10, 10);
    }
    return 0;
}