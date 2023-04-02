

string[] ArrayCreateAndFill(int n)
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
    return array2;
}

    void ArraySorting(string[] array2, int n, int z)
    {
        int count=0;
        string[] array3=new string[n];
        for(int i=0; i<n; i++)
        {
            if(Convert.ToInt32(array2[i].Length)>z)
            {
               count++;
            }
            else
            {
                array3[i-count]=array2[i];
            }
        }
            if (count == n)
        {
            Console.WriteLine($"Where are no elements satisfying this condition!");
        }
        else
        {
            Console.WriteLine($"[{String.Join(" , ", array3)}]");
        }
    }


Console.WriteLine("Please, Insert the array's length: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, Insert the length of array's elements for sorting: ");
int z = Convert.ToInt32(Console.ReadLine());
string[] array2=ArrayCreateAndFill(n);
ArraySorting(array2, n, z);
