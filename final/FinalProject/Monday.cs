public class Monday : Studies

{
    private string _funds;
    
    public Monday(string funds, string scripture, string standardStartingMessage ) : base (standardStartingMessage, scripture)
    {
        _funds = funds;
        
    }
    public string GetFunds()
    {
        return _funds;
    }
    public override string GetSummary()
    {
        return _funds;
    }
}
