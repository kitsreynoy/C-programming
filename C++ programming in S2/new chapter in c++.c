#include<iostream.h>
#include<conio.h>
  void main(){
   int id;
   char name[20], sex;
   float salary;
   cout<<"input id:"; cin>>id;
   cout<<"input name: "; cin.seekg(0,ios::end);cin.clear();
   cin.get(name,20);
   cout<<"input sex: ";cin>>sex;
   cout<<"input salary: ";cin>>salary;
   cout<<"Your CV:\n";
   cout<<"id:"<<id<<endl;
