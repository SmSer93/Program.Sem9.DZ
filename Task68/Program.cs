﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.Clear();

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int functionAkkerman = Akker(m, n);

int Akker(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akker(m - 1, 1);
    else return Akker(m - 1, Akker(m, n - 1));
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

Console.Write($"Функция Аккермана = {functionAkkerman} ");
