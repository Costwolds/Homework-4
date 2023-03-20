//29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int Prompt()
{
    Console.WriteLine("Введите количество элементов массива");
    int a = int.Parse(Console.ReadLine());
    return a;
}

int size = Prompt();

int[] CreatArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 99);
    }

    return array;
}

int[] array = CreatArray(size);
Console.WriteLine(String.Join(", ", array));