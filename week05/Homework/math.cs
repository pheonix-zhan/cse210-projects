public class Math : Assignment
{
    private string _textbookSection = "";
    private string _problem = "";

    public string GettextbookSection()
    {
        return _textbookSection;
    }
    public void SettextbookSection(string textbookSection)
    {
        _textbookSection = textbookSection;
    }

    public string GetProblem()
    {
        return _problem;
    }

    public void SetProblem(string problem)
    {
        _problem = problem;
    }

    public Math( string studentName, string topic, string textbookSection, string problem) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problem = problem;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection}, Problem{_problem}";
    }
}