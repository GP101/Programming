#include <iostream>

class KObject {
public:
	virtual void Update() {
		printf("KObject Update\r\n");
	}
	void OnDraw() {
		printf("KObject OnDraw\r\n");
	}
	void OnDraw(int i) { //overloading
		printf("KObject OnDraw\r\n");
	}
};

class KCar : public KObject {
public:
	//virtual void Update() { // without 'override' old style
	//virtual void Update(int i) { // no error even though Update() has a different signature
	virtual void Update() override { // specify 'override', for overrided function
	//virtual void Update(int i) override { // it raises compile time error, if Update() has a different signature
		printf("KCar Update\r\n");
	}
};

int main()
{
	KObject* pCar = nullptr;
	pCar = new KCar();
	pCar->Update();
	delete pCar;
}
