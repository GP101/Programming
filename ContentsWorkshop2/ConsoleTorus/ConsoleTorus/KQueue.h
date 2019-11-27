#pragma once
#include <deque>
#include "TorusDefines.h"

class KQueue
{
private:
    std::deque<TORUS> q0;
    int dqmax = 5;
    KVector2    _pos;

public:
    KQueue();
    ~KQueue();

    void SetPos( int x, int y );
    void SetSize(int size) {
        dqmax = size;
    }
    int GetSize() { return dqmax; }

    void PopFront() {
        q0.pop_front();
    }
    void PopBack() {
        q0.pop_back();
    }
    void PushFront(const TORUS& v) {
        q0.push_front(v);
    }
    void PushBack(const TORUS& v) {
        q0.push_back(v);
    }
    void DrawDeque();
    void Update();
};
