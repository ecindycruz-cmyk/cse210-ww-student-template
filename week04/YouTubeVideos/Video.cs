using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments;

    public Video(string Title, string Author, int Length)
    {
        _title = Title;
        _author = Author;
        _lengthInSeconds = Length;
        _comments = new List<Comment>();
    }
    //Getters of title, Author, Length and comments
    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _lengthInSeconds;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

    //Setters of title, Author, Length and comments.
    public void SetTitle(string Title)
    {
        _title = Title;
    }

    public void SetAuthor(string Author)
    {
        _author = Author;
    }

    public void SetLength(int Length)
    {
        _lengthInSeconds = Length;
    }
    //Method to Add comments.

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    //Method to get the number of the comments.
    public int GetNumberComments()
    {
        return _comments.Count;
    }

}