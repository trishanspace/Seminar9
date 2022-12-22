// Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

GetNatureNumbersFromN(n, 1);

void GetNatureNumbersFromN(int n, int start = 1)
{
    if (n < start)
    {
        return;
    }
    GetNatureNumbersFromN(n, start + 1);
    GetReverseNatureNumbersFromN(start);
}

int GetReverseNatureNumbersFromN(int start)
{
    if (start <= 0)
    {
        return start;
    }
    else
    {
        int reverseNumbers = start % 10;
        start /= 10;
        return GetReverseNatureNumbersFromN(reverseNumbers); ;
        Console.Write($"{reverseNumbers}");
    }
}