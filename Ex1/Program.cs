int[] array = new int[20];

CreateMas(array);
PrintMas(array);
GetSum(array);

void CreateMas(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}

void PrintMas(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void GetSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    Console.WriteLine();
    Console.Write("Сумма элементов на нечетных позициях равна ");
    Console.WriteLine(sum);
}