//  Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void Task34()
{
    int size = 10;
    int[] array = new int[size];

    FillArray(array);
    PrintArray(array);

    int evenNumber = IndexOf(array);
    Console.WriteLine($" - количество четных числе в массиве {evenNumber}");
}

void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int IndexOf(int[] array, int cound = 0)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if(array[i] % 2 == 0)
        {
            cound += 1;
        }
    }
    return cound;
}

Task34();