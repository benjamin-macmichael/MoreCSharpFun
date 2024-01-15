using MoreCSharpFun;

internal class Program
{
    private static void Main(string[] args)
    {
        string uhh = "uhh";

        string test = "nother test";

        PrintStuff ps = new PrintStuff("PT");

        string name = "";

        System.Console.WriteLine("Please enter your name");
        name = System.Console.ReadLine();

        ps.PrintName(name);
    }

    private static void PrintName(string n)
    {
        System.Console.WriteLine("Hello, " + n + "!");
    }
}