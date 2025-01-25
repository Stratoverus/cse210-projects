class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

//Making it simple now. I was doing too much before. It was redundant. No need to check if I'm already calling it.
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

//I think this will work: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator Keeping this here for reference.
    public string GetDisplayText()
    {
        return _isHidden ? "_":_text;
    }
}