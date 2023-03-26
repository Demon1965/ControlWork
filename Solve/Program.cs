

void ArrayCreateAndFillAndSorting(int n, int z)
{
    int[] array1 = new int[n];
    for (int i = 0; i < n; i++) array1[i] = Random.Shared.Next(1, 11);
    Console.WriteLine($"[{String.Join(", ", array1)}]");
    string[] array2 = new string[n];
    for (int i = 0; i < n; i++)
    {
        if (array1[i] == 1) array2[i] = "one";
        if (array1[i] == 2) array2[i] = "two";
        if (array1[i] == 3) array2[i] = "three";
        if (array1[i] == 4) array2[i] = "four";
        if (array1[i] == 5) array2[i] = "five";
        if (array1[i] == 6) array2[i] = "six";
        if (array1[i] == 7) array2[i] = "seven";
        if (array1[i] == 8) array2[i] = "eight";
        if (array1[i] == 9) array2[i] = "nine";
        if (array1[i] == 10) array2[i] = "ten";
    }
    Console.WriteLine($"[{String.Join(", ", array2)}]");
    // return new string[n];
    int j = 0;
    string[] array3 = new string[n];
    for (int i = 0; i < n; i++)
    {
        if (Convert.ToInt32(array2[i].Length) <= z)
        {
            array3[j] = array2[i];
            j++;
        }
    }
    if (j == 0)
    {
        Console.WriteLine($"Where are no elements satisfying this condition!");
    }
    else
    {
        Console.WriteLine($"[{String.Join(", ", array3)}]");
    }
}

// void ArraySorting(string[] array2, int n, int z)       Отдельный метод сортировки не смог запустить в срок! Но версия рабочая
// {
//     int j = 0;
//     string[] array3 = new string[n];
//     for (int i = 0; i < n; i++)
//     {
//         if (Convert.ToInt32(array2[i].Length) <= z)
//         {
//             array3[j] = array2[i];
//             j++;
//         }
//     }
//     if (j == 0)
//     {
//         Console.WriteLine($"Where are no elements satisfying this condition!");
//     }
//     else
//     {
//         Console.WriteLine($"[{String.Join(", ", array3)}]");
//     }
// }

Console.WriteLine("Insert the array's length: ");
int n = Convert.ToInt32(Console.ReadLine());
int z = 3;
ArrayCreateAndFillAndSorting(n, z);
// ArraySorting(n, z);  Отдельный метод сортировки не смог запустить в срок! Но версия рабочая
