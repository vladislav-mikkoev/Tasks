namespace Task4;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = [5, 4, 3, 2, 1, 2, 3, 4, 5];
        bool isSymmetrically = true;
        for (int start = 0, end = numbers.Length - 1; start <= end; start++, end--)
        {
            if (numbers[start] != numbers[end])
            {
                isSymmetrically = false;
                break;
            }
        }

        var output = isSymmetrically
            ? "симметрично"
            : "асимметрично";
        
        Console.WriteLine(output);
        Console.ReadLine();
    }
}