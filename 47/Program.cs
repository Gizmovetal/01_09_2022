//Методы генерации и вывода массива взял из примера, показанного, на семинаре. Только изменил тип на double, расширил диапазон и откорректировал вывод (2 знака после запятой).
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
double[,] array = GetArray(rows, columns, -100, 100);
PrintArray(array);
double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble();
            result[i, j] += new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write("{0:F2}", inArray[i, j]);
            Console.Write("  ");
        }
        Console.WriteLine();
    }
}