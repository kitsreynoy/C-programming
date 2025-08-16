#include <iostream>
using namespace std;

class B; // Forward declaration

class A {
private:
    int x;
public:
    void input() {
        cout << "Input x: ";
        cin >> x;
    }
    void output() {
        cout << "x = " << x << endl;
    }
    friend int sum(A a, B b); // Correct friend syntax
};

class B {
private:
    int y;
public:
    void input() {
        cout << "Input y: ";
        cin >> y;
    }
    void output() {
        cout << "y = " << y << endl;
    }
    friend int sum(A a, B b);
};

// Friend function definition
int sum(A a, B b) {
    return (a.x + b.y);
}

int main() {
    A a;
    B b;
    int s;

    cout << "Input data for a:\n";
    a.input();
    cout << "Input data for b:\n";
    b.input();

    cout << "Data a: ";
    a.output();
    cout << "Data b: ";
    b.output();

    s = sum(a, b);
    cout << "Sum = " << s << endl;

    return 0;
}

