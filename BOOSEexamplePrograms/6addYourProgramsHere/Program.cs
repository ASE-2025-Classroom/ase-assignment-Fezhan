namespace _1BasicDrawing;

using BOOSE;
class Program
{

    public interface IStoredProgram
    {
        
    }
    static void Main(string[] args)
    {
        string code = File.ReadAllText("../1BasicDrawing/1restrictedDrawing.boose");
        Console.WriteLine(code);
    
    }


    }


