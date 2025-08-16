#include<iostream>
#include<cmath>
using namespace std;

 struct Point{
  int x;
  int y;
 };
 void input(Point & p){
   cout<<"input x:";cin>>p.x;
   cout<<"input y";cin>>p.y;
 }
 void output(Point p){
  cout<<"("<<p.x<<" , "<<p.y<<")"<<endl;
 }
 float distance (Point a, Point b){
 }
  int main (){
    Point a,b;
    float d;
    cout<<" Enter value f a:"<<endl;
    input(a);
    cout<<"Enter value of b:"<<endl;
    input(b);
    cout<<"Value of point b";
    output(b);
     d=sqrt(pow((a.x-b.x),2) + pow((a.y-b.y),2));
    cout<<" The value of Distance="<<d;
    return 0;
    }
