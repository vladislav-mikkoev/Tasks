namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        string inputFirst = "word";
        string inputSecond = "rowd";
        bool isAnagram = false;

        if (!string.IsNullOrWhiteSpace(inputFirst) && !string.IsNullOrWhiteSpace(inputSecond))
        {
            if (inputFirst.Length == inputSecond.Length)
            {
                isAnagram = inputFirst.OrderBy(@char => @char)
                    .Zip(inputSecond.OrderBy(@char => @char))
                    .All(item => item.First == item.Second);
            }
        }

        var output = isAnagram
            ? "является анаграммой"
            : "не является анаграммой";
        
        Console.WriteLine(output);
        Console.ReadLine();
    }
}