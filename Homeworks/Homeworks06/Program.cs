// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)
//         {
//             Console.WriteLine($"Введите число: ");
//             array[i] = Convert.ToInt32(Console.ReadLine()); 
//         }

//     return array;
// }

// void PrintArray(int[] array)
// { 
//     for (int i = 0; i < array.Length; i++)
//         {
//         System.Console.Write( array[i] + " " );
//         }
//         Console.WriteLine();
// }
// void Sums(int[] myArray)
// {
//     int sum = 0;
//     for(int i = 0; i < myArray.Length; i++)
//     {
//         if(myArray[i] > 0)
//         {
//             sum ++;
//         }
//     }
//     Console.WriteLine($"Количество чисел больше нуля {sum}");
// }
// Console.Write("Сколько чисел хотите ввести: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateArray(size);
// PrintArray(myArray);
// Sums (myArray);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double[] lineDatal = InputLineData(LINE1);
double[] lineData2 = InputLineData(LINE2);
if (ValidateLines(lineDatal, lineData2))
{
    double[] coord = FindCoords(lineDatal, lineData2);
    Console.Write($"Точка пересечения прямых y={lineDatal[COEFFICIENT]}*x+{lineDatal[CONSTANT]} и y={lineData2[COEFFICIENT]}*x+{lineData2[CONSTANT]} ");
    Console.WriteLine($" имеет координаты ({coord[X_COORD]}, {coord[Y_COORD]})");
}

double Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[COEFFICIENT] = Prompt($"Введите значение b для {numberOfLine} уравнения: ");
    lineData[CONSTANT] = Prompt($"Введите значение k для {numberOfLine} уравнения: ");
    return lineData;
}

double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[X_COORD] = (lineData1[COEFFICIENT] - lineData2[COEFFICIENT]) / (lineData2[CONSTANT] - lineData1[CONSTANT]);
    coord[Y_COORD] = lineData2[CONSTANT] * coord[X_COORD] + lineData2[COEFFICIENT]; 
    return coord;
}
bool ValidateLines(double[] lineDatal, double[] lineData2)
{
    if (lineDatal[COEFFICIENT] == lineData2[COEFFICIENT])
    {
        if (lineDatal[CONSTANT] == lineData2[CONSTANT])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}