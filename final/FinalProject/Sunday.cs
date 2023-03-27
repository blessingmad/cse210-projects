public class Sunday : Studies
{
    private string _share;
    public Sunday(string record, string scripture, string share) : base (record, scripture)
    {
        _share = share;
    }
    public override string GetSummary()
    {
        return _share;
    }
}