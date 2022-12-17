// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает
// значение этого элемента или же указание, что такого элемента нет. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

int InitialData(string word)
{
    Console.Write(word);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] CreateRandomArray(int row, int colomn, int left, int right)
{
    int[,] randomArray = new int[row, colomn];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colomn; j++)
        {
            randomArray[i, j] = new Random().Next(left, right);
        }
    }

    return randomArray;
}

void ShowRandomArray(int[,] arr)
{
    Console.WriteLine($"Введен двухмерный массив, содержащий следующие элементы:");
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}   ");
        }

        Console.WriteLine();
    }
}

void FindNumberIntoArray(int[,] arr, int searchNumber)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == searchNumber)
            {
                Console.WriteLine($"Первое найденное число {searchNumber} расположено в массиве на {i + 1} строке, в {j + 1} столбце");
                return;
            }
        }
    }

    Console.Write($"Искомого числа {searchNumber} среди значений массива нет!");
}

int longRow = InitialData("Введите колличество строк массива: ");
int longColomn = InitialData("Введите колличество столбцов массива: ");
int leftBorder = InitialData("Введите начало диапазона, для генерации случайных чисел: ");
int rightBorder = InitialData("Введите конец диапазона, для генерации случайных чисел: ");
int valueOfNumber = InitialData("Введите значение числа, искомого в массиве: ");

Console.WriteLine();

int[,] newArray = new int[longRow, longColomn];
newArray = CreateRandomArray(longRow, longColomn, leftBorder, rightBorder);

ShowRandomArray(newArray);

Console.WriteLine();

FindNumberIntoArray(newArray, valueOfNumber);