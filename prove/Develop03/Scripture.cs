using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private string _text;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        InitializeWords();
    }

    private void InitializeWords()
    {
        string[] wordArray = _text.Split(' ');
        _words = new List<Word>();
        foreach (string wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine($"Scripture: {_reference.GetDisplayText()}\n");

        foreach (Word word in _words)
        {
            Console.Write(word.IsHidden ? "___ " : $"{word.Text} ");
        }

        Console.WriteLine("\n");
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int wordsToHide = random.Next(1, _words.Count / 2);

        for (int i = 0; i < wordsToHide; i++)
        {
            int randomIndex = random.Next(_words.Count);
            _words[randomIndex].Hide();
        }
    }

    public bool AreAllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }
        return true;
    }
}
