// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ShowNombers(int n)
{
    if(n >= 1)
    {
        Console.Write (n + " ");
        ShowNombers(n - 1);
        
    }
}
Console.Write($"Input N: ");
ShowNombers(Convert.ToInt32(Console.ReadLine()));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int RecursiveSum(int m, int n)
{
if (m > n) return RecursiveSum(n, m); // Поменяем местами `m` и `n` и рекурсивно вызовем метод
if (m == n) return m; // Когда `m` равно `n` сумма ровна `m`
return m + RecursiveSum(m + 1, n);
}

Console.Write($"Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = RecursiveSum(m, n);
Console.WriteLine($"Сумма натуральных чисел от {m} до {n} равна {sum}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int RecursiveAckermann(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return RecursiveAckermann(m - 1, 1);
else return RecursiveAckermann(m - 1, RecursiveAckermann(m, n - 1));
}
Console.Write($"Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = RecursiveAckermann(m, n);
Console.WriteLine($"A({m}, {n}) = {result}");
