#include "KQueue.h"

KQueue::KQueue()
{
}

KQueue::~KQueue()
{
}

void KQueue::SetPos( int x, int y )
{
    _pos.x = x;
    _pos.y = y;
}

bool KQueue::IsFull()
{
    return q0.size() >= dqmax;
}

void KQueue::DrawDeque()
{
    ::DrawDeque( q0, _pos.x, _pos.y, dqmax );
}

void KQueue::Update()
{
    // queue update routine here
}
