#include <vector>
#include <iostream>
#include <map>
#include <string>
#include <sstream>
using namespace std;

class Node
{
public:
	Node() :parent(nullptr) {}
	Node(map<string, string> attr) :attr(attr), parent(nullptr) {}
	
	string name;
	Node* parent;
	vector<Node*> child;
	map<string, string> attr;
};

Node* createNode(string s)
{
	Node* node = new Node;
	stringstream ss(s);
	string word, key, value;
	
	while (getline(ss, word, ' '))
	{
		if (word[word.length() - 1] == '>') word = word.substr(0, word.length() - 1);

		if (word[0] == '<')
		{
			node->name = word.substr(1);
		}
		else if (word[0] == '"')
		{
			value = word.substr(1, word.length() - 2);
			node->attr.insert(pair<string, string>(key, value));
		}
		else if (word[0] != '=')
		{
			key = word;
		}
	}

	return node;
}

Node* findNode(Node* root, string name)
{
	int count = root->child.size();
	for (int i = 0; i < count; i++)
	{
		auto node = root->child[i];
		if (node->name == name) return (Node*)node;
	}
	return nullptr;
}

int main() {
	int n, q;
	cin >> n >> q;
	cin.ignore();

	Node* root = new Node;
	Node* cur = root;
	string s, str = "";
	for (int i = 0; i < n; i++)
	{
		getline(cin, s);

		if (s.find("</") == 0)
		{
			cur = cur->parent;
		}
		else
		{
			Node* node = createNode(s);
			cur->child.push_back(node);
			node->parent = cur;
			cur = node;
		}
	}

	for (int i = 0; i < q; i++)
	{
		str = "";
		cur = root;
		getline(cin, s);
		for (int j = 0; j < s.length(); j++)
		{
			if (s[j] == '.')
			{
				cur = findNode(cur, str);
				if (cur == nullptr)
				{
					cout << "Not Found!" << endl;
					break;
				}
				str = "";
			}
			else if (s[j] == '~')
			{
				Node* node = findNode(cur, str);
				if (node != nullptr)
				{
					string value = s.substr(j + 1, s.length());
					if (node->attr.find(value) != node->attr.end()) cout << node->attr[value] << endl;
					else cout << "Not Found!" << endl;
				}
				else
				{
					cout << "Not Found!" << endl;
					break;
				}
				str = "";
			}
			else
			{
				str += s[j];
			}
		}
	}
	return 0;
}