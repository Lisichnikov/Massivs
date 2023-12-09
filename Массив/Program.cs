// создаем основные переменные
int M = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());
int k = int.Parse(Console.ReadLine());
int[,] A = new int[M, N];

// заполнение массива
Random ran = new Random();
for (int i = 0; i < M; i++)
{
   for (int j = 0; j < N; j++)
   {
        A[i, j] = ran.Next(1, 15);
   }
}

// Вывод ответа
Console.WriteLine("Ответ на эту задачу: " + SumLine(A, M, N, k));

// Функция SumLine
int SumLine(int[,] A, int M, int N, int k)
{
   int bufer = 0;
   int[] s = new int[N];
   if (k > M || k > N)
   {
        return 0;
   }
   else
   {
       for (int i = k - 1; i <= k - 1; i++)
       {
            for (int j = 0; j < N; j++)
            {
                s[i] += A[i, j];
            }
            bufer = s[i];
       }
       return bufer;
   }
 }
