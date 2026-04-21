using System;

public class Car
{
    private Engine engine;
    public string Model { get; set; }

    public Car(string model, string engineType)
    {
        Model = model;
        engine = new Engine(engineType);
    }

    public void Drive()
    {
        engine.Start();
        Console.WriteLine("Авто рухається: " + Model);
    }
}