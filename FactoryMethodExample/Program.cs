var notification = new EmailNotificationCreator().CreateNotification();
notification.Send("Seu pedido foi enviado.");

interface INotification
{
    void Send(string message);
}

sealed class EmailNotification : INotification
{
    public void Send(string message) => Console.WriteLine($"E-mail: {message}");
}

abstract class NotificationCreator
{
    public abstract INotification CreateNotification();
}

sealed class EmailNotificationCreator : NotificationCreator
{
    public override INotification CreateNotification() => new EmailNotification();
}
