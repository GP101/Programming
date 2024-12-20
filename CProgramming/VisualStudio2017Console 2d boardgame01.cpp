#include <stdio.h>
#include <conio.h>
#include <windows.h>

const int g_numRows = 10;
const int g_numCols = 10;
int g_iplayerx = 1;
int g_iplayery = 1;

void ShowConsoleCursor(bool showFlag)
{
	HANDLE out = GetStdHandle(STD_OUTPUT_HANDLE);
	CONSOLE_CURSOR_INFO     cursorInfo;
	GetConsoleCursorInfo(out, &cursorInfo);
	cursorInfo.bVisible = showFlag; // set the cursor visibility
	SetConsoleCursorInfo(out, &cursorInfo);
}

void GotoXy(int x, int y)
{
	COORD p = { x, y };
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), p);
}//GotoXy()

void DrawBoard(int board[g_numRows][g_numCols])
{
	for (int r = 0; r < g_numRows; ++r) {
		for (int c = 0; c < g_numCols; ++c) {
			GotoXy(c, r);
			if (board[r][c] == 0)
				printf(".");
			else if (board[r][c] == 1)
				printf("#");
			else if (board[r][c] == 2)
				printf("N");
			else if (board[r][c] == 3)
				printf("P");
		}
	}
}

void DrawPlayer(int x, int y)
{
	GotoXy(x, y);
	printf("P");
}

void main()
{
	ShowConsoleCursor(false);

	int board[g_numRows][g_numCols] = {
		{1,0,1,1,1,1,1,1,1,1},
		{1,0,0,0,0,0,0,0,0,1},
		{1,0,0,0,0,0,0,0,0,1},
		{1,0,0,0,0,0,0,0,0,1},
		{1,0,0,0,0,0,0,0,0,1},
		{1,0,0,1,1,1,1,0,0,1},
		{1,0,0,0,0,0,0,0,0,1},
		{1,0,0,0,0,0,0,0,0,1},
		{1,0,0,0,0,0,0,0,0,1},
		{1,1,1,1,1,1,1,1,1,1},
	};

	DrawBoard(board);
	DrawPlayer(g_iplayerx, g_iplayery);
	GotoXy(1, 11);
}
