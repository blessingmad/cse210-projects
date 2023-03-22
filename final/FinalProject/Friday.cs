public class Friday : Studies
{
    private string _sabbathDay;
    public Friday (string standardStartingMessage, string scripture, string sabbathDay) : base (standardStartingMessage, scripture)
    {
        _sabbathDay = sabbathDay;
    }
    public override string GetSummary()
    {
        return _sabbathDay;
    }

}