class Person
{
protected:
	string name;
	int age;

public:
	virtual void getdata() { }
	virtual void putdata() { }
};

class Professor : public Person
{
	int publications;
	static int id;
	int cur_id;

public:
	Professor()
	{
		cur_id = ++id;
	}
	void getdata() override
	{
		cin >> name >> age >> publications;
	}
	void putdata() override
	{
		cout << name << " " << age << " " << publications << " " << cur_id << endl;
	}
};
int Professor::id = 0;

class Student : public Person
{
	int marks[6];
	static int id;
	int cur_id;

public:
	Student()
	{
		cur_id = ++id;
	}
	void getdata() override
	{
		cin >> name >> age;
		for (int i = 0; i < 6; i++) cin >> marks[i];
	}
	void putdata() override
	{
		int sum = 0;
		for (int i = 0; i < 6; i++) sum += marks[i];
		cout << name << " " << age << " " << sum << " " << cur_id << endl;
	}
};
int Student::id = 0;