﻿Console.Clear();
string[] ArrayStrings = new string[] { };
Console.Write("Введите количество элементов массива - строк:");
int n = int.Parse(Console.ReadLine());
ArrayStrings = new string[n];
for (int i = 0; i < ArrayStrings.Length; i++)
{
    Console.Write($" Введите {i + 1} строку: ");
    ArrayStrings[i] = Console.ReadLine();
}
Console.WriteLine();
Console.WriteLine("массив введенных данных:");
Console.WriteLine($"{PrintArray(ArrayStrings)}");
Console.WriteLine();

int length = 3; 

int CheckArray(string[] array, int length)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= length) result++;
    }
    return result;
}

int numbers = CheckArray(ArrayStrings, length); 

string[] newArrayStrings = new string[numbers]; 
NewArray(ArrayStrings, newArrayStrings, length);


void NewArray(string[] oldArray, string[] newArray, int lengthLimit)
{
    int temp = 0;
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= lengthLimit)
        {
            newArray[temp] = oldArray[i];
            temp++;
        }
    }
}