class LRUCache : public Cache
{
public:
	LRUCache(int cap)
	{
		cp = cap;
		head = nullptr;
		tail = nullptr;
	}

	void set(int key, int value)
	{
		if (mp.size() >= cp)
		{
			Node* node = tail;
			tail = node->prev;

			mp.erase(node->key);
			delete node;
		}
		if (cp > 0)
		{
			Node* node = new Node(key, value);
			if (head == nullptr)
			{
				head = node;
				tail = node;
			}
			else
			{
				node->next = head;
				head->prev = node;
				head = node;
			}
			mp[key] = node;
		}
	}

	int get(int key)
	{
		if (mp.find(key) == mp.end()) return -1;
		else return mp.find(key)->second->value;
	}
};