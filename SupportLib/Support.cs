namespace SupportLib;

public class Support
{
    public void Separator(ConsoleColor color, char sep = '-')
    {
        Console.ForegroundColor = color;

        int initialTopPos = Console.CursorTop;
        int width = Console.WindowWidth;
        while(Console.CursorLeft <= width && Console.CursorTop == initialTopPos)
        {

        }
    }
}
