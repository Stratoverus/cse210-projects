using System.Collections.Concurrent;
using System.Security.Cryptography;

class Reference
{
    private string _book = "Moroni";
    private int _chapter = 10;
    private int _verse = 4;
    private int _endVerse = 5;

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

    public string GetDisplayText()
    {
        return "";
    }
}