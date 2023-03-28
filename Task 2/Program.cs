// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
}

for (int i = 1; i < array.Length; i = i + 2)
    count = count + array[i];

Console.WriteLine($"Наш массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {count}");
