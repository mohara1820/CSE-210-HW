using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;


public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LenghtInSeconds {get; set; }
    private List<Comment> _comments;


    public Video(string title, string author, int lenghtInSeconds)
    {
        Title = title;
        Author = author;
        LenghtInSeconds = lenghtInSeconds;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public List<Comment> GetComment()
    {
        return _comments;
    }
}