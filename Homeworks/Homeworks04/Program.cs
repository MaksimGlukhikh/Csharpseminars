
// Задача 1: Напишите цикл, который принимает на вход два числа (А и В)
// и возводит число А в натуральную степень В.
//  3, 5 -> 243 
//  2, 4 -> 16
// int Prompt (string message)
// {
//     System.Console.Write(message); //Выводим приглашение ко вводу 
//     string readInput = System.Console.ReadLine(); // Вводим значение 
//     int result = int.Parse (readInput); //приводим к числу
//     return result; //возвращаем результат
// }

// int Power (int powerBase, int exponent)
// {
//     int power = 1;
//     for (int i = 0; i < exponent; i++)
//     {
//     power *= powerBase;
//     }
//     return power;
// }
// bool ValidateExponent (int exponent)
// {
//     if (exponent < 0)
//     {
//         System.Console.WriteLine("Показатель не должен быть меньше нуля");
//         return false;
//     }
//     return true;
// }
// int powerBase = Prompt ("Введите основание: ");
// int exponent = Prompt ("Введите показатель: ");
// if (ValidateExponent (exponent))
// {
//     System.Console.WriteLine($"число {powerBase} в cтeпени {exponent} равно {Power (powerBase, exponent)}");
// }

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt (string message)
{
    System.Console.Write(message); //Выводим приглашение ко вводу 
    string readInput = System.Console.ReadLine(); // Вводим значение 
    int result = int.Parse (readInput); //приводим к числу
    return result; //возвращаем результат
}

int SumDigit(int num)
{
    int sum = 0;
    while(num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}
int num = Prompt($"Input figure: ");
System.Console.WriteLine($"Sum all digits equal to {SumDigit(num)}");
