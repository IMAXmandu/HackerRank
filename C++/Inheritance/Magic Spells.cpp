	if (Fireball* magic = dynamic_cast<Fireball*>(spell)) magic->revealFirepower();
	else if (Frostbite* magic = dynamic_cast<Frostbite*>(spell)) magic->revealFrostpower();
	else if (Thunderstorm* magic = dynamic_cast<Thunderstorm*>(spell)) magic->revealThunderpower();
	else if (Waterbolt* magic = dynamic_cast<Waterbolt*>(spell)) magic->revealWaterpower();
	else
	{
		//Calculation Table Index and LCS Length
		string name = '0' + spell->revealScrollName();
		string journal = '0' + SpellJournal::read();
		int len1 = name.length();
		int len2 = journal.length();
		int lcs[len1][len2] = { 0, };

		for (int i = 0; i < len1; i++)
		{
			for (int j = 0; j < len2; j++)
			{
				if (i == 0 || j == 0)
				{
					lcs[i][j] = 0;
					continue;
				}
				if (name[i] == journal[j]) lcs[i][j] = lcs[i - 1][j - 1] + 1;
				else lcs[i][j] = (lcs[i][j - 1] > lcs[i - 1][j]) ? lcs[i][j - 1] : lcs[i - 1][j];
			}
		}

		cout << lcs[len1 - 1][len2 - 1] << endl;
	}