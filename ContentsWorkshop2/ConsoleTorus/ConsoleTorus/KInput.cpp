#include "KInput.h"
#include <conio.h>

KInput::KInput()
{
}

KInput::~KInput()
{
}

void KInput::GetKeys()
{
    if (_kbhit()) {
        int ch = _getch();
        m_keys[ch] = 1;
    }
}