#include <iostream>
using namespace std;
#include <math.h>
#include <conio.h>
float a,b,c,x1,x2,delta;
void main()
{
cout<<a;
cout<<b;
cout<<c;
delta=b*b-4*a*c;
if (delta<0)
cout<<"Ecuatia nu are solutie in Z";

else {
x1=(-b+sqrt(delta))/(2*a);
x2=(-b-sqrt(delta))/(2*a);
cout<<"x1 este "<<x1<<endl;
cout<<"x2 este "<<x2<<endl;
}
_getch();
}