using System;

/*Даний інтерфейс поганий тим, що він включає занадто багато методів.
 А що, якщо наш клас товарів не може мати знижок або промокодом, або для нього немає сенсу встановлювати матеріал з 
 якого зроблений (наприклад, для книг). Таким чином, щоб не реалізовувати в кожному класі невикористовувані в ньому методи, краще 
розбити інтерфейс на кілька дрібних і кожним конкретним класом реалізовувати потрібні інтерфейси.
Перепишіть, розбивши інтерфейс на декілька інтерфейсів, керуючись принципом розділення інтерфейсу. 
Опишіть класи книжки (розмір та колір не потрібні, але потрібна ціна та знижки) та верхній одяг (колір, розмір, ціна знижка),
які реалізують притаманні їм інтерфейси.*/

interface IPricable
{
    void SetPrice(double price);
}

interface IDiscountable
{
    void ApplyDiscount(string discount);
}

interface IPromocodable
{
    void ApplyPromocode(string promocode);
}

interface ICustomizable
{
    void SetColor(byte color);
    void SetSize(byte size);
}

class Book : IPricable, IDiscountable
{
    private double price;

    public void SetPrice(double price)
    {
        this.price = price;
        Console.WriteLine($"Price for the book set to {price}");
    }

    public void ApplyDiscount(string discount)
    {
        Console.WriteLine($"Applied discount '{discount}' to the book");
    }
}


class Outerwear : IPricable, IDiscountable, ICustomizable
{
    private double price;
    private byte color;
    private byte size;

    public void SetPrice(double price)
    {
        this.price = price;
        Console.WriteLine($"Price for the outerwear set to {price}");
    }

    public void ApplyDiscount(string discount)
    {
        Console.WriteLine($"Applied discount '{discount}' to the outerwear");
    }

    public void SetColor(byte color)
    {
        this.color = color;
        Console.WriteLine($"Color for the outerwear set to {color}");
    }

    public void SetSize(byte size)
    {
        this.size = size;
        Console.WriteLine($"Size for the outerwear set to {size}");
    }
}



class Program
{
    static void Main(string[] args)
    {
        // Робота з книжкою
        Book book = new Book();
        book.SetPrice(200);
        book.ApplyDiscount("10%");

        // Робота з верхнім одягом
        Outerwear jacket = new Outerwear();
        jacket.SetPrice(500);
        jacket.ApplyDiscount("20%");
        jacket.SetColor(1); // Наприклад, 1 - червоний
        jacket.SetSize(42);

        Console.ReadKey();
    }
}