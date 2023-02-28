// for

// for(int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?


// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
// +"ежели бы вас послали вместо нашего милого Винценгероде,"
// +"вы бы взяли приступом согласие прусского короля."
// +"Вы так красноречивы. Вы дадите мне чаю?";

// string Replace(string text, char oldValue, char newValue )
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);

// string newText = Replace(text, 'к', 'К');
// Console.WriteLine(newText);

int[] arr = {1,4,5,3,9,4,6,5,4,8,7,8,5,2,};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// PrintArray(arr);

void SelectionSort(int[] array)
{
for (int i = 0; i < array.Length - 1; i++)
{
    int minPosition = i;

    for (int j = i + 1; j < array.Length; j++)
    {
        if(array[j] < array[minPosition]) minPosition = j;
    }

    int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;

}
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);