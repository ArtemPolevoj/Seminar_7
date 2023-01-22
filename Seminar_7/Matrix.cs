using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_7
{
	internal class Matrix
	{
		public static int[,] GetMatrix()
		{
			int rowNumber = Value.getInt("Введите количество строк массива.");
			if (rowNumber <= 0)
			{
				Console.WriteLine("Количество строк не может быть меньше и равно нулю.");
				rowNumber = Value.getInt("Введите количество строк массива");
			}

			int columnsNumber = Value.getInt("Введите количество столбцов массива.");
			if (columnsNumber <= 0)
			{
				Console.WriteLine("Количество столбцов не может быть меньше и равно нулю.");
				columnsNumber = Value.getInt("Введите количество столбцов массива");
			}
			int[,] matrix = new int[rowNumber, columnsNumber];

			return matrix;
		}

		public static int[,] FillMatrix(int[,] matrix)
		{
			Random rnd = new Random();
			int minValue = Value.getInt("Введите минимальное значение массива");
			int mахValue = Value.getInt("Введите максимальное значение массива");
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					matrix[i, j] = rnd.Next(minValue, mахValue);
				}
			}
			return matrix;
		}

		public static void GetValueIndex(int[,] matrix)
		{
			int InputI = Value.getInt("Введите первый индекс массива");
			int InputJ = Value.getInt("Введите второй индекс массива");
			if (matrix.GetLength(0) < InputI || matrix.GetLength(1) < InputJ)
			{
				Console.WriteLine("Нет такого элемента");
			}
			Console.WriteLine($"Значение массива - {matrix[InputI, InputJ]}");
		}

		public static void GetAverageColumns(int[,] matrix)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
			{
				double sum = 0;
				
				for (int i = 0; i < matrix.GetLength(0); i++)
				{
					sum += matrix[i, j];
				}
				double average = Math.Round(sum / matrix.GetLength(0), 2);
				Console.Write($"Среднеарифметическое столбца {j + 1} = {average}\n");
			}
			Console.WriteLine();
		}

		public static void Print(int[,] matrix)
		{
			Console.WriteLine("Полученный массив:");
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write(matrix[i, j]);
				}
				Console.WriteLine();
			}
		}
	}
}
