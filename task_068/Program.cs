Console.Write("Введите неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
while (m < 0)
{
    m = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Введите неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 0)
{
    n = Convert.ToInt32(Console.ReadLine());
}
int A(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if (n == 0)
        {
            return A(m - 1, 1);
        }
        else
        {
            return A(m - 1, A(m, n - 1));
        }
    }
}
Console.Clear();
Console.Write($"m = {m}, n = {n} -> A(m,n) = {A(m, n)}");