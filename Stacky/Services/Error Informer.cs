using System.Drawing;

namespace Stacky.Services;

public static class ErrorInformer
{
    public static void Inform(string message, ConsoleColor color = ConsoleColor.Gray)
    {
        ConsoleColor default_color = Console.ForegroundColor;

        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ForegroundColor = default_color;
        Console.ReadKey();
    }
}