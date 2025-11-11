using System;

// Прототип
public abstract class Shape
{
    public string Color { get; set; }
    public Shape(string color) { Color = color; }

    public abstract Shape Clone();
    public abstract void Display();
}

// Конкретний прототип
public class Circle : Shape
{
    public int Radius { get; set; }
    public Circle(string color, int radius) : base(color) { Radius = radius; }

    public override Shape Clone()
    {
        return new Circle(this.Color, this.Radius);
    }

    public override void Display()
    {
        Console.WriteLine($"Коло: колір={Color}, радіус={Radius}");
    }
}

// Клієнт
class Program
{
    static void Main()
    {
        Circle original = new Circle("Червоний", 10);
        original.Display();

        Circle clone = (Circle)original.Clone();
        clone.Color = "Синій";
        clone.Display();
    }
}
