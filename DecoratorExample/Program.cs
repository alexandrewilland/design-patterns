IMessage message = new TimestampDecorator(new BasicMessage("Olá, mundo!"));
Console.WriteLine(message.GetContent());

interface IMessage
{
    string GetContent();
}

sealed class BasicMessage : IMessage
{
    private readonly string content;

    public BasicMessage(string content) => this.content = content;

    public string GetContent() => content;
}

abstract class MessageDecorator : IMessage
{
    protected readonly IMessage Message;

    protected MessageDecorator(IMessage message) => Message = message;

    public abstract string GetContent();
}

sealed class TimestampDecorator : MessageDecorator
{
    public TimestampDecorator(IMessage message) : base(message)
    {
    }

    public override string GetContent() => $"[{DateTime.Now:HH:mm}] {Message.GetContent()}";
}
