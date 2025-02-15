using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Reference reference = new Reference("John", 3, 16);
            string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
            Scripture scripture = new Scripture(reference, scriptureText);

            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture.Reference.ToString());
                Console.WriteLine();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();

                if (scripture.IsCompletelyHidden())
                {
                    Console.WriteLine("All words have been hidden. Press any key to exit.");
                    Console.ReadKey();
                    break;
                }

                Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
                string input = Console.ReadLine();
                if (input.Trim().ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    scripture.HideWords(3);
                }
            }
        }
    }
}
