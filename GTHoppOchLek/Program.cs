namespace GTHoppOchLek;

internal class Program
{
    static string? gin;
    static List<string> ginSorter = new List<string>()
    {
        "Hernö",
        "Tanqueray",
        "Gibson",
        "Bombay Sapphire",
        "Skagerak",
        "Klocktornet",
        "Gordons",
        "Hendricks",
        
    };

    static void Main(string[] args)
    {
        Console.WriteLine("Hejsan allihopa!");
        Console.WriteLine("Viktor här!");
        Console.WriteLine("Viktors branch!");
        Console.WriteLine("Anders här!");
        Console.WriteLine("Anders Branch");
        GinOchTonic();
        GinOchLek();
        

        Console.WriteLine("Samis branch");


        Console.WriteLine("Pull = hämta, Push = skicka in, fetch = 'kolla om det finns något att hämta'");
    }
    static string GinOchTonic()
    {
        Console.WriteLine("Vilken är den bästa gin sorten?");        
        return gin = Console.ReadLine();
    }
    static void GinOchLek()
    {
        foreach (var g in ginSorter)
            Console.WriteLine(g);
    }
}
