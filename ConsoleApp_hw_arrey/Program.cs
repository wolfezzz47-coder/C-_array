using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("Hello, World! This is an array.");
Console.Write("Введіть кількість елементів масиву: ");
int count = int.Parse(Console.ReadLine()!);
int[] arr = new int[count];
Random rnd = new Random();

for (int i = 0; i < count; i++)
{
    arr[i] = rnd.Next(0, 101);
}

Console.WriteLine("\nМасив до сортування (for): ");
for(int i =0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();

Console.WriteLine("\nМасив до сортування (while): ");
int k = 0;
while (k < arr.Length)
{
    Console.Write(arr[k] + " ");
    k++;
}
Console.WriteLine();

Console.WriteLine("\nМасив до сортування (foreach): ");
foreach(int item in arr)
{
    Console.Write(item + " ");
}
Console.WriteLine();

// Сортування масиву за зростанням (Bubble Sort)

for (int i = 0; i < arr.Length - 1; i++)
{
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[i] > arr[j])
        {
            // Обмін елементів
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}

Console.WriteLine("\nМасив після сортування (for):");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();

Console.WriteLine("\nМасив після сортування (while):");
k = 0;
while (k < arr.Length)
{
    Console.Write(arr[k] + " ");
    k++;
}
Console.WriteLine();

Console.WriteLine("\nМасив після сортування (foreach):");
foreach (int item in arr)
{
    Console.Write(item + " ");
}
Console.WriteLine();