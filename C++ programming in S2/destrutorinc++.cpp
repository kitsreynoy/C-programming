#include <iostream>
using namespace std;

class Lecturer {
private:
    int id;
    string name;
    char sex;
    int hour;
    float rate;

public:
    // Default constructor
    Lecturer() {
        id = 333;
        name = "abc";
        sex = 'M';
        hour = 0;
        rate = 0;
    }

    // Parameterized constructor
    Lecturer(int i, string n, char s, int h, float r) {
        id = i;
        name = n;
        sex = s;
        hour = h;
        rate = r;
    }

    // Copy constructor
    Lecturer(const Lecturer& p) {
        id = p.id;
        name = p.name;
        sex = p.sex;
        hour = p.hour;
        rate = p.rate;
    }

    // Input method
    void input() {
        cout << "Id: ";
        cin >> id;
        cin.ignore(); // clear newline
        cout << "Name: ";
        getline(cin, name);
        cout << "Sex: ";
        cin >> sex;
        cout << "Hour: ";
        cin >> hour;
        cout << "Rate: ";
        cin >> rate;
    }

    // Output method
    void output() {
        cout << id << "\t" << name << "\t" << sex << "\tIncome: " << income() << endl;
    }

    // Income calculation
    float income() {
        return hour * rate;
    }

    // Destructor
    ~Lecturer() {
        cout << "Name: " << name << " was deleted." << endl;
    }
};

// Helper functions
void inputAll(Lecturer* arr, int n) {
    for (int i = 0; i < n; i++) {
        cout << "\nEnter info for lecturer " << i + 1 << ":\n";
        arr[i].input();
    }
}

void outputAll(Lecturer* arr, int n) {
    cout << "\nLecturer info:\n";
    for (int i = 0; i < n; i++) {
        arr[i].output();
    }
}

int main() {
    Lecturer* p = new Lecturer(333, "Mary", 'F', 110, 10);
    Lecturer* a = new Lecturer[3];

    inputAll(a, 3);

    p->output();
    outputAll(a, 3);

    delete p;
    delete[] a;

    return 0;
}

