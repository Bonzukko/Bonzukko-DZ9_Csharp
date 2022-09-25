﻿Console.Write("Введите число М: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
string NaturalNumbers(int M, int N)
{
    if (M == N)
    {
        return $"{M}";
    }
    else
    {
        if (M < N)
        {
            return $"{M}, " + NaturalNumbers(M + 1, N);
        }
        else
        {
            return $"{M}, " + NaturalNumbers(M - 1, N);
        }
    }
}
Console.Clear();
Console.Write($"M = {M}; N = {N}. -> ''{NaturalNumbers(M, N)}''");