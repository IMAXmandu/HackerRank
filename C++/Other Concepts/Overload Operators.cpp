Complex operator+(Complex a, Complex b)
{
	Complex result;
	result.a = a.a + b.a;
	result.b = a.b + b.b;
	return result;
}

ostream& operator<<(ostream& os, const Complex& c)
{
	os << c.a << "+" << "i" << c.b << endl;
	return os;
}