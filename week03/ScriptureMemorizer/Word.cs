using System;
public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    //Hiding a word means that the word should be replace by underscores (_) 
    //and the number of underscores should match the number of letters in that word.
    public string GetDisplayText()
    {
        if (!_isHidden)
            return _text;

        string core = _text.TrimEnd('.', ',', ';', ':', '!', '?');
        string punct = _text.Substring(core.Length);
        return new string('_', core.Length) + punct;
    }
}