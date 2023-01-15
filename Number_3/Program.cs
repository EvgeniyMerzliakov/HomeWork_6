// задача 2 HARD необязательная. Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). 
// Вывести на экран красивенько таблицей. 
// Найти минимальное число и его индекс, найти максимальное число и его индекс. Вывести эту информацию на экран.


void PrintArray(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            Console.Write($" {col[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            col[i, j] = new Random().Next(0, 100);
        }
    }
}

void SearchingMaxMin(int[,] col)
{
    int max = col[0, 0];
    int min = col[0, 0];
    int x_max = 0;
    int y_max = 0;
    int x_min = 0;
    int y_min = 0;
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            if (col[i, j] > max) 
            {
                max = col[i, j];
                x_max = i;
                y_max = j;
            }
            else if (col[i, j] < min) 
            {
                min = col[i, j];
                x_min = i;
                y_min = j;
            }
        }
    }
    Console.WriteLine($"Минимальное число = {min}, его индекс по вертикали = {x_min} - по горизонтали = {y_min}");
    Console.WriteLine($"Максимальное число = {max}, его индекс по вертикали = {x_max} - по горизонтали = {y_max}");
}




Console.WriteLine("Введите размерность 1 массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размерность 2 массива");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);
SearchingMaxMin(matrix);