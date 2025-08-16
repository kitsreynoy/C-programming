#include<iostream.h>
#include<conio.h>
 class Rectangle{
   int length, width;
  public:
    void input(){
     cout<< "Enter lenth and width :";
      cin >> length >> width;
      }
        void output(){
         cout << "length: "<<length << ", width:" << width << endl;
         }
           int area(){
             return length * width;
           }
        };
   int main(){
   Rectangle a[20]; /* create an array of 20 rectangle objects */

   int n;
   int i;
   int j;

    cout<<"Enter number of rectangles (max 20): ";
    cin>> n;

    //1. Input array of objects
    for (int i=0; i<n; i++){
        cout <<" Rectangle " << i+1 << " : ";
        a[i].input();
    }

    //2. Output array of objects
      for (int i=0; i<n; i++){
         cout << " Rectangle "<< i+1 << " : ";
         a[i].output();
    }

    //3.Find object with n=maximun area
    int max = 0;
    for  (int i = 1; i<n; i++){
        if(a[i].area() > a[max].area()){
          max = i;
      }
   }

   cout << "Rectangle with maximum area is: ";
   a[max].output();
   cout << "Area: " << a[max].area() << endl;

   //4. Find rectangles with area > 50
   cout << "Rectangles with area > 50:" <<endl;
   for(int i=0; i<n; i++){
       if(a[i].area() > 50){
         a[i].output();
         }
   }

   //5.Sort rectangles by area (ascending)
   for (int i=0; i<n-1; i++){
       for(int j=i+1; j<n; j++){
          if(a[i].area() > a[i].area()){
             swap(a[i], a[j]);
          }
       }
   }

   cout << "Recatangle after sorting by area:  "<<endl;
   for(int i=0; i<n; i++){
      a[i].output();
   }
   getch();
 }




















