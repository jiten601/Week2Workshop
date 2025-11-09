using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 9, 1, 3, 7 };

        Console.WriteLine("Original array: " + string.Join(", ", numbers));

        Array.Sort(numbers);
        Console.WriteLine("Sorted array: " + string.Join(", ", numbers));

        Array.Reverse(numbers);
        Console.WriteLine("Reversed array: " + string.Join(", ", numbers));

        Console.WriteLine("Array elements using for loop:");
        for (int index = 0; index < numbers.Length; index++)
        {
            Console.WriteLine($"Index {index}: {numbers[index]}");
        }

        int searchValue = 3;
        int position = Array.IndexOf(numbers, searchValue);
        Console.WriteLine($"Position of {searchValue} in array: {position}");
    }
}
