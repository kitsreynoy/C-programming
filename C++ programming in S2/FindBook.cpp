#include<iostream>
using namespace std;
int main(){
	class Book{
		private:
			 int code ;
			char title [20]; 
			 float price;
		public:
			Book();
			Book(int c, char*n, float p);
	void input(){
		cout<<"code: ";cin>>code;
	    cout<<"title:";cin.ignore();
	    cin.getline(title,20);
		cout<<"price: ";cin>>price;
	}
	    
	void output(){
		//cout<<code<"\t"<<,title<<"\t"<<,price<<endl;
		cout<<code<<"\t"<<title<<"\t"<<price<<"\t"<<endl;
	}
	int getcode() const{
	    return code;
    }
    void setPrice(float p){
    	price = p;
	}
	
	

};

//function to input all books
void inputAll(Book a[], int n) {
	for (int i=0; i<n; i++){
		cout<<"Enter the book  "<<i+1<<":\n";
	}
}


//functiom 
void outputAll (book a[], int i){
	cout<<"list of the book:";cin>>endl;
	for(int i=0; i<n; i++){
		a[i].output();
	}
}

//funtion
Book* search(Book a[], int n, int codeTofound){
	Book* p = NULL;
	for(int i=0; i<n; i++){
		if(a[i].getcode() == codeTofound){
			p = $a[i];
			break;
		}
	}
	return p;
}

void main(){
   Book *x,*p;
   int n,co;float pri;
   cout<<"Number of book:";cin>>n;
   x=new  Book[n];
   cout<<"input data all:"<<endl;
   inputAll(x,n);
   cout<<"output all data"<<endl;
   outputAll(x,n);
   cout<<"Code to search:";cin>>co;
   p=search(x,n,co);
   if(p==NULL)cout<<"No data to search"<<endl;
   else{
       cout<<"New price:";cin>>pri;
       p->setPrice(pri);
   }
   cout<<"After updating price:"<<endl;
   outputAll(x,n);
   return 0;
}








