#include <iostream>
#include <stack>
#include <conio.h>
#include "TorusDefines.h"
#include "KStack.h"
#include <deque>
#include "KQueue.h"
#include "KInput.h"
#include "KTime.h"
#include <thread>
#include <chrono>
#include "KLane.h"

using namespace std::chrono;

bool g_isGameLoop = true;

void MyTorusCallback(KLane* plane)
{
    g_isGameLoop = false;
}

int main()
{
    KLane   lane;
    lane.SetTorusCallback(MyTorusCallback);
    lane.SetHeight(10);
    lane.InitTorus(1, 1, KVector2(0, 2), TORUS_BLUE);

    while (g_isGameLoop) {
        _KInput.Update();
        _KTime.Update();

        std::this_thread::sleep_for(100ms);

        lane.Update();
        lane.Draw(1, 1);

        if (_KInput(27)) {
            g_isGameLoop = false;
        }
    }
    return 0;
}
