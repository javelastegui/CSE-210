using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    public class Journal
    {
        private List<Entry> entries;

        public Journal()
        {
            entries = new List<Entry>();
        }

        public void AddEntry(Entry entry)
        {
            entries.Add(entry);
        }

        // Displays all journal entries to the console.
        public void DisplayEntries()
        {
            if (entries.Count == 0)
            {
                Console.WriteLine("Journal is empty.");
            }
            else
            {
                foreach (Entry entry in entries)
                {
                    Console.WriteLine(entry);
                }
            }
        }

        // Saves the journal entries to a CSV file.
        // The file includes a header row and each field is escaped correctly.
        public void SaveToFile(string filename)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    // Write header row (optional but useful for Excel).
                    writer.WriteLine("Date,Prompt,Response");
                    foreach (Entry entry in entries)
                    {
                        writer.WriteLine(entry.ToCsvString());
                    }
                }
                Console.WriteLine("Journal saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving file: " + ex.Message);
            }
        }

        // Loads journal entries from a CSV file.
        // The first line is assumed to be a header row.
        public void LoadFromFile(string filename)
        {
            try
            {
                List<Entry> loadedEntries = new List<Entry>();
                using (StreamReader reader = new StreamReader(filename))
                {
                    // Read and ignore the header row.
                    string header = reader.ReadLine();
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Entry entry = Entry.FromCsvString(line);
                        if (entry != null)
                        {
                            loadedEntries.Add(entry);
                        }
                    }
                }
                entries = loadedEntries;
                Console.WriteLine("Journal loaded successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading file: " + ex.Message);
            }
        }
    }
}
