// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void Task38()
{
    Console.WriteLine("Задайте длину массива: ");
    int size = int.Parse(Console.ReadLine()!);

    double[] array = new double[size];

    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    DifferenceMinMax(array);
}

void FillArray(double[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(random.NextDouble() * 100, 2);
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "|");
    }
}

void DifferenceMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"Разница между {max} и {min} = {Math.Round(max - min, 2)}");
}

Task38();
