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

int main() {
    Rectangle p1, p2, p3, max;

    cout << "Input p1:" << endl; p1.input();
    cout << "Input p2:" << endl; p2.input();
    cout << "Input p3:" << endl; p3.input();

    cout << "\nOutput p1:" << endl; p1.output();
    cout << "Output p2:" << endl; p2.output();
    cout << "Output p3:" << endl; p3.output();

    max = p1;
    if (max.area() < p2.area()) max = p2;
    if (max.area() < p3.area()) max = p3;

    cout << "\nRectangle with max area is:" << endl;
    max.output();

    return 0;
}

