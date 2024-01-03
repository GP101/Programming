#include "MyUtil.h"
#include <cwchar>
#define _USE_MATH_DEFINES
#include <cmath>
#include "KMatrix2.h"
#include <complex>
#include <Windows.h>
#include <WinUser.h>
#include <strsafe.h>
#include "KInput.h"
#include <vector>

double g_drawScale = 1.0;

void DrawLine(double x, double y, double x2, double y2, char ch)
{
    KVector2 center{ g_width / 2.0, g_height / 2.0 };
    ScanLine(int(x * g_drawScale + center.x), int(-y * g_drawScale + center.y)
        , int(x2 * g_drawScale + center.x), int(-y2 * g_drawScale + center.y), ch);
}

void DrawLine(KVector2 v0, KVector2 v1, char ch)
{
    KVector2 center{ g_width / 2.0, g_height / 2.0 };
    ScanLine(int(v0.x * g_drawScale + center.x), int(-v0.y * g_drawScale + center.y)
        , int(v1.x * g_drawScale + center.x), int(-v1.y * g_drawScale + center.y), ch);
}

void Update(double elapsedTime)
{
    g_drawScale = 1.0;
    DrawLine(-g_width / 2, 0, g_width / 2, 0, '.');
    DrawLine(0, -g_height / 2, 0, g_height / 2, '.');

    PutTextf(0, 0, "%g", elapsedTime);
    //
    // game object update logic here
    //
}

void DrawGameWorld() {
    //
    // game object drawing routine here
    //
    DrawBuffer();
}

int main(void)
{
    g_hwndConsole = GetConsoleWindow();
    g_hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
    ShowCursor(false);

    bool isGameLoop = true;
    clock_t prevClock = clock();
    clock_t currClock = prevClock;
    int i = 1;

    while (isGameLoop == true)
    {
        if (Input.GetKeyDown(VK_ESCAPE)) {
            isGameLoop = false;
        }
        prevClock = currClock;
        currClock = clock();
        const double elapsedTime = ((double)currClock - (double)prevClock) / CLOCKS_PER_SEC;
        ClearBuffer();
        Input.Update(elapsedTime);
        Update(elapsedTime);
        Sleep(10);
        DrawGameWorld();
    }
}
