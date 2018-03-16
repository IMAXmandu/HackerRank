template <bool...digits>
int reversed_binary_value()
{
	int result = 0;
	const size_t size = sizeof...(digits);

	bool list[size] = { digits... };
	for (int i = 0; i < size; i++)
	{
		if (list[i] == true) result += 1 << i;
	}
	return result;
}