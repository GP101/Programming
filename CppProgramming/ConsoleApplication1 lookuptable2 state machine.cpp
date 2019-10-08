#include <stdio.h>
#include <conio.h>
#include <string.h>
#include <stdlib.h>

enum EnemyState
{
	ESTATE_IDLE = 0,
	ESTATE_WALK = 1,
	ESTATE_RUN = 2,
	ESTATE_ATTACK = 3,

	ESTATE_SIZE,
};

EnemyState state = ESTATE_IDLE;

void Enemy_Idle(int ch) {
	printf("Idle\r\n");
	if (ch == '1')
		state = ESTATE_WALK;
}

void Enemy_Walk(int ch) {
	printf("Walk\r\n");
	if (ch == '0')
		state = ESTATE_IDLE;
	else if( ch == '1')
		state = ESTATE_RUN;
}

void Enemy_Run(int ch) {
	printf("Run\r\n");
	if (ch == '0')
		state = ESTATE_IDLE;
	else if (ch == '1')
		state = ESTATE_ATTACK;
}

void Enemy_Attack(int ch) {
	printf("Attack\r\n");
	if (ch == '0')
		state = ESTATE_IDLE;
	else if (ch == '1')
		state = ESTATE_ATTACK;
}

typedef void(*STATE_FUNCTION)(int ch);
//void (*STATE_FUNCTION)(int ch);

void (*g_fp)(int ch);

STATE_FUNCTION g_fp;

int main()
{
	STATE_FUNCTION	table[] = {
		&Enemy_Idle,
		&Enemy_Walk,
		&Enemy_Run,
		&Enemy_Attack,
	};

	int ch = 0;
	while (ch != 'q')
	{
		ch = _getch();
		if (state >= ESTATE_IDLE && state < ESTATE_SIZE) {
			(*table[state])(ch);
		}
	}
	return 0;
}