#include <iostream>
#include <map>
#include <string>
using namespace std;

int main() {
	int q;
	cin >> q;
	map<string, int> maps;

	for (int i = 0; i < q; i++)
	{
		int command;
		cin >> command;
		string name = "";
		cin >> name;
		if (command == 1)
		{
			int value;
			cin >> value;
			if (maps.find(name) == maps.end()) maps[name] = value;
			else maps[name] += value;
		}
		else if (command == 2)
		{
			maps.erase(name);
		}
		else if (command == 3)
		{
			if (maps.find(name) == maps.end()) cout << "0" << endl;
			else cout << maps[name] << endl;
		}
	}
	return 0;
}