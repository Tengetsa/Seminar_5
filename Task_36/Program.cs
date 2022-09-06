// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

void Task36()
{
    Console.WriteLine("Задайте длину массива: ");
    int size = int.Parse(Console.ReadLine()!);
    
    int[] array = new int[size];

    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    IndexSumOdd(array);
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-20, 21);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void IndexSumOdd(int[] array)
{
    int sum = 0;
    int result;
    for (int i = 1; i < array.Length; i += 2)
    {
        result = array[i];
        sum += result;
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}");
}

Task36();
