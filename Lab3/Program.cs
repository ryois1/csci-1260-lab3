using ConsoleTables;
using Lab3;

public class Program
{
    public static void Main(string[] args)
    {
        var charactersController = new Characters();
        while (true)
        {
            DisplayMenu();
            int option = GetMenuOption();
            switch (option)
            {
                case 1:
                    DisplayCharacters(Character.Headers, charactersController.Sort());
                    break;
                case 2:
                    try
                    {
                        Console.Write("Please enter a game: ");
                        string game = Console.ReadLine();
                        DisplayCharacters(Character.Headers, charactersController.FilterByGame(game));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("There was a problem!");
                        Console.WriteLine(e);
                    }
                    break;
                case 3:
                    try
                    {
                        Console.Write("Please enter an alignment: ");
                        string alignment = Console.ReadLine();
                        DisplayCharacters(Character.Headers, charactersController.FilterByAlignment(alignment));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("There was a problem!");
                        Console.WriteLine(e);
                    }
                    break;
                default:
                    Console.WriteLine("Unknown Option!");
                    break;
            }
        }

    }
    static void DisplayCharacters(string[] headers, List<Character> rows)
    {
        ConsoleTable table = new ConsoleTable(headers);
        foreach (var row in rows)
        {
            table.AddRow(row._name, row._game, row._alignment);
        }
        table.Write();
        Console.WriteLine();
    }
    static void DisplayMenu()
    {
        string[] header = { "Option", "Number" };
        ConsoleTable table = new ConsoleTable(header);
        table.AddRow("Display all characters sorted alphanumerical", "1");
        table.AddRow("Display all characters a specific game", "2");
        table.AddRow("Display all characters a alignment", "3");
        table.Write();
        Console.WriteLine();
    }
    static int GetMenuOption()
    {
        Console.Write("Choose option: ");
        try
        {
            return int.Parse(Console.ReadLine());
        }
        catch
        {
            return -1;
        }

    }
}
