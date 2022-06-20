using System;


string[] array1 = new string[] { "WowWow", "s2", "New", "Moscow", "5" };
string[] array2 = new string[array1.Length];

PrintArray(array1);






void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
