namespace USD2VND;
class Program
{
    static void Main(string[] args)
    {
        float rate = 23000f;
        Console.Write("Input amount of money(USD): ");
        float usd = float.Parse(Console.ReadLine());
        Console.WriteLine($"{usd} USD -> {usd * rate} VND");
    }
}
