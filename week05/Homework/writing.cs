public class Writing : Assignment
{
    private string _title = "";

// creating a getter for the title. 
    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    // public Writing(string title, string studentName, string topic) : base(studentName, topic)
    // {
    //     _title = title;
    // }
    

    public string GetWritingList()
    {
        return $"{_title} by {_studentName}";
    }
}