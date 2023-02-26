using System;
public class ListingActivity : Activity
{
    private string _randomListing = "";
    public ListingActivity(string startingMessage, string endMessage, string showAnimation, string randomListing)
    : base(startingMessage,showAnimation, endMessage)
    {
        _randomListing = randomListing;
    }
    public string GetList()
    {
        return $"{_randomListing}";
    }
    
}