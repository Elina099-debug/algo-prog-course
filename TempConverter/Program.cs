double celsius = 23.5;
const double FahrenheitOffset = 32;
const double FahrenheitRatio = 9.0 / 5.0;
const double KelvinOffset = 273.15;
double fahrenheit = celsius * FahrenheitRatio + FahrenheitOffset;
double kelvin = celsius + KelvinOffset;

Console.WriteLine($"{celsius}°C = {fahrenheit:F1}°F = {kelvin:F2}K");