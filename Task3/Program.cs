/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int[,] InitMatrix()
{
    int[,] array = new int[2,2];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }

    return array;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }

        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MultiplicationMatrix(int[,] firstMartrix, int[,] secondMartrix)
{
    int[,] resultMatrix = new int[2,2];
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int multiplication = 1;
      multiplication = firstMartrix[i,j] * secondMartrix[i,j];
      resultMatrix[i,j] = multiplication;
    }
  }
  return resultMatrix;
}


int[,] array1 = InitMatrix();
PrintMatrix(array1);
int[,] array2 = InitMatrix();
PrintMatrix(array2);
int[,] result = MultiplicationMatrix(array1, array2);
PrintMatrix(result);


