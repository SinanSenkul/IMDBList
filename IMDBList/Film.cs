using System;

public class Film
{
    public string Name { get; set; }
    public int Pts { get; set; }
    public Film(string name, int pts)
    {
        Name = name; Pts = pts;
    }
}
