// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int DigitCount (int numb)
{
    int count = 1;
    while(Math.Abs(numb) > 10)
    {
        numb = numb / 10;
        count++;
    }
    return count;
}
Console.WriteLine($"Input digit: ");
int numb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DigitCount(numb));