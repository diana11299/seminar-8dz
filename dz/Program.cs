//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*

int [,] CreateRandom2dArray()
{
    Console.Write("Imput a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Imput a quantity of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Imput a quantity of min: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Imput a quantity of max: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[ rows, colums]; //память под двумерный массив

    for(int i = 0; i < rows; i ++)
        for(int j = 0; j < colums; j ++)
            array[i,j] = new Random().Next(min, max +1);
    return array;
}

void Show2dArray(int[,] array) // метод вывода двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for(int j = 0; j < array.GetLength(1) ; j ++)
            Console.Write( array [i,j] + " ");

        Console.WriteLine();
    }
}

int[,] ChangeRowsToColums(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            int temp=array[i,j];
            array[i,j]=array[j,i];
            array[j,i]=temp;

        

        }
    }
    return array;
}

int[,] myArray =  CreateRandom2dArray ();
Show2dArray(myArray);
Console.WriteLine();
ChangeRowsToColums(myArray);
Show2dArray(myArray);
*/


//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*

int [,] CreateRandom2dArray()
{
    Console.Write("Imput a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Imput a quantity of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Imput a quantity of min: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Imput a quantity of max: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[ rows, colums]; //память под двумерный массив

    for(int i = 0; i < rows; i ++)
        for(int j = 0; j < colums; j ++)
            array[i,j] = new Random().Next(min, max +1);
    return array;
}

void Show2dArray(int[,] array) // метод вывода двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for(int j = 0; j < array.GetLength(1) ; j ++)
            Console.Write( array [i,j] + " ");

        Console.WriteLine();
    }
}

void SumLine(int [,] array)
{
    int result=0;
    int sumLine=0;
    int minSum=0;
    for(int i = 0; i < array.GetLength(0); i ++)
    {
        for(int j = 0; j < array.GetLength(1); j ++)
            sumLine+=array[i,j];
            if(sumLine < minSum || minSum == 0)
            {
                minSum=sumLine;
                result = i + 1;
            }
            sumLine=0;
    }
    Console.WriteLine($"Строка c наименьшей суммой элементов: {result}");
}

int[,] myArray =  CreateRandom2dArray ();
Show2dArray(myArray);
Console.WriteLine();
SumLine(myArray);
*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*

void CreateRandom2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Imput a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput a quantity of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, colums];
int[,] secondArray = new int[rows, colums];
int[,] resultArray = new int[rows, colums];
CreateRandom2dArray(array);
Show2dArray(array);

Console.WriteLine();

CreateRandom2dArray(secondArray);
Show2dArray(secondArray);

Console.WriteLine();
if (array.GetLength(0) != secondArray.GetLength(1))
{
 Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}

Show2dArray(resultArray);
*/


//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*
int n = 4;
int[,] Matrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= Matrix.GetLength(0) * Matrix.GetLength(1))
{
  Matrix[i, j] = temp;
  temp++;
    if (i <= j + 1 && i + j < Matrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= Matrix.GetLength(0) - 1)
             i++;
            else if (i >= j && i + j > Matrix.GetLength(1) - 1)
                j--;
                else
                    i--;
}

Show2dArray(Matrix);

void Show2dArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10<= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
*/