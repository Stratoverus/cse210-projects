using System.Collections.Generic;
class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new();

    public int CountComments()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length(seconds): {_length}");
        foreach (Comment i in _comments)
        {
            i.Display();
        }
        Console.WriteLine("");
    }
}