#include <iostream>

using namespace std;

int main()
{
	int N = 0;
	int arr[1000];

	cin >> N;

	for (int i = 0; i < N; i++)
	{
		cin >> arr[i];
	}

	double sum = 0;
	double max_arr = 0;

	for (int i = 0; i < N; i++)
	{
		sum += arr[i];
		
		if (arr[i] > max_arr)
			max_arr = arr[i];
	}

	double result = sum * 100 / max_arr / N;
	cout << result << endl;

	return 0;
}
