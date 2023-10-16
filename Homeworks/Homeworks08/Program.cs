// using System;

// public class Answer
// {
//     public static void PrintMatrix(int[,] matrix)
//     {
// // Введите свое решение ниже
//          for (int i= 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i,j]}" + "\t");
//         }
//         Console.WriteLine();


//     }
    
//     }


//     public static void SortRowsDescending(int[,] matrix)
//     {
//         int numRows = matrix.GetLength(0);
//         int numColumns = matrix.GetLength(1);

//         for (int i = 0; i < numRows; i++)
//         {
//     // Создаем временный массив для хранения строкового представления текущей строки матрицы
//             string[] rowValues = new string[numColumns];

//     // Заполняем временный массив строковыми представлениями элементов текущей строки матрицы
//             for (int j = 0; j < numColumns; j++)
//             {
//                 rowValues[j] = matrix[i, j].ToString();
//             }

//     // Сортируем строковые представления элементов по убыванию
//             Array.Sort(rowValues);
//             Array.Reverse(rowValues);

//     // Обновляем текущую строку матрицы с отсортированными элементами
//         for (int j = 0; j < numColumns; j++)
//             {
//             matrix[i, j] = int.Parse(rowValues[j]);
//             }
//         }
//     }

// // Не удаляйте и не меняйте метод Main! 
//     public static void Main(string[] args)
//     {
//         int[,] matrix;
//         if (args.Length == 0)
//         {
//             // Если аргументы не переданы, используем матрицу по умолчанию
//             matrix = new int[,] {
//                 {5, 2, 9},
//                 {8, 1, 4},
//                 {6, 7, 3}
//             };
//         }
//         else
//         {
//             // Иначе, парсим аргументы в двумерный массив
//             string[] rows = args[0].Split(';');
//             matrix = new int[rows.Length, rows[0].Split(',').Length];
//             for (int i = 0; i < rows.Length; i++)
//             {
//                 string[] elements = rows[i].Split(',');
//                 if (elements.Length != matrix.GetLength(1))
//                 {
//                     Console.WriteLine($"Ошибка: Неправильное количество элементов в строке {i + 1}.");
//                     return;
//                 }
//                 for (int j = 0; j < elements.Length; j++)
//                 {
//                     if (int.TryParse(elements[j], out int number))
//                     {
//                         matrix[i, j] = number;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
//                         return;
//                     }
//                 }
//             }
//         }

//         Console.WriteLine("Исходная матрица:");
//         PrintMatrix(matrix);

//         SortRowsDescending(matrix);

//         Console.WriteLine("\nМатрица с упорядоченными по убыванию строками:");
//         PrintMatrix(matrix);
//     }

// }


// Определение строки с наименьшей суммой элементов

// Напишите программу для работы с матрицей целых чисел.

// Реализуйте класс Answer, который содержит следующие статические методы:

// SumOfRow(int[,] matrix, int row): Метод для вычисления суммы элементов в заданной строке row матрицы matrix.
// Метод принимает двумерный массив целых чисел matrix и номер строки row, а возвращает целое число - сумму элементов в данной строке.

// MinimumSumRow(int[,] matrix): Метод для определения строки с наименьшей суммой элементов.
// Метод принимает двумерный массив целых чисел matrix и возвращает массив из двух элементов: номер строки с наименьшей суммой (нумерация начинается с 0) и саму сумму.

// using System;

// public class Answer
// {
//     public static int SumOfRow(int[,] matrix, int row)
//     {
// // Введите свое решение ниже
//         int sum = 0;
//         for (int i = 0; i < matrix.GetLength(1); i++)
//         {
//             sum += matrix[row, i];
//         }
//         return sum;
//     }

//     public static int[] MinimumSumRow(int[,] matrix)
//     {
// // Введите свое решение ниже

//         int minRow = 0;
//         int minSum = int.MaxValue;

//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             int rowSum = 0;
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 rowSum += matrix[i, j];
//             }

