using System;

public class NeighborhoodModel
{
    public int CodNeighborHood { get; set; }
    public string NameNeighborhood { get; set; }
    public NeighborhoodModel(int cod,string name)
    {
        CodNeighborHood = cod;
        NameNeighborhood = name;
    }

    public NeighborhoodModel()
    {
    }
}
