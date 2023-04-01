public class Friday : Studies
{
    private string _sabbathDay;
    public Friday (string record, string scripture, string sabbathDay) : base (record, scripture)
    {
        _sabbathDay = sabbathDay;
    }
    public override string GetSummary()
    {
        return _sabbathDay;
    }

}