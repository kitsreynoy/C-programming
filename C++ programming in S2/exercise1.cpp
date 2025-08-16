#include<iostream.h>
#include<conio.h>
 class Rectangle{
  public:
     int length;
     int width;
    void input(){
      cout<<"Enter length: ";
      cin>> length;
      cout<<" Enter width: ";
      cin >> width;
    }
    void output(){
     cout<< "Length = " <<length << ", width= "<<width<<endl;
     }
      int area(){
        return length * width;
     }


   } ;
   void main(){
     Rectangle r;
     r.input();
     r.output();
     cout<<"Area = "<< r.area() << endl;
     getch();
     }