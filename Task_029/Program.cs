// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.Write("Введите число элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = GetRandomArray(size);
Console.WriteLine($"[{String.Join(", ", array)}]");
int [] GetRandomArray(int size)
{
    int [] result = new int [size];
       for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0, 100);
    }
    return result;
}

