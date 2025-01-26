using System.Collections.Concurrent;
using System.Security.Cryptography;

class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

//Need to figure out how to get this to use one constructor vs the other when there are multiple verses. I think a simple if else should be sufficient and checking if there's any value in endVerse
    public string GetDisplayText()
    {
        if (_endVerse != 0)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }
}