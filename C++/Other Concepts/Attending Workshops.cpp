#include <algorithm>
#include <vector>
struct Workshop
{
	int start_time;
	int duration;
	int end_time;
};

struct Available_Workshops
{
	int n;
	vector<Workshop> arr;
};

Available_Workshops* initialize(int start_time[], int duration[], int n)
{
	Available_Workshops* instance = new Available_Workshops;
	instance->n = n;

	for (size_t i = 0; i < n; i++)
	{
		Workshop workshop;
		workshop.start_time = start_time[i];
		workshop.duration = duration[i];
		workshop.end_time = workshop.start_time + workshop.duration;
		instance->arr.push_back(workshop);
	}

	return instance;
}

bool compare(Workshop w1, Workshop w2)
{
	return (w1.end_time < w2.end_time);
}

int CalculateMaxWorkshops(Available_Workshops* ptr)
{
	// Sorting by end_time
	sort(ptr->arr.begin(), ptr->arr.end(), compare);

	// repeat until maximum start_time
	int maxWorkShop = 0;
	int lastEndTIme = -1;
	for (size_t i = 0; i < ptr->n; i++)
	{
		if (lastEndTIme <= ptr->arr[i].start_time)
		{
			maxWorkShop++;
			lastEndTIme = ptr->arr[i].end_time;
		}
	}
	return maxWorkShop;
}