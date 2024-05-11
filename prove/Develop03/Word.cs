using System;

public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string text)
    {
        _word = text;
        _isHidden = false;

    }

    public string getWord()
    {
        return _word;
    }

    public bool getIsHidden()
    {
        return _isHidden;
    }

    public void setWord(string text)
    {
        _word = text;
    }

    public void setIsHidden()
    {
        _isHidden = true;
    }

}