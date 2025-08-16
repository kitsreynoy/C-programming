#include<iostream>
#include<cstring>
using namespace std;
int main(){
	class Lecturer{
		private:
			int id;
			char name[20] ,sex;
			int hour;
			float rate;
		public:
			/*
			Lecturer(){
			id=123; strcpy(name,"abc");sex='M';hour=0;rate=0;
		}
			 */
			 Lecturer (int i=222, char* n="No", char s='M', int h=0, float r=0){
			 	id=i; strcpy(name,n);
			 	sex=s;hour=h;rate=r;
			 	
			 }
			 Lecturer (Lecturer &p){
			 	id=p.id;strcpy(name,p.name);
			 	sex=p.sex;hour=p.hour;rate=p.rate;
			 }
		void input(){
			cout<<"Id: ";cin>>id;
			cout<<"Name: ";cin.seekg(0,ios::end);cin.clear();
			cin.get(name,20);
			cout<<"Sex: ";cin>>sex;
			cout<<"Hour: ";cin>>hour;
			cout<<"Rate: ";cin>>rate;
		}
		void output(){
			cout<<id<<"\t"<<name<<"\t"<<sex<<"\t"<<income()<<endl;
		}
		float income(){return hour*rate;
		}
		int getId(){return id;
		}
		float getRate(){return rate;
		}
		void setRate(float r){rate=r;
		}
	};
	
	void inputAll(Lecturer a[], int n){
		for(int i=0; i<n; i++){
			cout<<"Data of lecture "<<(i+1)<<":"<<endl;
			a[i].input();
		}
	}
	
	void outputAll(Lecturer a[], int n){
		for(int i=0; i<n; i++){
			cout<<"Data of lecture "<<(i+1)<<":"<<endl;
			a[i].input();
			
		}
	}
	
	void outputAll(Lecturer a[], int n){
		for(int i=0; i<n; i++)
		a[i].output();
	}
	Lecturer *maxIncome(Lecturer a[], int n){
		Lecutrer *p;
		p=&a[0];
		for(int i=1; i<n; i++)
		 if(p->income()<a[i].income())p=&a[i];
		return p;
	}
	int maxIncome1(Lecturer a[], int n){
		int index=0;
		for(int i=1; i<n; i++)
		  if(a[index].income()>a[i].income())index=i;
		  return index;
	}
	Lecturer *search(Lecturer a[], int n, int idd){
		Lecturer *p;
		p=NULL;
		for(int i=0; i<n; i++)
		 if(a[i].getId()==idd){
		 	p=&a[i];
		 	break;
		 }
		 return p;
	}
	
	void mian(){
		Lecturer x[]={Lecturer (1,"Dara",'M',90,8),
		Lecturer(2,"Mary",'F',100,9),
		Lecturer(3,"Noy",'F',190,9),
		Lecturer(4,"Nita",'F',60,9),
		Lecturer(5,"Rann",'M',90,5)
	};
	//int pos;
	int id search; float r;
	Lecutrer *p1;
	//cout<<"input number of lecturers: "; cin>>n;
	//cout<<" input Data of all lecturers: "<<endl;
	//inputAll(x,n);
	cout<<"Id\tName\tSex\tIncome: "<<endl;
	outputAll(x,6);
	cout<<"input id to search: "; cin>>id_search;
	p1=search(x,6,id_search);
	if(p1==NULL)cout<<"Search not found:"<<endl;
	/*else{
	  cout<<"Rate to update:";cin>>r;
	  p1->setRate(r);
     }
	
	*/
	else p1->setRate(p1->getRate()+2);
	cout<<"After updating"<<endl;
	outputAll(x,6);
	
	/*pos=maxIncome1(x,6);
	cout<<"Max income is: "<<endl;
	*/
	
	return 0
}
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
		
	
}
