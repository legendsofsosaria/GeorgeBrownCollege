using System;

namespace Week10
{
	internal class Program
	{
		static double FindAvg(double[] marks)
		{
			double sum = 0;

			foreach (var mark in marks)
			{
				sum += mark;
			}
			return sum / marks.Length;
		}
		static void Main(string[] args)
		{
			/* Parallel arrays : Multiple mutually exclusive arrays
			which are the same size and each item in the array has a 
			corresponding item in the other array */
			int[,] numberM = new int[3, 5];
			int[,] numberM2 = { { 34, 45 }, { 55, 66 }, { 7, 7 } };

			// Jagged arrays!
			int[][] numberJagged = new int[4][];
			numberJagged[0] = new int[5];
			numberJagged[1] = new int[2];

			int[][] numberJagged2 = { [35, 45, 87], [55, 66], [67] };

			Console.WriteLine(numberM.Length);
			Console.WriteLine(numberM2.Length);
			Console.WriteLine("First Dimension Length {0}", numberM.GetLength(0)); // Output : 3
			Console.WriteLine("Second Dimension Length {0}", numberM.GetLength(1)); // Output : 5

			foreach (var item in numberM2)
			{
				Console.WriteLine(item);
				Console.WriteLine("----------------------------------");
			}

			for (int i = 0; i < numberM2.GetLength(0); i++)
			{
				for (int j = 0; j < numberM2.GetLength(1); j++)
				{
					Console.WriteLine($"numberJagged [{i},{j}] = {numberM2[i, j]}");
				}
			}

			Console.WriteLine(numberJagged.Length);
			Console.WriteLine(numberJagged2.Length); // length of first dimension!

			Console.WriteLine("----------------------------------------------");

			for (int i = 0; i < numberJagged2.Length; i++)
			{
				for (int j = 0; j < numberJagged2[i].Length; j++)
				{
					Console.WriteLine($"numberJagged [{i},{j}] = {numberJagged2[i][j]}");
				}
			}

			/*int[] stdID = { 100100100, 200200200, 300300300  };
			string[] stdName = { "Hesam", "Tony", "Robert" };
			double[,] stdMarks = { {89 ,78 ,74 ,65, 80, 90, 65 }, // Matrix
			{78, 85, 45, 92, 74, 54, 65 },
			{67, 89, 66, 75, 45, 66, 77 } };*/

			string[] context = { "Lab Test 1", "Lab Test 2", "Quizzes", "Assignment 1", "Assignment 2", "Midterm", "Final" };
			float[] weight = { 0.1f, 0.1f, 0.08f, 0.1f, 0.1f, 0.2f, 0.25f, 0.07f };

			Console.WriteLine("\nHow many students do you have? ");
			int numStd = Convert.ToInt32(Console.ReadLine());

			int[] stdID = new int[numStd];
			string[] stdName = new string[numStd];
			double[,] stdMarks = new double[numStd, context.Length];

			for (int i = 0; i < numStd; i++)
			{
				Console.WriteLine($"Enter the Student ID for student # {i + 1} :");
				stdID[i] = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine($"Enter the Student Name for student # {i + 1} : ");
				stdName[i] = Console.ReadLine();

				for (int j = 0; j < context.Length; j++)
				{
					Console.WriteLine($"Enter the mark of {context[j]} for student # {i + 1} :");
					stdMarks[i, j] = Convert.ToDouble(Console.ReadLine());
				}
			}

			/* Find the average for the entire class marks (totals all the marks from all of the students then divides by number of students) */
			double finalMark, finalMarkAdd = 0;

			for (int i = 0; i < stdMarks.GetLength(0); i++) // pick student
			{
				finalMark = 0;
				Console.WriteLine($"Student ID: {stdID[i]}, Name: {stdName[i]}");

				for (int j = 0; j < stdMarks.GetLength(1); j++) // pick marks for each students
				{
					Console.WriteLine($"\t {context[j]} = {stdMarks[i, j]}");

					finalMark += weight[j] * stdMarks[i, j];
				}
				Console.WriteLine("__________________________________________");

				Console.WriteLine($"\tFINAL MARK : {finalMark:F2}");
				finalMarkAdd += finalMark;

				Console.WriteLine("=================================================");
			}
			Console.WriteLine($"Avg of the class final marks is : {finalMarkAdd / stdName.Length:F2}");
			Console.WriteLine("__________________________________________");

			/* Find the average of each content for the class. What was average of class lab tests, final, midterm, etc
			* Hint: process separately */
			double[] contentTotals = new double[context.Length]; // Array to store the sums for each context

			for (int j = 0; j < context.Length; j++) // Loop through each context 
			{
				contentTotals[j] = 0;

				for (int i = 0; i < stdMarks.GetLength(0); i++) // Loop through each student
				{
					contentTotals[j] += stdMarks[i, j]; // Sum the grades for the context
				}

				Console.WriteLine($"Avg of the {context[j]} is: {contentTotals[j] / stdName.Length:F2}");
				Console.WriteLine("__________________________________________");
			}
		}
	}
}
