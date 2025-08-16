#include <iostream>
#include <cstring>
using namespace std;

class Banking {
private:
    int id;
    char name[20];
    float amount;

public:
    Banking() {
        id = 0;
        strcpy(name, "Null");
        amount = 0;
    }

    Banking(int i, const char* n, float a) {
        id = i;
        strcpy(name, n);
        amount = a;
    }

    void output() {
        cout << id << "\t" << name << "\t" << amount << endl;
    }

    void withdraw(float w) {
        if (w > amount)
            cout << "Can't withdraw." << endl;
        else
            amount -= w;
    }

    void add(float a) {
        amount += a;
    }

    int getId() {
        return id;
    }

    float getAmount() {
        return amount;
    }
};

Banking* search(Banking a[], int n, int idd) {
    for (int i = 0; i < n; i++) {
        if (a[i].getId() == idd)
            return &a[i];
    }
    return NULL;
}

void outputAll(Banking a[], int n) {
    for (int i = 0; i < n; i++)
        a[i].output();
}

float totalAmount(Banking a[], int n) {
    float s = 0;
    for (int i = 0; i < n; i++)
        s += a[i].getAmount();
    return s;
}

Banking maxAmount(Banking a[], int n) {
    Banking max = a[0];
    for (int i = 1; i < n; i++) {
        if (max.getAmount() < a[i].getAmount())
            max = a[i];
    }
    return max;
}

int main() {
    const int n = 5;
    Banking a[n] = {
        Banking(1, "Navy", 13000),
        Banking(2, "Mary", 14000),
        Banking(3, "Vena", 21800),
        Banking(4, "Phea", 12600),
        Banking(5, "Noy", 11500)
    };

    float total, w;
    char ch;
    int idd;
    Banking max1;
    Banking* p;

    cout << "Id\tName\tAmount:" << endl;
    outputAll(a, 5);

    total = totalAmount(a, 5);
    cout << "Total income = " << total << endl;

    max1 = maxAmount(a, n);
    cout << "Max income of account holder is: " << endl;
    max1.output();

    cout << "Id to update: ";
    cin >> idd;

    p = search(a, 5, idd);
    if (p == NULL)
        cout << "Search not found." << endl;
    else {
        cout << "Add(a), withdraw(w): ";
        cin >> ch;
        if (ch == 'a') {
            cout << "How much to add: ";
            cin >> w;
            p->add(w);
        } else if (ch == 'w') {
            cout << "How much to withdraw: ";
            cin >> w;
            p->withdraw(w);
        }
        cout << "After update:" << endl;
        outputAll(a, 5);
    }

    return 0;
}
