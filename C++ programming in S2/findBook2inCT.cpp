#include <iostream>
#include <cstring>
using namespace std;

class Book {
private:
    int code;
    char title[20];
    float price;

public:
    Book() {
        code = 0;
        strcpy(title, "");
        price = 0.0;
    }

    Book(int c,  char* n, float p) {
        code = c;
        strncpy(title, n, 19);
        title[19] = '\0';
        price = p;
    }

    void input() {
        cout << "Code: ";
        cin >> code;
        cin.ignore(); // To consume newline before getline
        cout << "Title: ";
        cin.getline(title, 20);
        cout << "Price: ";
        cin >> price;
    }

    void output()  {
        cout << code << "\t" << title << "\t" << price << endl;
    }

    int getCode()  {
        return code;
    }

    void setPrice(float p) {
        price = p;
    }
};

// Function to input all books
void inputAll(Book a[], int n) {
    for (int i = 0; i < n; i++) {
        cout << "Enter the book " << i + 1 << ":\n";
        a[i].input();
    }
}

// Function to output all books
void outputAll(Book a[], int n) {
    //cout << "\nList name of books:\n";
    cout << "List name of books:" <<endl;
    for (int i = 0; i < n; i++) {
        a[i].output();
    }
}

// Function to search book by code
Book* search(Book a[], int n, int codeToFind) {
	Book *p = NULL;
    for (int i = 0; i < n; i++) {
        if (a[i].getCode() == codeToFind) {
            return &a[i];
        }
    }
    return p;
}

// Main function
int main() {
    int n;
    cout << "Number of books: ";
    cin >> n;

    Book* x = new Book[n];

    cout << "\nInput data for all books:\n";
    inputAll(x, n);

    cout << "\nAll book data:\n";
    outputAll(x, n);

    int codeToSearch;
    float newPrice;
    cout << "\nEnter code to search: ";
    cin >> codeToSearch;

    Book* p = search(x, n, codeToSearch);
    if (p == NULL) {
        cout << "No book found with that code.\n";
    } else {
        cout << "Enter new price: ";
        cin >> newPrice;
        p->setPrice(newPrice);
    }

    cout << "\nAfter updating price:\n";
    outputAll(x, n);

    delete[] x; // Clean up
    return 0;
}

