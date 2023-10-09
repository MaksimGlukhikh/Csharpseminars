// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите консольну программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (sbyte i = 0; i < size; i++)
        {
        array[i] = new Random().Next(100, 1000);
        }

    return array;
}

void PrintArray(int[] array)
{ 
    for (int i = 0; i < array.Length; i++)
        {
        System.Console.Write( array[i] + " " );
        }
}
void Sums(int[] myArray)
{
    int sum = 0;
    for(int i = 0; i < myArray.Length; i++)
    {
        if(myArray[i] % 2 == 0)
        {
            sum += myArray[i];
       
        }
    }
    Console.WriteLine($"Сумма четных элементов равна {sum}");
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(size);
PrintArray(myArray);
Sums (myArray);

//  Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (sbyte i = 0; i < size; i++)
        {
        array[i] = new Random().Next(minValue, maxValue + 1); 
        }

    return array;
}

void PrintArray(int[] array)
{ 
    for (int i = 0; i < array.Length; i++)
        {
        System.Console.Write( array[i] + " " );
        }
        Console.WriteLine();
}
void Sums(int[] myArray)
{
    int sum = 0;
    for(int i = 0; i < myArray.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum += myArray[i];
        }
    }
    Console.WriteLine($"Сумма элементов на нечетных позициях равна {sum}");
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(size, minValue, maxValue);
PrintArray(myArray);
Sums (myArray);

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArray(int size, double minValue, double maxValue)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
        {
        array[i] = Math.Round((new Random().NextDouble() * (maxValue - minValue) + minValue), 2); 
        }

    return array;
}

void PrintArray(double[] array)
{ 
    for (int i = 0; i < array.Length; i++)
        {
        System.Console.Write( array[i] + " " );
        }
        Console.WriteLine();
}
void Differences(double[] myArray)
{
    double difference = 0;
    double min = myArray[0];
    double max = myArray[0];
    for(int i = 0; i < myArray.Length; i++)
    {   
        if (myArray[i] < min)
            {
                min=myArray[i];
            }
        if (myArray[i] > max)
            {
                   max=myArray[i];
            }                        
        }
        difference = max - min;
        Console.WriteLine($"Разность между максимальным и минимальным элементами массива равна {difference}");
    }
    
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
double minValue = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
double maxValue = Convert.ToDouble(Console.ReadLine());
double[] myArray = CreateArray(size, minValue, maxValue);
PrintArray(myArray);
Differences (myArray);

