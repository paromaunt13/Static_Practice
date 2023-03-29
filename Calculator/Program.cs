/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, в которой создайте статический класс Calculator (калькулятор). В классе
создайте методы для выполнения основных арифметических операций. Реализуйте возможность
работы пользователя, через ввод данных с помощью клавиатуры и отображение результат на
экран.
*/
Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите знак арифметической операции:");
string sign = Console.ReadLine();

switch (sign)
{
    case "+":
        Calculator.Add(a, b);
        break;
    case "-":
        Calculator.Subtract(a, b);
        break;
    case "/":
        Calculator.Divide(a, b);
        break;
    case "*":
        Calculator.Multiply(a, b);
        break;
    default: Console.WriteLine("Операция не определена");
        break;
}

Console.ReadKey();
static class Calculator
{
    static public void Add(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine($"{a} + {b} = {sum}");
    }
    static public void Subtract(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine($"{a} - {b} = {sum}");
    }
    static public void Divide(int a, int b)
    {
        float sum = (float)a / b;
        Console.WriteLine($"{a} / {b} = {sum}");
    }
    static public void Multiply(int a, int b)
    {
        int sum = a * b;
        Console.WriteLine($"{a} * {b} = {sum}");
    }
}