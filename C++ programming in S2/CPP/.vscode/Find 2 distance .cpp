#include <iostream>
#include<cmath>
class Point{
    pravite:
     int x;
     int y;
    public:
      void input(){
        cout<<"input x:";cin>>x;
        cout<<"input y:";cin>>y;
      }
      void output(){
        cout<<"("<<x<<","<<y<<")"<<endl;
      }
      floatdistance(Point a){
        float d;
        d=sqrt(pow((x-a.x),2)+pow(pow(y-a.y),2);)
        return 0;
      }
};
void main(){
    Point a,b;
    float d1;
    cout<<"Point a:"<<endl; a.input();
    cout<<"Output point a:"; a.output();
    cout<<"Point b:"<<endl; b.input();
    cout<<"Output point b:"; b.output();
    d1=a.distance(b);
    cout<<"Distance= "<<d1<<endl;
    return 0;  
}