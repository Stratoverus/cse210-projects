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
        
    }
}