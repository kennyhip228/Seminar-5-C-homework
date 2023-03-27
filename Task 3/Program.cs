// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine());
double[] array = new double[n];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(new Random().NextDouble() * 100, 2);
}

Console.WriteLine($"Наш массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Разница между минимальным и максимальным элементов: {array.Max() - array.Min()}");