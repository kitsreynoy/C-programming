#include <iostream>
using namespace std;

class Rectangle {
private:
    float l;
    float w;
public:
    void input() {
        cout << "Input length: "; cin >> l;
        cout << "Input width: "; cin >> w;
    }
    void output() {
        cout << "Length = " << l << "\nWidth = " << w << "\nArea = " << area() << endl;
    }
    float area() {
        return l * w;
    }
};

void 
