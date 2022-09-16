int[] array = new int[20];

CreateMas(array);
PrintMas(array);
GetCountPos(array);

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

void GetCountPos(int [] array)
{
    int count=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0)
        {
            count +=1;
        }
    }
    Console.WriteLine();
    Console.Write("Количество четных чисел в массиве ");
    Console.WriteLine(count);
}