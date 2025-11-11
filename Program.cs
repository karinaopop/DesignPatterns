using System;

// Реалізація (Implementor)
public interface IDrawingAPI
{
    void DrawCircle(double x, double y, double radius);
}

// Конкретні реалізації
public class OpenGLAPI : IDrawingAPI
{
    public void DrawCircle(double x, double y, double radius)
    {
        Console.WriteLine($"OpenGL: Малюю коло в ({x},{y}) з радіусом {radius}");
    }
}

public class DirectXAPI : IDrawingAPI
{
    public void DrawCircle(double x, double y, double radius)
    {
        Console.WriteLine($"DirectX: Малюю коло в ({x},{y}) з радіусом {radius}");
    }
}

// Абстракція
public abstract class Shape
{
    protected IDrawingAPI drawingAPI;

    protected Shape(IDrawingAPI api)
    {
        drawingAPI = api;
    }

    public abstract void Draw();
}

// Конкретна абстракція
public class Circle : Shape
{
    private double x, y, radius;

    public Circle(double x, double y, double radius, IDrawingAPI api) : base(api)
    {
        this.x = x;
        this.y = y;
        this.radius = radius;
    }

    public override void Draw()
    {
        drawingAPI.DrawCircle(x, y, radius);
    }
}

// Клієнт
class Program
{
    static void Main()
    {
        Shape circle1 = new Circle(5, 10, 7, new OpenGLAPI());
        circle1.Draw();

        Shape circle2 = new Circle(15, 20, 10, new DirectXAPI());
        circle2.Draw();
    }
}
