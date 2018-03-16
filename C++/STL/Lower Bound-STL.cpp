#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;

int main() {
	int n;
	cin >> n;
	vector<int> vec;
	for (int i = 0; i < n; i++)
	{
		int x;
		cin >> x;
		vec.push_back(x);
	}

	int q;
	cin >> q;
	for (int i = 0; i < q; i++)
	{
		int y;
		cin >> y;

		vector<int>::iterator low = lower_bound(vec.begin(), vec.end(), y);
		if (vec[low - vec.begin()] == y) cout << "Yes ";
		else cout << "No ";
		cout << (low - vec.begin() + 1) << endl;
	}
	return 0;
}