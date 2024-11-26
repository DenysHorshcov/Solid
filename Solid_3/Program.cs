using System;

// Базовий інтерфейс
interface IShape
{
    int GetArea();
}

// Прямокутник
class Rectangle : IShape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public int GetArea()
    {
        return Width * Height;
    }
}

// Квадрат
class Square : IShape
{
    public int SideLength { get; set; }

    public int GetArea()
    {
        return SideLength * SideLength;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle { Width = 5, Height = 10 };
        Console.WriteLine("Rectangle area: " + rect.GetArea()); // Виведе 50

        Square square = new Square { SideLength = 5 };
        Console.WriteLine("Square area: " + square.GetArea()); // Виведе 25

        Console.ReadKey();
    }
}
