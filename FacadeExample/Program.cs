var homeTheater = new HomeTheaterFacade(new Projector(), new SoundSystem());
homeTheater.WatchMovie("O padrão Facade");

sealed class Projector
{
    public void TurnOn() => Console.WriteLine("Projetor ligado.");
    public void Show(string movie) => Console.WriteLine($"Exibindo: {movie}");
}

sealed class SoundSystem
{
    public void TurnOn() => Console.WriteLine("Som ligado.");
    public void SetVolume(int volume) => Console.WriteLine($"Volume definido como {volume}.");
}

sealed class HomeTheaterFacade
{
    private readonly Projector projector;
    private readonly SoundSystem soundSystem;

    public HomeTheaterFacade(Projector projector, SoundSystem soundSystem)
    {
        this.projector = projector;
        this.soundSystem = soundSystem;
    }

    public void WatchMovie(string movie)
    {
        projector.TurnOn();
        soundSystem.TurnOn();
        soundSystem.SetVolume(10);
        projector.Show(movie);
    }
}
