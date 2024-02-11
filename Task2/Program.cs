// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int evenCount = 0;
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        if (array[i] % 2 == 0)
    {
        evenCount = evenCount + 1;
    }
    }
    return array;
}

Console.Write("Vvedinte razmer massiva: ");
int N = Convert.ToInt32(Console.ReadLine());
int size = N;
int[] res = CreateArray(N);
Console.WriteLine($"Massiv: [ {string.Join("; ", res)} ]");
Console.WriteLine($"Kolichestvo chetnih chisel: {evenCount}");
