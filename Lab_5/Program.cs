/*
 * 23. Дана матриця розміру m * n.
 * 1) Перед;
 * 2) після першим (останнім)
 * стовпчиком, що містить тільки додатні елементи, додати стовпчик,
 * що складається з одиниць.
 */

Console.OutputEncoding = System.Text.Encoding.Unicode;

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }

}

int[] GetNumberOfDuplicates(int[,] array)
{
    int[] duplicates = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        var dict = new Dictionary<int, int>();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            dict.TryGetValue(array[i, j], out int count);
            dict[array[i, j]] = count + 1;
        
        int highest = 0;
        foreach (var pair in dict)
            if (pair.Value > highest) highest = pair.Value;
        duplicates[i] = highest;
    }
    return duplicates;
}

int GetFirstIndexOfMaxValue(int[] array)
{
    int index = 0, value = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > value)
        {
            index = i;
            value = array[i];
        }
    }
    return index;
}

int GetLastIndexOfMaxValue(int[] array)
{
    int index = 0, value = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= value)
        {
            index = i;
            value = array[i];
        }
    }
    return index;
}

Console.WriteLine("Enter amount of lines: ");
int M = Convert.ToInt32(Console.ReadLine());
if (M <= 0)
{
    Console.WriteLine("Amount must be bigger then zero!");
    return 1;
}
Console.WriteLine("Enter amount of  columns: ");

int N = Convert.ToInt32(Console.ReadLine());
if (N <= 0)
{
    Console.WriteLine("Amount must be bigger then zero!");
    return 1;
}

int[,] array = new int[M, N];

for (int i = 0; i < M; i++)
{
    Console.WriteLine($"Рядок {i + 1}");
    for (int j = 0; j < N; j++)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        array[i, j] = number;
    }
}

Console.WriteLine("Matrix looks like this: ");
PrintArray(array);

int[] arr = GetNumberOfDuplicates(array);

int first = GetFirstIndexOfMaxValue(arr);
if (first == M - 1)
{
    Console.WriteLine($"First: {first + 1}");
    Console.WriteLine($"Second: {first + 1}");
    return 0;
}

int temp = arr[first];
    arr[first] = 1;
int second = GetLastIndexOfMaxValue(arr);

if (arr[second] != temp)
{
    Console.WriteLine($"Перший: {first + 1}");
    Console.WriteLine($"Другий: {first + 1}");
}
else
{
    Console.WriteLine($"Перший: {first + 1}");
    Console.WriteLine($"Другий: {second + 1}");
}
return 0;