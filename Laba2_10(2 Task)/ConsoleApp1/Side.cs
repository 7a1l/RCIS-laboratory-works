namespace Laba2_10;

public class Side
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Length { get; set; }

    public Side(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }
    
    public Side(int length)
    {
        this.Length = length;
    }
    
    public Side(int length, int x, int y)
    {
        Length = length;
        X = x;
        Y = y;
    }
}