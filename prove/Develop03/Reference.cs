using System;

namespace ScriptureMemorizer
{
  public class Reference
  {
    public string Book { get; private set; }
    public int Chapter { get; private set; }
    public int StartVerse { get; private set; }
    public int? EndVerse { get; private set; }

    public Reference(string book, int chapter, int verse)
    {
      Book = book;
      Chapter = chapter;
      StartVerse = verse;
      EndVerse = null;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
      Book = book;
      Chapter = chapter;
      StartVerse = startVerse;
      EndVerse = endVerse;
    }

    public override string ToString()
    {
      if (EndVerse.HasValue && EndVerse.Value != StartVerse)
      {
        return $"{Book} {Chapter}:{StartVerse}-{EndVerse.Value}";
      }
      else
      {
        return $"{Book} {Chapter}:{StartVerse}";
      }
    }
  }
}
