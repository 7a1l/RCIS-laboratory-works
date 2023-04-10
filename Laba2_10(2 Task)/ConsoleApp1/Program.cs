using System;
using Laba2_10;

class RCIS
{
    static void Main()
    {
        Triangle triangle = new Triangle { FirstSide = new Side(6, 0, 1), SecondSide = new Side(6, 1, 1), ThirdSide = new Side(2, 1, 0) };
      while (true)
        {
            Console.WriteLine("1 - Perimeter\n2 - Square\n3 - Median point\nOther number - finish");
            int op = int.Parse(Console.ReadLine()!);
            switch (op)
            {
                case 1:
                    Console.WriteLine(triangle.Perimeter());
                    break;
                case 2:
                    Console.WriteLine(triangle.Square());
                    break;
                case 3:
                    (double, double) med = triangle.MedianPoint();
                    Console.WriteLine($"X - {med.Item1} Y - {med.Item2}");
                    break;
                default:
                    return;
            }
        }
    }
}