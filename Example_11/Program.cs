﻿void FillArray(int [] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int [] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;

    }
}

int IndexOF(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position =  -1;

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int [10];

FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOF(array, 4);
Console.WriteLine(pos);


// int[] array = {21,52,4,44,15,76,57,4};

// int n = array.Length;
// int find = 4;

// int index = 0;

// while (index < n)
// {
//     if(array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     index++;
// }
