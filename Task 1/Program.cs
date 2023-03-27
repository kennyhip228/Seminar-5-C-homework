// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    if (array[i]%2 == 0)
        count += 1;
}

Console.WriteLine($"Наш массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Количество чётных чисел в массиве: {count}");