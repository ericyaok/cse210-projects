using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();



    public Scripture(string scripture, Reference reference)
    {
        _reference = reference;
        _words = ConvertTextToWord(scripture);

    }

    public string DisplayScripture()
    {
        string reference = _reference.DisplayReference();
        string scriptureText = " ";

        foreach (Word word in _words)
        {
            string text;
            if (word.getIsHidden())
            {
                text = "_";
            }
            else
            {
                text = word.getWord();
            }
            scriptureText = scriptureText + text + " ";
        }

        return reference + " " + scriptureText;
    }

    private List<Word> ConvertTextToWord(string sentence)
    {
        string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> wordList = new List<string>(words);
        List<Word> scriptureWords = new List<Word>();
        foreach (string word in wordList)
        {
            Word newWord = new Word(word);
            scriptureWords.Add(newWord);

        }

        return scriptureWords;

    }

    public void HideWordsRandomly()
    {
        Random rng = new Random();
        int listLength = _words.Count;

        int numChanges = rng.Next(1, listLength + 1);

        for (int i = 0; i < numChanges; i++)
        {
            int index = rng.Next(0, listLength);
            _words[index].setIsHidden();
        }
    }

    public bool IsAllHidden()
    {
        foreach (var word in _words)
        {
            if (word.getIsHidden() == false)
            {
                return false; 
            }
        }
        return true; 
    }

}