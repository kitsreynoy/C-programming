#include <iostream>
#include <cmath> // for sqrt
using namespace std;

class Point {
private:
    int x;
    int y;
public:
    Point() : x(0), y(0) {}
    Point(int x1, int y1) : x(x1), y(y1) {}

    void input() {
        cout << "Input x: "; cin >> x;
        cout << "Input y: "; cin >> y;
    }
    void output() {
        cout << "(" << x << "," << y << ")" << endl;
    }
    float distance(Point p) {
        return sqrt((x - p.x) * (x - p.x) + (y - p.y) * (y - p.y));
    }
};

class Triangle {
private:
    Point a, b, c;
    float s1, s2, s3;

    void value() {
        s1 = a.distance(b);
        s2 = a.distance(c);
        s3 = b.distance(c);
    }
public:
    Triangle() { value(); }
    Triangle(Point a1, Point b1, Point c1) {
        a = a1;
        b = b1;
        c = c1;
        value();
    }

    void input() {
        cout << "Vertex A: "; a.input();
        cout << "Vertex B: "; b.input();
        cout << "Vertex C: "; c.input();
        value();
    }

    void output() {
        a.output();
        b.output();
        c.output();
        cout << "Area = " << area() << endl;
    }

    float area() {
        float p = (s1 + s2 + s3) / 2;
        return sqrt(p * (p - s1) * (p - s2) * (p - s3));
    }
};

int main() {
    Point p1(23, 71), p2(93, 13), p3(62, 89);
    Triangle t(p1, p2, p3), t1;

    cout << "Input data of t1:" << endl;
    t1.input();
    cout << "\nTriangle t1:" << endl;
    t1.output();

    cout << "\nTriangle t:" << endl;
    t.output();

    return 0;
}

