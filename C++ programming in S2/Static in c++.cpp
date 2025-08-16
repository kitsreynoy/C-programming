#include <iostream>
#include <cstring> // for strcpy, strcmpi
using namespace std;

class Lecturer {
private:
    int id;
    char name[20], sex;
    int hour;
    static float rate;

public:
    Lecturer() {
        id = 123;
        strcpy(name, "abc");
        sex = 'M';
        hour = 0;
    }

    Lecturer(int i, char* n, char s, int h) {
        id = i;
        strcpy(name, n);
        sex = s;
        hour = h;
    }

    void input() {
        cout << "ID: ";
        cin >> id;
        cin.ignore(); // clear leftover newline
        cout << "Name: ";
        cin.getline(name, 20);
        cout << "Sex: ";
        cin >> sex;
        cout << "Hour: ";
        cin >> hour;
    }

    void output() {
        cout << id << "\t" << name << "\t" << sex << "\t" << income() << endl;
    }

    float income() {
        return hour * rate;
    }

    static void sort(Lecturer a[], int n) {
        Lecturer temp;
        for (int i = 0; i < n - 1; i++) {
            for (int j = i + 1; j < n; j++) {
                if (strcmpi(a[i].name, a[j].name) > 0) {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }
    }
};

float Lecturer::rate = 10.0;

void inputAll(Lecturer a[], int n) {
    for (int i = 0; i < n; i++) {
        cout << "\nData of Lecturer " << (i + 1) << ":\n";
        a[i].input();
    }
}

void outputAll(Lecturer a[], int n) {
    for (int i = 0; i < n; i++) {
        a[i].output();
    }
}

int main() {
    Lecturer* p2;
    int n;

    cout << "Number of elements: ";
    cin >> n;

    p2 = new Lecturer[n];

    cout << "\nInput data for all Lecturers:\n";
    inputAll(p2, n);

    cout << "\nAll Lecturers:\n";
    outputAll(p2, n);

    Lecturer::sort(p2, n);

    cout << "\nAfter sorting:\n";
    outputAll(p2, n);

    delete[] p2; // cleanup

    return 0;
}

