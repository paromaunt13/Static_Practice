/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, в которой создайте статический класс Convector (конвектор). В теле класса
Convector создайте два статических метода, первый CelsiusToFahrenheit (string temperatureCelsius)
, который конвертирует значение температуры в Цельсиях в Фаренгейты, и второй
FahrenheitToCelsius (string temperatureFahrenheit), который конвертирует значение температуры в
Фаренгейтах в значение температуры в Цельсиях. Организуйте возможность взаимодействия
пользователя с программой.
*/

Console.WriteLine("Выберите тип конвертации величины температуры:");
Console.WriteLine("1. Из шкалы Цельсия в шкалу Фаренгейта");
Console.WriteLine("2. Из шкалы Фаренгейта в шкалу Цельсия");
int operation = int.Parse(Console.ReadLine());

Console.WriteLine("Введите величину температуры:");
int temperature = int.Parse(Console.ReadLine());

switch (operation)
{
    case 1:
        Converter.CelsiusToFahrenheit(temperature);
        break;
    case 2:
        Converter.FahrenheitToCelsius(temperature);
        break;
    default: Console.WriteLine("Операция не определена");
        break;
}

Console.ReadKey();
static class Converter
{
    static public void CelsiusToFahrenheit(int temperatureCelsius)
    {
        float farenheit = temperatureCelsius * 9 / 5 + 32;
        Console.WriteLine($"Температура по шкале Фаренгейта - {farenheit}*F");
    }
    static public void FahrenheitToCelsius(int temperatureFahrenheit)
    {
        float celsius = (temperatureFahrenheit - 32) * 5 / 9;
        Console.WriteLine($"Температура по шкале Цельсия - {celsius}*С");
    }
}