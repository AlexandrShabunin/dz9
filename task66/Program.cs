// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

SumFromMToN(M, N);

void SumFromMToN(int M, int N)  // вызов функции "сумма чисел от M до N"

{
    Console.Write(SumMN(M - 1, N));
}

int SumMN(int M, int N)  // функция сумма чисел от M до N
{
    int raf = M; // введем переменную для M
    if (M == N)
        return 0;
    else
    {
        M++;
        raf = M + SumMN(M, N);
        return raf;
    }
}