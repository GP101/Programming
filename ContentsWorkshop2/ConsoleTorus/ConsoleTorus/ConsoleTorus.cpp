#include <iostream>
#include <stack>
#include <conio.h>
#include "TorusDefines.h"
#include "KStack.h"
#include <deque>
#include "KQueue.h"
#include "KInput.h"
#include "KTime.h"

bool g_isGameLoop = true;

int main()
{
    KQueue  q0;
    KStack  s0;

    while (g_isGameLoop) {
        _KInput.Update();
        _KTime.Update();

        Sleep( 100 );
        // render FSP(frame per second)
        {
            char buff[100];
            snprintf( buff, sizeof( buff ), "%g", _KTime.deltaTime );
            DrawText( 1, 1, buff );
        }

        q0.Update();
        q0.DrawDeque(10, 10);

        if (_KInput(27)) {
            g_isGameLoop = false;
        }
    }
    return 0;
}
