// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

int[] CreateArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(10);
    }
    return arr;
}
Console.Write("Vvedinte razmer massiva: ");
int N = Convert.ToInt32(Console.ReadLine());
int size = N;
int[] res = CreateArray(N);
Console.WriteLine($"Massiv: [ {string.Join("; ", res)} ]");
int temp;
for (int i = 0; i < res.Length / 2; i++)
{
temp = res[i];
res[i] = res[res.Length - 1 - i];
res[res.Length - 1 - i] = temp;
}
Console.WriteLine($"Perevernutii Massiv: [ {string.Join("; ", res)} ]");