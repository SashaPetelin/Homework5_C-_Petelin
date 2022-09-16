int[] array = new int[20];

CreateMas(array);
PrintMas(array);
GetMinMax(array);

void CreateMas(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintMas(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void GetMinMax(int[] array)
{
    int max = array[0];
    int min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    Console.WriteLine();
    Console.Write("Максимальное число в массиве равно "); Console.WriteLine(max);
    Console.Write("Минимальное число в массиве равно "); Console.WriteLine(min);
}