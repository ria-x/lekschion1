﻿// double CalculateFormula(int a, int b, int c, int d)
// {
//     double numenator = a * b;
//     int denumenator = c + d;
//     double result = numenator / denumenator;
//     return result;
// }
// CalculateFormula(1, 2, 3, 4);

// double result = CalculateFormula(1, 2, 3, 4);
// Console.WriteLine(result);


// void PrintSquares(int limit)
// {
//     int i = 1;
//     while (i < limit)
//     {
//         Console.Write($"{i * i} ");
//         i++;
//     }
// }
// PrintSquares(5);
// PrintSquares(10);
// PrintSquares(15);

void ZeroEvenElements(int[] arr)
{


    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}
void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.WriteLine($"{e} ");
    }
}
int[] array = { 1, 2, 3, 4, 5 };
ZeroEvenElements(array);
PrintArray(array);