class Box
{
private:
	int l, b, h;
public:
	Box() { l = b = h = 0; }
	Box(int l, int b, int h) { this->l = l; this->b = b; this->h = h; }
	Box(const Box& box) { l = box.l; b = box.b; h = box.h; }

	int getLength() { return l; }
	int getBreadth() { return b; }
	int getHeight() { return h; }
	long long CalculateVolume() { return (long long)l*b*h; }
	bool operator<(Box& b)
	{
		if (this->l < b.l ||
			(this->b < b.b && this->l == b.l) ||
			(this->h < b.h && this->b == b.b && this->l == b.l)) return true;
		return false;
	}

	friend ostream& operator<<(ostream& out, Box& B);
};

ostream& operator<<(ostream& out, Box& B)
{
	out << B.l << " " << B.b << " " << B.h;
	return out;
}