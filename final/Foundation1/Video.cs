using System;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _commentsList = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int NumberOfComment()
    {
        return _commentsList.Count;
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _commentsList)
        {
            Console.WriteLine(comment.CommentRepresentation());
        }
    }

}