#include <iostream>

class KObject
{
public:
	virtual void Update() { std::cout << "KObject::Update" << std::endl; }
	virtual void OnDraw() {}
};

class KCar : public KObject
{
public:
	virtual void Update() { std::cout << "KCar::Update" << std::endl; }
	virtual void OnDraw() {}
};

int main()
{
	KObject* pCar = nullptr;
	pCar = new KCar();
	pCar->Update();
	delete pCar;
}
