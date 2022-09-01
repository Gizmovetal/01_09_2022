//Немного дописал метод с семинара. Сделал расчёт общего числа позиций в масииве и сравнение с введённой позицией. В случае если позиция присутствует в массиве вовод значения на экран.
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.Write("Введите искомую позицию в массиве: ");
int position = int.Parse(Console.ReadLine() ?? "");

PrintPosition(array, position);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintPosition(int[,] inArray, int position)
{   
    int pos = 1;
    int rows = inArray.GetLength(0);
    int colums = inArray.GetLength(1);
    int allPosition = rows*colums;

    if (position > allPosition) Console.Write($"Позиции {position} нет в массиве");

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            if (pos == position) Console.Write($"В позиции {position} число -> {inArray[i, j]} ");
            pos = pos + 1;
        }
        Console.WriteLine();
    }
}

