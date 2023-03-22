public class Thursday : Studies
{
    private string _sacrifice;
    public Thursday(string standardStartingMessage, string scripture, string sacrifice) : base (standardStartingMessage, sacrifice)
    {
        _sacrifice = sacrifice;

    }
    public override string GetSummary()
    {
        return _sacrifice;
    }
}