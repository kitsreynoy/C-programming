#include<iostream>
#include<cmath>
class Rectangle{
	private:
		int length;
		int breath;
	public:
		void input(){
		cout<<"Enter length: ";cin>>length;
		cout<<"Enter breath: ";cin>>breath;
		}
	    void output(){
	    	cout<<"Output width: "<<length<<endl;
	    	cout<<"Ouput height:"<<breath<<endl;
		}
	int area(){
		int s;
		s=length*breath;
		return 0;
	}
};
    int main(){
    	Rectangle re;
    	re.input();
    	re.output();
    	 cout<<"Area of the rectangle :"<<re.area()<<endl;
    	 return 0;
	}






