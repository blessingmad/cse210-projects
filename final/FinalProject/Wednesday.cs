public class Wednesday : Studies
{
    private string _faith;
    public Wednesday(string record, string scripture, string faith) : base (record, scripture)
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