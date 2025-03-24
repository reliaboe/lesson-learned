using Core;

namespace Demo;

class Program
{
    static async Task Main(string[] args)
    {
        var a = new TestDemo();

        var numbers = await a.GetNumbers();

        


        Console.WriteLine("Register a person....");

        Console.Write("Enter firstname: ");
        var firstName = Console.ReadLine();

        Console.Write("Enter lastname: ");
        var lastName = Console.ReadLine();

        Console.Write("Enter birth format('YYYY-MM-DD'): ");
        var birth = Console.ReadLine();

        var s = new Person
        {
            Id = Guid.NewGuid().ToString(),
            Name = $"{firstName} {lastName}",
            Birth = DateTime.TryParse(birth, out var b) ? b : null
        };

        s.GetInitials();

        Console.WriteLine("------------------------------------------");
        Console.WriteLine(s);
        Console.WriteLine("------------------------------------------");

        _ = Console.ReadLine();
    }
}
