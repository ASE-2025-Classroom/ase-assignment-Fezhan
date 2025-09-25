namespace _1BasicDrawing;

using BOOSE;
class Program
{
    static void Main(string[] args)
    {
        var version = AboutBOOSE.Version;
        var info = AboutBOOSE.about();
        Console.WriteLine("=== BOOSE Information ===");
        Console.WriteLine($"Version: {version}");
        Console.WriteLine("About: ");
        Console.WriteLine(info);
        Console.WriteLine("=========================");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();


    }
}
