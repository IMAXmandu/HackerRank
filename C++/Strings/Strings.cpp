#include <iostream>
#include <string>
using namespace std;

int main()
{
	string a;
	string b;
	cin >> a >> b;
	cout << a.length() << " " << b.length() << endl;
	cout << a + b << endl;
	char temp = a[0];
	a[0] = b[0];
	b[0] = temp;
	cout << a << " ";
	cout << b;
	return 0;
}