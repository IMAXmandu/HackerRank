class Matrix
{
public:
	vector<vector<int>> a;
	Matrix operator+(Matrix param)
	{
		Matrix result;
		for (int i = 0; i < this->a.size(); i++)
		{
			vector<int> b;
			for (int j = 0; j < this->a[i].size(); j++)
			{
				b.push_back(this->a[i][j] + param.a[i][j]);
			}
			result.a.push_back(b);
		}
		return result;
	}
};