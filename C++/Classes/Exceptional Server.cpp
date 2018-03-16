        try{
			int result = Server::compute(A, B);
			cout << result << endl;
		}
		catch (bad_alloc& e)
		{
			cout << "Not enough memory" << endl;
		}
		catch (exception& e)
		{
			cout << "Exception: " << e.what() << endl;
		}
		catch (...)
		{
			cout << "Other Exception" << endl;
		}