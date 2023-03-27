public class Thursday : Studies
{
    private string _sacrifice;
    public Thursday(string record, string scripture, string sacrifice) : base (record, sacrifice)
    {
        _sacrifice = sacrifice;

    }
    public override string GetSummary()
    {
        return _sacrifice;
    }
}