using System.Data;

namespace Task1;

class Program
{
    static async Task Main(string[] args)
    {
        const string separator = ",";
        const string inputFilePath = "input.txt";
        const string outputFilePath = "output.txt";
        
        var input = await File.ReadAllTextAsync(inputFilePath);
        var evenNumbers = input.Trim()
            .Split(separator)
            .Select(number => int.Parse(number.Trim()))
            .Where(number => number % 2 == 0)
            .ToArray();
        
        var output = string.Join(separator, evenNumbers);
        await File.WriteAllTextAsync(outputFilePath, output);
        
        Console.WriteLine("Программа завершила работу");
        Console.ReadLine();
    }
}