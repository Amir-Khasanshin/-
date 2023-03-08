// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

int digit = M;

if (M > N) 
{
  M = N; 
  N = digit;
}

PrintSumm(M, N, digit=0);

  void PrintSumm(int M, int N, int sum)
{
  sum = sum + N;
  if (N <= M)
  {
    Console.Write($"Сумма элементов = {sum}");
    return;
  }
  PrintSumm(M, N - 1, sum);
}      