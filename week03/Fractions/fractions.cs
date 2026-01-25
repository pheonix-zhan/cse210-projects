public class Fractions
{
    private string _title;
    private int _topNumber;


    private int _bottomNumber;

    public Fractions()
    {
        _title = "";
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fractions(int top)
    {
        _title = "";
        _topNumber = top;
        _bottomNumber = 1;
    }

    public Fractions(int top, int bottom)
    {
        _title = "";
        _topNumber = top;
        _bottomNumber = bottom;
    }

    // public void DisplayFraction()
    // {
    //     Console.WriteLine($"{_topNumber}/{_bottomNumber}");
    // }

    public int GetTopNumber()
    {
        return _topNumber;
    }
    public void SetTopNumber(int topNumber)
    {
        _topNumber = topNumber;
    }
     
    public int GetBottomNumber()
    {
        return _bottomNumber;
    }
    public void SetBottomNumber(int BottomNumber)
    {
        _bottomNumber = BottomNumber;
    }

    public string GetFractionString()
    {
       return $"{_topNumber}/{_bottomNumber}";
    }
    public double GetDecimalValue()
    {
        return(double) _topNumber/_bottomNumber;
    }


}