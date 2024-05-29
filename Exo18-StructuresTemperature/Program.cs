Celsius tempBruxelles;
tempBruxelles.temperature = 13;

Console.WriteLine($"Aujourd'hui à Bruxelles, il fait {tempBruxelles.temperature}°C.");

Fahrenheit tempNewYork;
tempNewYork.temperature = 64;

Console.WriteLine($"Aujourd'hui à New York, il fait {tempNewYork.temperature}°F.");

public struct Celsius
{
    public double temperature;
}

public struct Fahrenheit
{
    public double temperature;
}