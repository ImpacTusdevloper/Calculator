namespace SupportLib;

public static class Support
{
    public static void Separator(ConsoleColor color = ConsoleColor.Red, char sep = '-')
    {
        Console.ForegroundColor = color;
        Console.Write("\n \n");
        int initialTopPos = Console.CursorTop;
        int width = Console.WindowWidth;
        while(Console.CursorLeft < width && Console.CursorTop == initialTopPos)
            Console.Write(sep);
        
        Console.Write("\n \n");
        Console.ResetColor();
    }

    public static string? Input(string arg = "")
    {
        if(arg != "")
            Console.Write(arg);
        string? inp = Console.ReadLine();
        return inp;
    }
}
