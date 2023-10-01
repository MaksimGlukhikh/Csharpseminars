// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.



// int[] CreateArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)
//         {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//         }

//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("{");
//     for (int i = 0; i < array.Length; i++)
//         {
//         System.Console.Write( array[i] + " " );
//         }
//     Console.WriteLine("}");
// }
// void Sums(int size, int[] myArray)
// {
//     int sumPlus = 0, sumMinus = 0; 
//     for(int i = 0; i < size; i++)
//     {
//         if (myArray[i] > 0)
//         {
//             sumPlus = sumPlus + myArray[i];  
//         }
//         else
//         {
//             sumMinus = sumMinus + myArray[i];
//         }
//     }
//     Console.WriteLine($"{sumPlus} {sumMinus}");
// }
// int size = 12, min = -9, max = 9;

// int[] myArray = CreateArray(size, min, max);
// PrintArray(myArray);
// Sums(size, myArray);

// Решение в группах задач:
// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] CreateArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)
//         {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//         }

//     return array;
// }
// void PrintArray(int[] array)
// {
//     Console.Write("{");
//     for (int i = 0; i < array.Length; i++)
//         {
//         System.Console.Write( array[i] + " " );
//         }
//     Console.WriteLine("}");
// }
// int[] ReversValueArray(int[]myArray)
// {
//     for(int i = 0; i < myArray.Length; i++)
//     {
//         if(myArray[i] < 0)
//             myArray[i] = Math.Abs(myArray[i]);
//         else
//             myArray[i] *= -1;

//     }
//     return myArray;
// }
// Console.Write($"Input size array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Input max value array: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Input min value array: ");
// int min = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateArray(size, min, max);
// PrintArray(myArray);
// myArray = ReversValueArray(myArray);
// PrintArray(myArray);
// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        {
            Console.Write($"Input element {i} array: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

    return array;
}
void PrintArray(int[] array)
{
    Console.Write("{ ");
    for (int i = 0; i < array.Length; i++)
        {
        System.Console.Write( array[i] + ", " );
        }
    Console.WriteLine("}");
}
bool Looking(int[] array, int lookingFor)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == lookingFor)
        {
            return true;
        } 
         
    }
    return false;
}
Console.Write($"Input size array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write($"Input what you're looking for: ");
int lookingFor = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(size);
PrintArray(myArray);
if(Looking(myArray, lookingFor))
{
    Console.Write($"Present");
}
else 
    Console.Write($"Absent");