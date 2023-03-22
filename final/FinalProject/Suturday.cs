public class Suturday : Studies
{
    private string _temple;
    public Suturday(string standardStartingMessage, string scripture, string temple) : base (standardStartingMessage, scripture)
    {
        _temple = temple;
    }
    public override string GetSummary()
    {
        return _temple;
    }
}