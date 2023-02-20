
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int[] array = {12,27,83,44,52,16,75,98,93,};
int result = Max(
    Max(array[0],array[1],array[2]),
    Max(array[3],array[4],array[5]),
    Max(array[6],array[7],array[8]));
// array[0] = 121;
Console.WriteLine(result);

// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 23;
// int c2 = 33;
// int a3 = 13;
// int b3 = 24;
// int c3 = 33;

// int max = Max(Max(a1,b1,c1),Max(a2,b2,c2),Max(a3,b3,c3));