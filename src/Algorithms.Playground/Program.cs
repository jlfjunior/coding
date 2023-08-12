// See https://aka.ms/new-console-template for more information

using Algorithms.Playground.Extensions;
using Algorithms.Playground.Sorting;

var numbers = new int[] { 2, 1, 4, 5, 6 };

Console.WriteLine(numbers.PrintToString());
Console.WriteLine("Starting sorting data...");

InsertionSorting.Sorting(numbers);

Console.WriteLine(numbers.PrintToString());