public class Wednesday : Studies
{
    private string _faith;
    public Wednesday(string standardStartingMessage, string scripture, string faith) : base (standardStartingMessage, scripture)
    {
        _faith = faith;
    }
     public string GetFaith()
     {
        return _faith;
     }
    public override string GetSummary()
    {
        return _faith;
    }
}