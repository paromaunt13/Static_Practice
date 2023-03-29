/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, в которой создайте статический класс StringExtension (длина строки), в теле
класса создайте расширяющий метод StrCount который будет осуществлять подсчёт количество
элементов в строке. Возвращаемое значение метода должно быть типа int, на вход необходимо
принимать два аргумента, 1-й сама строка, 2-й символ начиная с которого будет производится
расчет.
*/
Console.WriteLine("Введите слово:");
string word = Console.ReadLine();

Console.WriteLine("Введите символ, начиная с которого нужно произвести подсчет элементов: ");
char c = char.Parse(Console.ReadLine());

int count = word.StrCount(c);

Console.WriteLine($"Количество элементов, начиная с символа '{c}', равно {count}");

Console.ReadKey();
static class StringExtension
{
    static public int StrCount(this string str, char c)
    {
        int count = 0;
        for (int i = str.IndexOf(c); i < str.Length; i++)
        {
            count++;
        }
        return count;
    }
}
