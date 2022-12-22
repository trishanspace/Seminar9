// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

GetNatureNumbersInIntervalFromMtoN(m, n);

void GetNatureNumbersInIntervalFromMtoN(int m, int start = 1)
{
    if (m < start)
    {
        return;
    }
    Console.Write($"{start} ");
    GetNatureNumbersInIntervalFromMtoN(m, start + 1);
}

int GetSumNatureNumbers(int start)
{
    if (start < 10)
    {
        return start;
    }
    else
    {
        return start % 10 + GetSumNatureNumbers(start / 10);
        Console.Write($"{start} ");
    }
}