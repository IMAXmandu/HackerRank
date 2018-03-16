#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <set>
#include <algorithm>
using namespace std;

int main() {
	int q;
	cin >> q;

	set<int> s;
	for (int i = 0; i < q; i++)
	{
		int y, x;
		cin >> y >> x;
		switch (y)
		{
			case 1:
			{
				s.insert(x);
				break;
			}
			case 2:
			{
				s.erase(x);
				break;
			}
			case 3:
			{
				set<int>::iterator iter = s.find(x);
				if (iter != s.end()) cout << "Yes" << endl;
				else cout << "No" << endl;
				break;
			}
		}
	}
	return 0;
}