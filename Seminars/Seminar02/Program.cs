// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если второе число не кратно числу первому,
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// void CheckMultiplicity(int num1, int num2)
// {
//     if(num1 % num2 == 0)
//     {
//         Console.WriteLine($"{num1} кратно {num2}");
//     }
//     else
//     {
//        Console.WriteLine($"{num1}, {num2} не кратно, остаток {num1 % num2}"); 
//     }
// }
// Console.Write($"Input first number: ");
// int n1 = Convert.ToInt32( Console.ReadLine());
// Console.Write($"Input second number: ");
// int n2 = Convert.ToInt32( Console.ReadLine());
// CheckMultiplicity(n1, n2);

// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// 78 -> 8

// 12-> 2

// 85 -> 8

// int FindBiggestDigit(int num)
// {
//     int ed = num % 10;
//     int dec = num / 10;
//     if(ed > dec)
//     {
//         return ed;
//     }
//     else 
//     {
//         return dec;
//     }
// }

// int num = new Random().Next(10, 100);
// Console.WriteLine($"You number: {num}");
// Console.Write($"Biggest Digit: {FindBiggestDigit(num)}");

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

void Digit()
{
    int x = new Random().Next(100, 1000);
    Console.WriteLine($"{x}");
    int digit = ((x /100) * 10 + x % 10);
    Console.WriteLine($"{digit}");
}
Digit();
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// void CheckMultiplicity(int num1)
// {
//     if(num1 % 7 == 0 && num1 % 23 == 0)
//     {
//         Console.WriteLine($"{num1} -> да");
//     }
//     else
//     {
//        Console.WriteLine($"{num1} -> нет"); 
//     }
// }
// Console.Write($"Input number: ");
// int n1 = Convert.ToInt32( Console.ReadLine());
// CheckMultiplicity(n1);