namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        const int start = 2;
        const int count = 120;
        
        var numbers = Enumerable.Range(start, count).OrderBy(number => number).ToList();
        numbers.Remove(1);
        
        int counter = 0;
        while (true)
        {
            int numbersCountBeforeRemove = numbers.Count;
            var nextNumber = numbers[counter++];
            numbers.RemoveAll(number => number % nextNumber == 0 && number != nextNumber);
            if (numbers.Count == numbersCountBeforeRemove)
            {
                break;
            }
        }

        var output = string.Join(",", numbers);
        Console.WriteLine(output);
        Console.ReadLine();
    }
}