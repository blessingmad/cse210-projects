public class Sunday : Studies
{
    private string _share;
    public Sunday(string standardStartingMessage, string scripture, string share) : base (standardStartingMessage, scripture)
    {
        _share = share;
    }
    public override string GetSummary()
    {
        return _share;
    }
}