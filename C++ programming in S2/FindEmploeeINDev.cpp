#include<iostream>
 using namespace std;
  class Employee{
  	 private:
  	 	int id;
  	 	string name;
  	 	char sex;
  	 	float salary;
  	public:
  		void input(){
  			cout<<"Enter your id : "; cin>>id;
  			cout<<"Enter your name :"; cin>>name;
  			cout<<"Enter your sex(M/F) : "; cin>>sex;
  			cout<<"Enter your salary :"; cin>>salary;
		  }
		void output() {
			cout<<"Your id : "<<id<<endl;
			cout<<"Your name : "<<name<<endl;
			cout<<"Your sex : "<<sex<<endl;
			cout<<"Your salary :"<<salary<<endl;
		}
		float getsalary(){
			return salary;

		}
};
    void inputAll(Employee a[], int n){
    	cout<<"\n --- \n ";
    	for(int i=0; i<n; i++){
    		cout<<"Correct an employee : "<<(i + 1) <<endl;
    		a[i].input();
    		
		}
}
    void outputAll(Employee a[], int n){
    	cout<<"\n --- \n ";
    	for(int i=0; i<n; i++){
    		cout<<" Employee : " <<(i + 1) <<endl;
    		a[i].output();
    		
		}
}


		float totalsalary (Employee a[] , int n) {
			float s=0;
			for(int i=0; i<n; i++){
			
			s = s + a[i].getsalary();
		}
			return s;
			
		}
		int main(){
			Employee x[100];
			int n;
			float total;
			cout<<"Your member of the employee is: "; cin>>n;
			cout<<"Member of employee : "<<endl;
			inputAll(x,n);
			cout<<"Enter your member employee :";
			outputAll(x,n);
			total=totalsalary(x,n);
			cout<<"Total salary of emploee is = "<<total<<endl;
			return 0;
			
		}
	
    	
	













