namespace Laba2_10;

public class Triangle
{
    public Side FirstSide { get; set; }
    
    public Side SecondSide { get; set; }
    public Side ThirdSide { get; set; }

    public int Perimeter()
    {
        return (this.FirstSide.Length + this.SecondSide.Length + this.ThirdSide.Length) / 2;
    }

    public double Square()
    {
        double p = (Perimeter() / 2);
        return Math.Sqrt(p * (p - FirstSide.Length) * (p - SecondSide.Length) * (p - ThirdSide.Length));
    }

    public (double, double) MedianPoint()
    {
        double x = (SecondSide.X + FirstSide.X + ThirdSide.X) / 3;
        double y = (SecondSide.Y + FirstSide.Y + ThirdSide.Y) / 3;
        return (x, y);
    }
}