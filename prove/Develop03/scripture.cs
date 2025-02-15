using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the scripture text into words and store them
        string[] wordsArray = text.Split(' ');
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideWords()
    {
        Random random = new Random();
        int wordsToHide = Math.Max(1, _words.Count / 5); // Hide about 20% of words

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden()) return false;
        }
        return true;
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference.ToString());
        foreach (Word word in _words)
        {
            Console.Write(word.ToString() + " ");
        }
        Console.WriteLine("\n");
    }
}