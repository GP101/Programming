#include "KQueue.h"

KQueue::KQueue()
{
}

KQueue::~KQueue()
{
}

void KQueue::DrawDeque(int x, int y)
{
    ::DrawDeque(q0, x, y, dqmax);
}