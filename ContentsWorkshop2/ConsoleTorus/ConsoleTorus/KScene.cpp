#include "KScene.h"
#include "KInput.h"

KScene::KScene()
{
    _stackStampOld = 0;
    _stackStampNew = 0;
}

KScene::~KScene()
{
}

void KScene::Initialize(KInitParam initParam)
{
    _param = initParam;
    for (int i = 0; i < initParam.numLanes; ++i) {
        _lanes.push_back( KLane() );
        _queues.push_back(KQueue());
    }
    _pos = KVector2(initParam.x, initParam.y);
    for (int i = 0; i < _lanes.size(); ++i) {
        KLane& l = _lanes[i];
        l.SetHeight(initParam.laneHeight);
        KQueue& q = _queues[i];
        q.SetSize(initParam.queueSize);
    }
    _stack.SetSize(initParam.stackSize);
    int numSkipLane = (_param.numLanes - 1) / 2;
    _stackPos.x = initParam.x + numSkipLane * 4;
    _stackPos.y = initParam.y + _lanes[0].GetHeight() + _queues[0].GetSize();
}

void KScene::Update()
{
    if (_KInput('a')) {
        _stackStampNew += 1;
        _stackPosOld = _stackPos;
        _stackPos.x -= 4;
    }
    else if (_KInput('d')) {
        _stackStampNew += 1;
        _stackPosOld = _stackPos;
        _stackPos.x += 4;
   }
}

void KScene::Draw()
{
    int     tx = _pos.x;
    int     ty = _pos.y;
    for (int i = 0; i < _lanes.size(); ++i) {
        KLane& l = _lanes[i];
        l.Draw(tx, ty);
        tx += 4;
    }
    tx = _pos.x;
    ty += _lanes[0].GetHeight();
    for (int i = 0; i < _queues.size(); ++i) {
        KQueue& q = _queues[i];
        q.DrawDeque(tx, ty);
        tx += 4;
    }
    // observer design pattern
    if (_stackStampOld != _stackStampNew) {
        DrawText(_stackPosOld.x
            , _stackPosOld.y
            , _stack.GetSize() + 1, "   ");
        _stackStampOld = _stackStampNew;
    }
    _stack.Draw(_stackPos.x, _stackPos.y);
}
