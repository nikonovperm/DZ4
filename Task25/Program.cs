﻿// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

void NumberAToThePowerOfB (int numberA, int numberB)
{
    double numberC = Math.Pow(numberA,numberB);
    Console.WriteLine("А в степени В = " + numberC);
}

Console.Write("Введите число А (возводимое в степень): ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число В (степень): ");
int numberB = Convert.ToInt32(Console.ReadLine());

NumberAToThePowerOfB(numberA,numberB);

