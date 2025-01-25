class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        if (_isHidden == true)
        {
            _text = "_";
        }
    }

    public void Show()
    {
        if (_isHidden == false)
        {
            
        }
    }

    public bool IsHidden()
    {
        if (_text == "_")
        {
            _isHidden = true;
        }
        else
        {
            _isHidden = false;
        }
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _text;
    }
}