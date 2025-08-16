#include <iostream>
#include <iomanip>
using namespace std;

class Send {
private:
    int code;
    char location;
    float weight;
    static float price1, price2, price3;

public:
    // Constructors
    Send() : code(0), location('A'), weight(0) {}
    Send(int c, char l, float w) : code(c), location(l), weight(w) {}

    // Output single record
    void output() const {
        cout << code << "\t" << location << "\t" << weight << "\t" << payment() << endl;
    }

    // Calculate payment
    float payment() const {
        if (location == 'A') return weight * price1;
        else if (location == 'B') return weight * price2;
        else return weight * price3;
    }

    // Friend functions
    friend float totalWeight(Send a[], int n);
    friend void sort(Send a[], int n);
    friend void outputAll(Send a[], int n);
};

// Static member initialization (outside class)
float Send::price1 = 1.7;
float Send::price2 = 0.8;
float Send::price3 = 2.5;

// Friend function: total weight
float totalWeight(Send a[], int n) {
    float total = 0;
    for (int i = 0; i < n; i++) {
        total += a[i].weight;
    }
    return total;
}

// Friend function: sort by weight (ascending)
void sort(Send a[], int n) {
    for (int i = 0; i < n - 1; i++) {
        for (int j = i + 1; j < n; j++) {
            if (a[i].weight > a[j].weight) {
                Send temp = a[i];
                a[i] = a[j];
                a[j] = temp;
            }
        }
    }
}

// Friend function: output all
void outputAll(Send a[], int n) {
    cout << "Code\tLoc\tWeight\tPayment\n";
    for (int i = 0; i < n; i++) {
        a[i].output();
    }
}

int main() {
    Send x[10] = {
        Send(1, 'B', 45), 
		Send(2, 'A', 34), 
		Send(3, 'C', 52),
		Send(4, 'B', 12),
        Send(5, 'C', 56), 
		Send(6, 'A', 45), 
		Send(7, 'C', 66), 
		Send(8, 'A', 50),
        Send(9, 'B', 44), 
		Send(10, 'A', 39)
    };

    cout << "Data of all:\n";
    outputAll(x, 10);

    float total = totalWeight(x, 10);
    cout << "Total Weight = " << total << endl;

    sort(x, 10);
    cout << "\nAfter sorting:\n";
    outputAll(x, 10);

    return 0;
}
