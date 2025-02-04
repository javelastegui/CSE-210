using System;

namespace JournalApp
{
    public class Menu
    {
        public void Display()
        {
            Console.WriteLine("\nJournal Program!");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a CSV file");
            Console.WriteLine("4. Load the journal from a CSV file");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option 1-5: ");
        }
    }
}
