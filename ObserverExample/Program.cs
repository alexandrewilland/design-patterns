var weatherStation = new WeatherStation();
weatherStation.Subscribe(new PhoneDisplay("Celular"));
weatherStation.Subscribe(new PhoneDisplay("Tablet"));
weatherStation.SetTemperature(25);

interface IObserver
{
    void Update(int temperature);
}

sealed class WeatherStation
{
    private readonly List<IObserver> observers = [];

    public void Subscribe(IObserver observer) => observers.Add(observer);

    public void SetTemperature(int temperature)
    {
        Console.WriteLine($"Temperatura atualizada para {temperature}°C.");
        foreach (var observer in observers)
        {
            observer.Update(temperature);
        }
    }
}

sealed class PhoneDisplay : IObserver
{
    private readonly string name;

    public PhoneDisplay(string name) => this.name = name;

    public void Update(int temperature) => Console.WriteLine($"{name}: exibindo {temperature}°C.");
}
