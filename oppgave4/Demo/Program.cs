using Core;

namespace Demo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Register a person....");

        Console.Write("Enter firstname: ");
        var firstName = Console.ReadLine();

        Console.Write("Enter lastname: ");
        var lastName = Console.ReadLine();

        Console.Write("Enter birth format('YYYY-MM-DD'): ");
        var birth = Console.ReadLine();

        var p = new Person
        {
            Id = Guid.NewGuid().ToString(),
            Name = $"{firstName} {lastName}",
            Birth = DateTime.TryParse(birth, out var b) ? b : null
        };

        Console.WriteLine("------------------------------------------");
        Console.WriteLine(p);
        Console.WriteLine("------------------------------------------");

        _ = Console.ReadLine();
    }
}
