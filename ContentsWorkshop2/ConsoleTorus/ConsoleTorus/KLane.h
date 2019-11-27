#pragma once
#include "TorusDefines.h"

class KLane
{
public:
    typedef void (*TorusEndCallback)(KLane* plane);
private:
    enum ETorusState
    {
        BEGIN,
        MOVING,
        END
    };
private:
    KVector2            _pos;
    int                 _height;
    KVector2            _torusPos;
    KVector2            _torusPosBegin;
    KVector2            _torusVel;
    TORUS               _torus;
    ETorusState         _torusState;
    TorusEndCallback    _torusCallback;

public:
    KLane();
    ~KLane();
    void SetPos( int x, int y );
    void SetTorusCallback(TorusEndCallback cb);
    void SetHeight(int h);
    int  GetHeight() { return _height; }
    void InitTorus(KVector2 v, TORUS t);
    void Draw();
    void Update();
};

