#include <iostream>
using namespace std;

class Circle {
public:
    class Point {
    private:
        int x;
        int y;
    public:
        void input();
        void output();
    };

private:
    Point p;
    float r;

public:
    void input() {
        p.input();
        cout << "Input radius: ";
        cin >> r;
    }

    void output() {
        p.output();
        cout << "Radius = " << r << "\tArea = " << area() << endl;
    }

    float area() {
        return 3.14f * r * r;
    }
};

// Define Point methods outside the class
void Circle::Point::input() {
    cout << "Input x: ";
    cin >> x;
    cout << "Input y: ";
    cin >> y;
}

void Circle::Point::output() {
    cout << "(" << x << ", " << y << ")" << endl;
}

int main() {
    Circle::Point a;
    Circle c;

    cout << "Input data of point:" << endl;
    a.input();

    cout << "Data of point:" << endl;
    a.output();

    cout << "Input data of circle:" << endl;
    c.input();

    cout << "Data of circle:" << endl;
    c.output();

    return 0;
}

