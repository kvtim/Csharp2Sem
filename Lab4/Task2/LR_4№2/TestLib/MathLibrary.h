#pragma once

#ifdef MATHLIBRARY_EXPORTS
#define MATHLIBRARY_API __declspec(dllexport)
#else
#define MATHLIBRARY_API __declspec(dllimport)
#endif

extern "C" 
{ 
	MATHLIBRARY_API int Sum(int a, int b);
	MATHLIBRARY_API int Difference(int a, int b);
	MATHLIBRARY_API double Division(int a, int b);
	MATHLIBRARY_API double Exponentiation(int a, int b);
}