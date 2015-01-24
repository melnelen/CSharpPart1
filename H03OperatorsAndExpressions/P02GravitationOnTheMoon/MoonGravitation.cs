using System;

// The gravitational field of the Moon is approximately 17% of that on the Earth.
// Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

class MoonGravitation
{
    static void Main(string[] args)
    {
        float weightOnEarth = 53.7F;
        float weightOnMoon = (weightOnEarth * 17) / 100;
        Console.WriteLine("Your weight on the Moon will be {0:F2}", weightOnMoon);
    }
}
