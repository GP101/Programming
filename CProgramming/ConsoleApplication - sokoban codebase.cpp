#include <stdio.h>
#include <conio.h>
#include <Windows.h>

#define ESC                 27
#define FUNCTIONKEY_CHAR    0
#define ARROWKEY_CHAR       224
#define BOARD_ROW           9
#define BOARD_COL           8

enum KEYS
{
    KEY_HOME = 71,
    KEY_UP = 72,
    KEY_PGUP = 73,
    KEY_UNKNOWN01 = 74,
    KEY_LEFT = 75,
    KEY_CENTER = 76,
    KEY_RIGHT = 77,
    KEY_UNKNOWN02 = 78,
    KEY_END = 79,
    KEY_DOWN = 80,
    KEY_PGDN = 81
};

struct KPoint
{
    int x;
    int y;

    KPoint()
    {
        x = 0;
        y = 0;
    }
    KPoint(int x_, int y_)
    {
        x = x_;
        y = y_;
    }
    KPoint Add(const KPoint p)
    {
        KPoint t = *this;
        t.x += p.x;
        t.y += p.y;
        return t;
    }
};

enum ECell
{
    CELL_EMPTY = 0,
    CELL_WALL = 1,
    CELL_GOAL = 2,
    CELL_BOX = 3,
    CELL_PLAYER = 4,
};

struct KCell
{
    int fixed; // CELL_WALL or CELL_GOAL
    int movable; // CELL_BOX or CELL_PLAYER

    KCell(int f, int m) 
    {
        fixed = f;
        movable = m;
    }
};

void ShowConsoleCursor(bool showFlag)
{
    HANDLE out = GetStdHandle(STD_OUTPUT_HANDLE);

    CONSOLE_CURSOR_INFO     cursorInfo;

    GetConsoleCursorInfo(out, &cursorInfo);
    cursorInfo.bVisible = showFlag; // set the cursor visibility
    SetConsoleCursorInfo(out, &cursorInfo);
}

void gotoxy(int x, int y)
{
    COORD coord;
    coord.X = x;
    coord.Y = y;
    SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coord);
}


KPoint g_playerPos = {3,3};
KCell  g_board[BOARD_ROW][BOARD_COL]=
{
    KCell(0,0),KCell(0,0),KCell(1,0),KCell(1,0),KCell(1,0),KCell(1,0),KCell(1,0),KCell(0,0),
    KCell(1,0),KCell(1,0),KCell(1,0),KCell(0,0),KCell(0,0),KCell(0,0),KCell(1,0),KCell(0,0),
    KCell(1,0),KCell(2,0),KCell(0,4),KCell(0,3),KCell(0,0),KCell(0,0),KCell(1,0),KCell(0,0),
    KCell(1,0),KCell(1,0),KCell(1,0),KCell(0,0),KCell(0,3),KCell(2,0),KCell(1,0),KCell(0,0),
    KCell(1,0),KCell(2,0),KCell(1,0),KCell(1,0),KCell(0,3),KCell(0,0),KCell(1,0),KCell(0,0),
    KCell(1,0),KCell(0,0),KCell(1,0),KCell(0,0),KCell(2,0),KCell(0,0),KCell(1,0),KCell(1,0),
    KCell(1,0),KCell(0,3),KCell(0,0),KCell(2,3),KCell(0,3),KCell(0,3),KCell(2,0),KCell(1,0),
    KCell(1,0),KCell(0,0),KCell(0,0),KCell(0,0),KCell(2,0),KCell(0,0),KCell(0,0),KCell(1,0),
    KCell(1,0),KCell(1,0),KCell(1,0),KCell(1,0),KCell(1,0),KCell(1,0),KCell(1,0),KCell(1,0),
};

void DrawBoard(KCell board[BOARD_ROW][BOARD_COL])
{
    for (int row = 0; row < BOARD_ROW; ++row)
    {
        for (int col = 0; col < BOARD_COL; ++col)
        {
            if (board[row][col].fixed == CELL_WALL)
            {
                gotoxy(col, row);
                printf("O");
            }
            else if (board[row][col].fixed == CELL_GOAL)
            {
                gotoxy(col, row);
                printf("*");
            }
            else if (board[row][col].fixed == 0)
            {
                gotoxy(col, row);
                printf(" ");
            }

            if (board[row][col].movable == CELL_BOX)
            {
                gotoxy(col, row);
                printf("B");
            }
            else if (board[row][col].movable == CELL_PLAYER)
            {
                gotoxy(col, row);
                printf("M");
            }
        }
    }
}

int GetFixedValue(int x, int y)
{
    return g_board[y - 1][x - 1].fixed;
}

int GetFixedValue(KPoint p)
{
    return g_board[p.y - 1][p.x - 1].fixed;
}

int GetMovableValue(int x, int y)
{
    return g_board[y - 1][x - 1].movable;
}

int GetMovableValue(KPoint p)
{
    return g_board[p.y - 1][p.x - 1].movable;
}

void SetMovableValue(int x, int y, int m)
{
    g_board[y - 1][x - 1].movable = m;
}

void SetMovableValue(KPoint p, int m)
{
    g_board[p.y - 1][p.x - 1].movable = m;
}

int main()
{
    DrawBoard(g_board);

    ShowConsoleCursor(false);
    int ch = 0;
    while (ch != ESC)
    {
        ch = _getch();
        if (ch == ARROWKEY_CHAR || ch == FUNCTIONKEY_CHAR)
        {
            KPoint oldPos = g_playerPos;
            KPoint offsetVector = KPoint(0, 0);

            ch = _getch();
            if (ch == KEYS::KEY_LEFT)
            {
                offsetVector = KPoint(-1, 0);
            }
            else if (ch == KEYS::KEY_RIGHT)
            {
                offsetVector = KPoint(+1, 0);
            }
            else if (ch == KEYS::KEY_UP)
            {
                offsetVector = KPoint(0, -1);
            }
            else if (ch == KEYS::KEY_DOWN)
            {
                offsetVector = KPoint(0, +1);
            }
            //KPoint playersNewPos = KPoint(g_playerPos.x + offsetVector.x, g_playerPos.y + offsetVector.y);
            KPoint playersNewPos = g_playerPos.Add(offsetVector);
            if (GetFixedValue(playersNewPos) != CELL_WALL)
            {
                if (GetMovableValue(playersNewPos) == CELL_BOX)
                {
                    //KPoint newBoxPos = KPoint(playersNewPos.x + offsetVector.x, playersNewPos.y + offsetVector.y);
                    KPoint newBoxPos = playersNewPos.Add(offsetVector);
                    if (GetMovableValue(newBoxPos) == CELL_EMPTY &&
                        GetFixedValue(newBoxPos) != CELL_WALL)
                    {
                        SetMovableValue(playersNewPos, 0);
                        SetMovableValue(newBoxPos, CELL_BOX);

                        SetMovableValue(g_playerPos, 0);
                        g_playerPos = playersNewPos;
                        SetMovableValue(g_playerPos, CELL_PLAYER);
                    }
                }
                else if (GetMovableValue(playersNewPos) == CELL_EMPTY)
                {
                    SetMovableValue(g_playerPos, 0);
                    g_playerPos = playersNewPos;
                    SetMovableValue(g_playerPos, CELL_PLAYER);
                }
            }
        }
        gotoxy(0, 0);
        DrawBoard(g_board);
    }
    ShowConsoleCursor(true);
}
