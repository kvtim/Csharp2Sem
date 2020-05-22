#include "pch.h"
#include <utility>
#include <limits.h>
#include "MathLibrary.h"
#include <string>
#include <iostream>
#include <math.h>

using namespace std;

int Sum(int a, int b)
{
    return a + b;
}

int Difference(int a, int b)
{
    return a - b;
}

double Division(int a, int b)
{
    if (b != 0)
    {
        return (a / b);
    }
    else
    {
        cout << " Ñannot be divided by zero" << endl;
    }
}

double Exponentiation(int a, int b)
{
	return pow(a, b);
}