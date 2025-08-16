#include <iostream>
using namespace std;

class Product {
private:
    int code;
    string name;
    float price;

public:
    // Default constructor
    Product() {
        code = 0;
        name = "Null";
        price = 0;
    }

    // Parameterized constructor
    Product(int c, string n, float p) {
        code = c;
        name = n;
        price = p;
    }

    void output() {
        cout << code << "\t" << name << "\t" << price << endl;
    }

    float getPrice() {
        return price;
    }
};

// Function to output all products
void output_all(Product a[], int n){
    for (int i = 0; i < n; i++) {
        a[i].output();
    }
}

// Function to calculate total price
float totalPrice(Product a[], int n) {
    float s = 0;
    for (int i = 0; i < n; i++) {
        s += a[i].getPrice();
    }
    return s;
}

// Function to find product with max price
Product maxprice(Product a[], int n) {
    Product max = a[0];
    for (int i = 1; i < n; i++) {
        if (a[i].getPrice() > max.getPrice()) {
            max = a[i];
        }
    }
    return max;
}

int main() {
    Product a[10] = {
        Product(1, "ASUS", 2000),
        Product(2, "MSI", 1500),
        Product(3, "DELL", 1069),
        Product(4, "MacBook", 5000),
        Product(5, "Samsung", 900),
        Product(6, "Lenovo", 300),
        Product(7, "ACER", 500),
        Product(8, "HP", 200),
        Product(9, "Panasonic", 250),
        Product(10, "Toshiba", 100),
    };

    Product max1;
    float total;

    cout << "---- OUTPUT ALL PRODUCTS ----" << endl;
    output_all(a, 10);

    cout << "------ TOTAL PRICE ------" << endl;
    total = totalPrice(a, 10);
    cout << "Total price = " << total << endl;

    cout << "----- MAX PRICE PRODUCT -----" << endl;
    max1 = maxprice(a, 10);
    max1.output();

    return 0;
}

