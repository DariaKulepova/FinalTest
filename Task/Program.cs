using System;


string[] array1 = new string[] { "WowWow", "s2", "New", "Moscow", "5" };
string[] array2 = new string[array1.Length];

PrintArray(array1);
SelectionSort(array1, array2);
PrintArray(array2);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
 PrintArray(array1);




void SelectionSort(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;

        }
    }
    Console.WriteLine(" ", array2);
}

