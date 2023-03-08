// Задайте значение N.
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

PrintNomberToN(N);

void PrintNomberToN(int N)
{
    if (N < 1) return;
    Console.Write(N + " ");
    PrintNomberToN(N - 1);

}