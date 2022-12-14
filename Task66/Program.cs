// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int M = InputNumbers("Введите m: ");
int N = InputNumbers("Введите n: ");
int elements = M;

if (M > N)
{
    M = N;
    N = elements;
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void PrintSum(int M, int N, int sum)
{
    sum = sum + N;
    if (N <= M)
    {
        Console.Write($"Сумма элементов = {sum} ");
        return;
    }
    PrintSum(M, N - 1, sum);
}

PrintSum(M, N, elements = 0);
