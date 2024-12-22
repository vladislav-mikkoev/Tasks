namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        const string input =
            """
            In our fast-paced, always-on world, it's easy to overlook the importance of sleep
            "However, the truth is, a quality sleep regimen is essential for our overall health and well-being
            "Like diet and exercise, a good night's sleep is a critical pillar of a healthy lifestyle.
            """;

        var hit = input.Where(char.IsLetter)
            .GroupBy(char.ToLower)
            .OrderBy(group => group.Key)
            .MaxBy(group => group.Count());

        Console.WriteLine($"Символ {hit!.Key}, количество {hit.Count()}");
        Console.ReadLine();
    }
}