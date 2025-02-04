using System;
using System.Text;

namespace JournalApp
{
  public class Entry
  {
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }

    // Helper method to escape a CSV field.
    // If the field contains a comma, double quote, or newline,
    private string EscapeCsv(string field)
    {
        if (field.Contains(",") || field.Contains("\"") || field.Contains("\n"))
        {
            field = field.Replace("\"", "\"\"");
            return $"\"{field}\"";
        }
        else
        {
            return field;
        }
    }

    // Returns a CSV formatted string for this entry.
    public string ToCsvString()
    {
        return $"{EscapeCsv(Date)},{EscapeCsv(Prompt)},{EscapeCsv(Response)}";
    }

    // Parses a CSV-formatted line into an Entry object.
    // This simple parser handles quoted fields with commas and double quotes.
    public static Entry FromCsvString(string csvLine)
    {
        var fields = new System.Collections.Generic.List<string>();
        bool inQuotes = false;
        StringBuilder field = new StringBuilder();

        for (int i = 0; i < csvLine.Length; i++)
        {
            char c = csvLine[i];
            if (c == '\"')
            {
                // If inside quotes and next char is also a quote, add a literal quote.
                if (inQuotes && i + 1 < csvLine.Length && csvLine[i + 1] == '\"')
                {
                    field.Append('\"');
                    i++; // Skip the next quote.
                }
                else
                {
                    inQuotes = !inQuotes;
                }
            }
            else if (c == ',' && !inQuotes)
            {
                fields.Add(field.ToString());
                field.Clear();
            }
            else
            {
                field.Append(c);
            }
        }
        fields.Add(field.ToString());

        if (fields.Count >= 3)
        {
            return new Entry(fields[0], fields[1], fields[2]);
        }
        return null;
    }
  }
}

