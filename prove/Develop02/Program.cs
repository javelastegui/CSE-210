using System;

namespace JournalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            PromptMan promptMan = new PromptMan();
            Menu menu = new Menu();
            bool exit = false;

            while (!exit)
            {
                menu.Display();
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        // Write a new entry.
                        string prompt = promptMan.GetRandomPrompt();
                        Console.WriteLine("\nPrompt: " + prompt);
                        Console.Write("Your response: ");
                        string response = Console.ReadLine();
                        string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
                        Entry entry = new Entry(currentDate, prompt, response);
                        journal.AddEntry(entry);
                        Console.WriteLine("Entry added.");
                        break;

                    case "2":
                        // Display the journal.
                        Console.WriteLine("\nDisplaying Journal Entries:");
                        journal.DisplayEntries();
                        break;

                    case "3":
                        // Save the journal to a CSV file.
                        Console.Write("Enter filename to save (include .csv extension): ");
                        string saveFilename = Console.ReadLine();
                        journal.SaveToFile(saveFilename);
                        break;

                    case "4":
                        // Load the journal from a CSV file.
                        Console.Write("Enter filename to load (include .csv extension): ");
                        string loadFilename = Console.ReadLine();
                        journal.LoadFromFile(loadFilename);
                        break;

                    case "5":
                        // Exit the program.
                        exit = true;
                        Console.WriteLine("Exiting program. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