//             if (rowSum < minSum)
//             {
//                 minSum = rowSum;
//                 minRow = i;
//             }
//         }

//         return new int[] { minRow, minSum };

//     }

//  // Не удаляйте и не меняйте метод Main! 
//     public static void Main(string[] args)
//     {
//         int[,] matrix;
//         if (args.Length == 0)
//         {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//           // Если аргументы не переданы, используем матрицу по умолчанию
            
//             matrix = new int[,]
//             {
//                 {5, 2, 9},
//                 {8, 1, 4},
//                 {6, 7, 3}
//             };
//         }
//         else
//         {
//             // Иначе, парсим аргументы в двумерный массив
//             string[] rows = args[0].Split(';');
//             matrix = new int[rows.Length, rows[0].Split(',').Length];
//             for (int i = 0; i < rows.Length; i++)
//             {
//                 string[] elements = rows[i].Split(',');
//                 for (int j = 0; j < elements.Length; j++)
//                 {
//                     if (int.TryParse(elements[j], out int number))
//                     {
//                         matrix[i, j] = number;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
//                         return;
//                     }
//                 }
//             }
//         }

//         Console.WriteLine("Исходная матрица:");
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write($"{matrix[i, j]}\t");
//             }
//             Console.WriteLine();
//         }

//         int[] minSumRow = MinimumSumRow(matrix);

//         Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");
//     }
// }

// Реализуйте класс MatrixOperations, который содержит следующие статические методы:

// MultiplyIfPossible(int[,] matrixA, int[,] matrixB): Метод для проверки, возможно ли умножения двух матриц matrixA и matrixB.
// Если число столбцов в матрице matrixA не равно числу строк в матрице matrixB, то выводится сообщение "It is impossible to multiply."
// В противном случае, вызывается метод MatrixMultiplication для умножения матриц, и результат выводится с помощью метода PrintMatrix.

// MatrixMultiplication(int[,] matrixA, int[,] matrixB): Метод для умножения двух матриц matrixA и matrixB.
// Метод возвращает новую матрицу, которая представляет собой результат умножения матрицы matrixA на матрицу matrixB.
// PrintMatrix(int[,] matrix): Метод для вывода матрицы на консоль.
// Если аргументы не переданы, программа использует матрицы по умолчанию.
// Если аргументы переданы, программа парсит их в двумерные массивы целых чисел и выполняет умножение матриц.

using System;

public class Answer
{
    public static void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
    { // Введите свое решение ниже
       
        if (matrixA.GetLength(1) != matrixB.GetLength(0))
        {
            Console.WriteLine("It is impossible to multiply.");
            return;
        }

// Вызываем метод MatrixMultiplication для умножения матриц
        int[,] resultMatrix = MatrixMultiplication(matrixA, matrixB);

// Выводим результат с помощью метода PrintMatrix
        PrintMatrix(resultMatrix);

    }

    public static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {  // Введите свое решение ниже

        // Создаем новую матрицу для хранения результата
        int[,] resultMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(0)];

        // Умножаем матрицы
        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < matrixA.GetLength(1); k++) sum += matrixA[i, k] * matrixB[k, j];
                resultMatrix[i, j] = sum;
            }
        }

        return resultMatrix;


    }

    public static void PrintMatrix(int[,] matrix)
    {  // Введите свое решение ниже


        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++) Console.Write(matrix[i, j] + "\t");
            Console.WriteLine();
        }

    }
 // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[,] matrix;

        if (args.Length == 0)
        {
            // Если аргументы не переданы, используем матрицу по умолчанию
            matrix = new int[,]
            {
                {1, 2},
                {3, 4}
            };
        }
        else
        {
            // Иначе, парсим аргументы в двумерный массив
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        int[,] matrixB = {
            {5, 6},
            {7, 8}
        };

        Console.WriteLine("\nMatrix B:");
        PrintMatrix(matrixB);

        Console.WriteLine("\nMultiplication result:");

        MultiplyIfPossible(matrix, matrixB);
    }
}