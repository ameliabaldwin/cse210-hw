using System;

public class Listing : Activity
{
    private string[] _promptListing { get; set; }

    public Listing(string[] promptListing, string title, string desc, int duration, int milliseconds)
        : base(duration, desc, title, milliseconds)
    {
        _promptListing = promptListing;
    }

    public string GetRandomListing(Random rnd)
    {
        return _promptListing[rnd.Next(0, _promptListing.Length)];
    }

}
