#include<iostream>
#include<string.h>
using namespace std;
class Student{
  private:
    int id,score;
    char name[20],sex;
  public:
    Student() {
      //Defualt constructor
          id = 11192;
          strcpy(name, "Marineth");
          sex = 'F';
           score = 75;
      }
        Student(int i,const char* n,char s,int sc){
          id=i;strcpy(name,n);sex=s;score=sc;
    }
      Student(const Student &p) {
          id = p.id;
          strcpy(name, p.name);
          sex = p.sex;
          score = p.score;
    }
    void input(){
      cout<<"Id:";cin>>id;cin.ignore();
      cout<<"Name:";cin.get(name,20);
      cout<<"Sex:";cin>>sex;
      cout<<"Score:";cin>>score;
    }
    void output(){
      cout<<id<<"\t"<<name<<"\t"<<sex<<"\t"<<score<<endl;
    }
    int getId(){return id;}
    int getScore(){return score;}
    void setScore(int sc){
      score=sc;
    }
    
};
  void inputAll(Student a[],int n){
    for(int i=0;i<n;i++){
      cout<<"Data of student"<<(i+1)<<": "<<endl;
      a[i].input();
  }
}
  void outputAll(Student a[],int n){
    for(int i=0;i<n;i++)
      a[i].output();
}
  void sort(Student a[],int n){
    for(int i=0;i<n;i++){
      for(int j=i+1;j<n;j++){
        if(a[i].getScore()<a[j].getScore()){
          Student temp =a[i];
          a[i]=a[j];
          a[j]=temp;
        }
      }
    }
  }
  Student *Search(Student a[],int n, int idd){
    Student *p=NULL;
    
    for(int i=0;i<n;i++){
      if(a[i].getId()==idd){
      p=&a[i];
      break;
      }
    }
  return p;
  }
int main(){
  Student x[100],*p1;
  int n,idd;
    cout << "Data of student: "; cin >> n;

    inputAll(x, n);
    cout << "-There is data of student: " << endl;
    outputAll(x, n);

    cout << "Id search: "; cin >> idd;
    p1 = Search(x, n, idd);

    if (p1 == NULL) {
        cout << "Not found!" << endl;
    } else {
        p1->setScore(p1->getScore() + 10);
        cout << "Score updated:" << endl;
        outputAll(x, n);
    }

    sort(x, n);
    cout << "After sorting: " << endl;
    outputAll(x, n);

    return 0;
}
