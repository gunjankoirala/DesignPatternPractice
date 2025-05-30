using System;

class Projector
{
    public void On()
    {
        Console.WriteLine("Projector is ON.");
    }

    public void Off()
    {
        Console.WriteLine("Projector is OFF.");
    }
}

class SoundSystem
{
    public void On()
    {
        Console.WriteLine("Sound system is ON.");
    }

    public void Off()
    {
        Console.WriteLine("Sound system is OFF.");
    }
}

class Lights
{
    public void Dim()
    {
        Console.WriteLine("Lights are DIMMED.");
    }

    public void On()
    {
        Console.WriteLine("Lights are ON.");
    }
}


class HomeTheaterFacade
{
    private Projector projector;
    private SoundSystem soundSystem;
    private Lights lights;

    public HomeTheaterFacade(Projector projector, SoundSystem soundSystem, Lights lights)
    {
        this.projector = projector;
        this.soundSystem = soundSystem;
        this.lights = lights;
    }

    public void WatchMovie()
    {
        Console.WriteLine("\nGet ready to watch a movie...");
        lights.Dim();
        projector.On();
        soundSystem.On();
    }

    public void EndMovie()
    {
        Console.WriteLine("\nShutting down the theater...");
        soundSystem.Off();
        projector.Off();
        lights.On();
    }
}


class Program
{
    static void Main(string[] args)
    {
        Projector projector = new Projector();
        SoundSystem soundSystem = new SoundSystem();
        Lights lights = new Lights();

        HomeTheaterFacade homeTheater = new HomeTheaterFacade(projector, soundSystem, lights);

        homeTheater.WatchMovie();
        homeTheater.EndMovie();
    }
}

