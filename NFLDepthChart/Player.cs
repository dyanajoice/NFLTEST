public class Player
{
    public int Number { get; }
    public string Name { get; }
    public int PositionDepth { get; set; } 
    public Player(int number, string name)
    {
        Number = number;
        Name = name;
        PositionDepth = 0; 
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        Player other = (Player)obj;
        return Number == other.Number && Name == other.Name;
    }

    public override int GetHashCode()
    {
        return Number.GetHashCode() ^ Name.GetHashCode();
    }

    public override string ToString()
    {
        return $"#{Number}, {Name}";
    }
}
