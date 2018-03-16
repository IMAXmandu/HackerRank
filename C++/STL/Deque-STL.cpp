#include <iostream>
#include <deque> 
using namespace std;

void printKMax(int arr[], int n, int k)
{
	deque<int> deq(k);
	
	int i = 0;
	for (; i < k; i++)
	{
		while (deq.empty() == false && arr[i] > arr[deq.back()]) deq.pop_back();
		deq.push_back(i);
	}

	for (; i < n; i++)
	{
		cout << arr[deq.front()] << " ";

		while (deq.empty() == false && deq.front() <= i - k) deq.pop_front();
		while (deq.empty() == false && arr[i] > arr[deq.back()]) deq.pop_back();
		deq.push_back(i);
	}

	cout << arr[deq.front()] << endl;
}

int main()
{
	int t;
	cin >> t;
	while (t>0)
	{
		int n, k;
		cin >> n >> k;
		int i;
		int arr[n];
		for (i = 0; i<n; i++) cin >> arr[i];
		printKMax(arr, n, k);
		t--;
	}
	return 0;
}