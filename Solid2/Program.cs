using System;

//Який принцип S.O.L.I.D. порушено? Виправте!

/*Зверніть увагу на клас EmailSender. Крім того, що за допомогою методу Send, він відправляє повідомлення, 
він ще і вирішує як буде вестися лог. В даному прикладі лог ведеться через консоль.
Якщо трапиться так, що нам доведеться міняти спосіб логування, то ми будемо змушені внести правки в клас EmailSender.
Хоча, здавалося б, ці правки не стосуються відправки повідомлень. Очевидно, EmailSender виконує кілька обов'язків і, 
щоб клас ні прив'язаний тільки до одного способу вести лог, потрібно винести вибір балки з цього класу.*/
class Email
{
    public String Theme { get; set; }
    public String From { get; set; }
    public String To { get; set; }
}

interface ILogger
{
    void Log(string message);
}

class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

class EmailSender
{
    private readonly ILogger _logger;

    public EmailSender(ILogger logger)
    {
        _logger = logger;
    }

    public void Send(Email email)
    {
        // ... sending logic ...
        _logger.Log($"Email from '{email.From}' to '{email.To}' was sent.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ILogger logger = new ConsoleLogger();
        EmailSender emailSender = new EmailSender(logger);

        Email e1 = new Email { From = "Me", To = "Vasya", Theme = "Who are you?" };
        Email e2 = new Email { From = "Vasya", To = "Me", Theme = "vacuum cleaners!" };

        emailSender.Send(e1);
        emailSender.Send(e2);

        Console.ReadKey();
    }
}