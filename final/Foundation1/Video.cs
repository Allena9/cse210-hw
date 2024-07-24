using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = [];
    }

    public void AddComment(string name, string text)
    {
        Comment com = new Comment(name, text);

        _comments.Add(com);
    }

    public int ReturnCommentAmount()
    {
        return _comments.Count();
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}, Author: {_author}, {_length} seconds, Number of comments: {ReturnCommentAmount()}");
        foreach(Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetName()}, {comment.GetText()}");
        }
    }
}