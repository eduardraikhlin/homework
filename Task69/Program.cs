﻿// 69. Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int x = 5;
int y = 3;

 int PowerDigits(int num1, int num2 )
 {
     if (num2 == 0) return 1;
     else return num1 * PowerDigits(num1, num2 - 1);
 }

 Console.WriteLine(PowerDigits(x, y));