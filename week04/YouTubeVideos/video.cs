using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _videoLength;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _videoLength = length;
    }

    public void AddComments(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberofComments()
    {
        return _comments.Count;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetVideoLength()
    {
        return _videoLength;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}
