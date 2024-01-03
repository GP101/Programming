#include "KInput.h"

int KInput::m_keys[256] = { 0, };
double KInput::m_horizontal = 0.0;
double KInput::m_vertical = 0.0;
double KInput::m_normalizationTime = 0.5;

void KInput::Update(double elapsedTime_)
{
    double elapsedTime = elapsedTime_ * 1.0 / m_normalizationTime;
    for (int i = 0; i < 256; ++i) {
        m_keys[i] = GetAsyncKeyState(i);
    }
    if (m_keys[VK_LEFT]) {
        m_horizontal = min(m_horizontal, 0);
        m_horizontal -= elapsedTime;
        m_horizontal = max(m_horizontal, -1.0);
    }
    else if (m_keys[VK_RIGHT]) {
        m_horizontal = max(m_horizontal, 0);
        m_horizontal += elapsedTime;
        m_horizontal = min(m_horizontal, 1.0);
    }
    else
    {
        if (m_horizontal > 0.1)
            m_horizontal -= elapsedTime;
        else if (m_horizontal < -0.1)
            m_horizontal += elapsedTime;
        else
            m_horizontal = 0.0;
    }
    if (m_keys[VK_UP]) {
        m_vertical = max(m_vertical, 0);
        m_vertical += elapsedTime;
        m_vertical = min(m_vertical, 1.0);
    }
    else if (m_keys[VK_DOWN]) {
        m_vertical = min(m_vertical, 0);
        m_vertical -= elapsedTime;
        m_vertical = max(m_vertical, -1.0);
    }
    else
    {
        if (m_vertical > 0.1)
            m_vertical -= elapsedTime;
        else if (m_vertical < -0.1)
            m_vertical += elapsedTime;
        else
            m_vertical = 0.0;
    }
}
