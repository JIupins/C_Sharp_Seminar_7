// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int InitialData(string word)
{
    Console.Write(word);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] CreateArrayNumbers(int row, int colomn)
{
    int[,] array = new int[row, colomn];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colomn; j++)
        {
            Console.Write($"Введите значение элемента массива расположенного в {i + 1} строке, {j + 1} столбце: ");
            array[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }

    Console.WriteLine();

    return array;
}

void ShowArray(int[,] arr)
{
    Console.WriteLine($"Введен двухмерный массив, содержащий следующте элементы:");

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}   ");
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}

void FindAverageSumIntoColumn(int[,] arr)
{
    Console.Write($"Cреднее арифметическое значение элементов каждого столбца равно: ");

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double buffer = default;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            buffer += arr[i, j];
        }

        buffer /= arr.GetLength(0);

        Console.Write($"{buffer:0.0}; ");
    }
}

int longRow = InitialData("Введите колличество строк массива: ");
int longColomn = InitialData("Введите колличество столбцов массива: ");

int[,] newArray = new int[longRow, longColomn];
newArray = CreateArrayNumbers(longRow, longColomn);

ShowArray(newArray);

FindAverageSumIntoColumn(newArray);