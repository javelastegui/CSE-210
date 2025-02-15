using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    public class Scripture
    {
    public Reference Reference { get; private set; }
    private List<Word> Words;

    public Scripture(Reference reference, string text)
    {
      Reference = reference;

      Words = text.Split(' ')
                  .Select(word => new Word(word))
                  .ToList();
    }

    public string GetDisplayText()
    {
      return string.Join(" ", Words.Select(w => w.ToString()));
    }

    public void HideWords(int count)
    {
      Random rand = new Random();

      var notHiddenWords = Words.Where(w => !w.IsHidden).ToList();

      int wordsToHide = Math.Min(count, notHiddenWords.Count);

      for (int i = 0; i < wordsToHide; i++)
      {
        int index = rand.Next(notHiddenWords.Count);
        Word wordToHide = notHiddenWords[index];
        wordToHide.Hide();

        notHiddenWords.RemoveAt(index);
      }
    }

    public bool IsCompletelyHidden()
    {
      return Words.All(w => w.IsHidden);
    }
  }
}
