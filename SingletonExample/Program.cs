var firstLogger = Logger.Instance;
var secondLogger = Logger.Instance;

firstLogger.Log("Aplicação iniciada.");
Console.WriteLine($"As duas variáveis apontam para a mesma instância? {ReferenceEquals(firstLogger, secondLogger)}");

sealed class Logger
{
    private static readonly Lazy<Logger> LazyInstance = new(() => new Logger());

    private Logger()
    {
    }

    public static Logger Instance => LazyInstance.Value;

    public void Log(string message) => Console.WriteLine($"[LOG] {message}");
}
