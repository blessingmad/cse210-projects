public class Suturday : Studies
{
    private string _temple;
    public Suturday(string record, string scripture, string temple) : base (record, scripture)
    {
        _temple = temple;
    }
    public override string GetSummary()
    {
        return _temple;
    }
}