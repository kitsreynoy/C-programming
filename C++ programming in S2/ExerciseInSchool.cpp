#include<iostream>
 using namespace std;
 int main(){
 	class Lecturer{
 		private:
		 int id;
		string name; 
		 char sex;
		 int hour;
		 float rate;
		public:
		 Lecturer();
		 Lecturer(int i, string name , char s, int h, float r);
		 Lecturer(Lecturer &p);
		 void input();
		 void output();
		 float income();
		Lecturer(int i, string n, char s, int h, float r){
 	 	 id=i; sex=s; hour=h; rate=r; name=n;
	  }
		Lecturer(Lecturer &p){
	 	id=p.id; sex=p.sex; hour=p.hour;
	 	rate=p.rate; strcpy(name,p.name);
	 }
 }
		   
	 }
//	 Lecturer::Lecturer(){
//	 	id=333; sex='M'; hour=0; rate=0;strcpy(name, "abc");
//	 }
 	 
 
  void lecturer::input(){
  	  cout<<"Id: ";cin>>id;
  	  cout<<"Name: ";cin.seekg(0, ios::end );cin.clear();
  	  cin.get(name,20);
  	  cout<<"Sex: ";cin>>sex;
  	  cout<<"Hour: ";cin>>hour;
  	  cout<<"Rate: ";cin>>rate;
  }
  
  void Lecturer::output(){
  	    cout<<id<<"\t"<<name<<"\t"<<sex<<"\t"<<income()<<endl;
  }
  
  float Lecturer::income(){return hour*rate;}
   
   void inputAll(Lecturer a[], int n){
   
        for (int i =0; i<n; i++){
        	cout<<"Data of lecturer "<<(i+1)<<":"<<endl;
        	a[i].input();
		}
		
}
    void output(lecturer a[], int n){
    	for(int i=0; i<n; i++)
    	a[i].output();
	}
	int main(){
		lecturer b1,b2(333, "Tep Bopha",'F',100,100,0),b3(b2);
		cout<<"Data of b1:"<<endl; b1.output();
		cout<<"Data of b2:"<<endl; b2.output();
		cout<<"Gata of b3:"<<endl; b3.output();
	
		} 
		
	return 0; 	  
  	  
  	  
  	  
  	  
  	  
  	  
  	  
  	  
  	  
  	  
  	  
  
