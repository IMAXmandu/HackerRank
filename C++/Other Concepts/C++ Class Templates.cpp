template <class T>
class AddElements
{
	T elements;
public:
	AddElements(T e) : elements(e) {}
	T add(T e)
	{
		return elements + e;
	}
	T concatenate(T e)
	{
		return elements + e;
	}
};