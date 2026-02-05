public class Assignment
{
    protected string _studentName;
    protected string _topic;

    public string GetstudentName()
    {
        return _studentName;
    
    }
    public void SetstudentName(string studentName)
    {
         _studentName = studentName;
    }
    public string Gettopic()
    {
        return _topic;
    }
    public void settopic(string topic)
    {
         _topic = topic;
    }
    public string GetSummary()
    {
        return $"{_topic} by {_studentName}";
    }

} 