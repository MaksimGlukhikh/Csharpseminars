// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

void Digit()
{
    Console.Write($"Input three-digit: ");
    int x = Convert.ToInt32(Console.ReadLine());
    if(x > 99 && x < 1000)
    {
        int digit = (x /10 % 10);
        Console.WriteLine($"{digit}");
    }
    else
    {
      Console.WriteLine($"incorrect number entered");
    }
}
Digit();

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdDigit(int digit)
{
    while(digit > 999)
    {
        digit = digit /10; 
    } 
    int result = digit % 10;
    return result;
}
void Examination(int digit)
{
    if(digit > 99)
    {
        Console.WriteLine($"Third digit: {ThirdDigit(digit)}");
    }
    else
    {
        Console.WriteLine($"There is no third digit");
    }
}
Console.Write($"Input digit: ");
int digit = Convert.ToInt32(Console.ReadLine());
Examination(digit);



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool CorrectnessOfInput(int day)
{
    if(day >0 && day<8)
    {
        return true;
    }
    else 
    {
        Console.WriteLine($"Дня недели с номером {day} не существует!");
        return false;
    }
}
Console.Write($"Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if(CorrectnessOfInput(day))
{
    if (day > 5)
    {
        Console.WriteLine($"Выходной!");
    }
    else
        Console.WriteLine($"Будний день!");
}