class Student
{
private:
	int a, b, c, d, e;
public:
	void input() {cin >> a >> b >> c >> d >> e;	}
	int calculateTotalScore() { return a + b + c + d + e; }
};