#include <iostream>
#include <stack>
#include <conio.h>
#include "TorusDefines.h"
#include "KStack.h"
#include <deque>
#include "KQueue.h"
#include "KInput.h"

bool g_isGameLoop = true;

int main()
{
    KQueue  q0;
    KStack  s0;

    while (g_isGameLoop) {
        _KInput.GetKeys();

        q0.DrawDeque(10, 10);
        if (_KInput(27)) {
            g_isGameLoop = false;
        }

        _KInput.GetKeys();
    }
    return 0;
}