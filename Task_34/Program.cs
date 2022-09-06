//  Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void Task34()
{
    Console.WriteLine("Задайте длину массива: ");
    int size = int.Parse(Console.ReadLine()!);

    int[] array = new int[size];

    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    CountEvenNumber(array);
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void CountEvenNumber(int[] array, int count = 0)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count += 1;
        }
    }
    Console.WriteLine($"Количество четных числе в массиве {count}");
}

Task34();