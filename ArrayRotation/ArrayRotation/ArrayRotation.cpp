// ArrayRotation.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>

using namespace std;
int main()
{
	int arr[5] = { 1,2,3,4,5 };
	int temp[5];

	int x, j = 0, n;
	cout << "Elements of array are : 1 2 3 4 5 " << endl;

	cout << "Enter the numer of rotation [ 0 - 5 ] : " << endl;
	cin >> x;
	for (int i = x; i < 5; i++)
	{
		temp[j] = arr[i];
		j++;	
	}
	for (int i = 0; i < x; i++)
	{
		temp[j] = arr[i];
		j++;
	}
	

	for (int i = 0; i < 5; i++)
	{
		cout << temp[i];
	}

	system("Pause");


	return 0;

    
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
