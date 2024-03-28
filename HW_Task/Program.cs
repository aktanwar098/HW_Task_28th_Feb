using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Generic Collection (List) Demo");
        Console.WriteLine("1. Add Number");
        Console.WriteLine("2. Remove Number");
        Console.WriteLine("3. Display Numbers");
        Console.WriteLine("4. Exit");

        while (true)
        {
            try
            {
                Console.Write("\nEnter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNumber(numbers);
                        break;
                    case "2":
                        RemoveNumber(numbers);
                        break;
                    case "3":
                        DisplayNumbers(numbers);
                        break;
                    case "4":
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }

    static void AddNumber(List<int> numbers)
    {
        Console.Write("Enter a number to add: ");
        int num = int.Parse(Console.ReadLine());
        numbers.Add(num);
        Console.WriteLine($"Number {num} added successfully.");
    }

    static void RemoveNumber(List<int> numbers)
    {
        if (numbers.Count == 0)
        {
            throw new InvalidOperationException("The collection is empty. There are no numbers to remove.");
        }

        Console.Write("Enter the index of the number to remove: ");
        int index = int.Parse(Console.ReadLine());
        if (index >= 0 && index < numbers.Count)
        {
            int removedNumber = numbers[index];
            numbers.RemoveAt(index);
            Console.WriteLine($"Number {removedNumber} at index {index} removed successfully.");
        }
        else
        {
            throw new IndexOutOfRangeException("Invalid index. Please enter a valid index within the range of the collection.");
        }
    }

    static void DisplayNumbers(List<int> numbers)
    {
        if (numbers.Count == 0)
        {
            Console.WriteLine("The collection is empty.");
            return;
        }

        Console.WriteLine("Numbers in the collection:");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine($"[{i}] {numbers[i]}");
        }
    }
}
