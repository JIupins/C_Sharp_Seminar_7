// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

int InitialData(string word)
{
    Console.Write(word);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

double[,] CreateArray(int row, int colomn, int left, int right)
{
    double[,] randomArray = new double[row, colomn];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colomn; j++)
        {
            randomArray[i, j] = new Random().Next(left,right) + new Random().NextDouble();
        }
    }

    return randomArray;
}

void WriteArray(double[,] arr)
{
    Console.WriteLine($"Введен двухмерный массив, содержащий следующие элементы:");

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]:0.0}   ");
        }

        Console.WriteLine();
    }
}

int longRow = InitialData("Введите колличество строк массива: ");
int longColomn = InitialData("Введите колличество столбцов массива: ");
int leftBorder = InitialData("Введите начало диапазона, для генерации случайных чисел: ");
int rightBorder = InitialData("Введите конец диапазона, для генерации случайных чисел: ");

Console.WriteLine();

double[,] newArray = new double[longRow, longColomn];
newArray = CreateArray(longRow, longColomn, leftBorder, rightBorder);

WriteArray(newArray);