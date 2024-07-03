#include <iostream>
#include <cmath>

using namespace std;

void solveQuadratic(double a, double b, double c) {
    // T�nh delta
    double delta = b * b - 4 * a * c;

    // Ki?m tra di?u ki?n d? x�c d?nh s? lu?ng v� lo?i nghi?m
    if (delta > 0) {
        // Phuong tr�nh c� hai nghi?m ph�n bi?t
        double x1 = (-b + sqrt(delta)) / (2 * a);
        double x2 = (-b - sqrt(delta)) / (2 * a);
        cout << "Phuong trinh co hai nghiem phan biet:\n";
        cout << "x1 = " << x1 << "\n";
        cout << "x2 = " << x2 << "\n";
    } else if (delta == 0) {
        // Phuong tr�nh c� m?t nghi?m k�p
        double x = -b / (2 * a);
        cout << "Phuong trinh co nghiem kep:\n";
        cout << "x = " << x << "\n";
    } else {
        // Phuong tr�nh kh�ng c� nghi?m th?c
        cout << "Phuong trinh vo nghiem.\n";
    }
}

int main() {
    double a, b, c;
    cout << "Nhap vao he so a, b, c cua phuong trinh ax^2 + bx + c = 0:\n";
    cout << "a = ";
    cin >> a;
    cout << "b = "; cin >> b;
    
    cout << "c = "; cin >> c;
    

    // G?i h�m d? gi?i phuong tr�nh b?c hai
    solveQuadratic(a, b, c);

    return 0;
}

