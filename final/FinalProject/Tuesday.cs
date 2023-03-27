public class Tuesday : Studies
{
    private string _obedience;
    
    public Tuesday(string obedience, string scripture, string record) : base (record, scripture)
        {
            _obedience = obedience;
        }
    public string GetObedience()
    {
        return _obedience;
    }
    public override string GetSummary()
    {
        return _obedience;
    }
}