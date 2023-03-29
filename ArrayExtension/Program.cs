/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте в программу, в которой создайте статический класс, в теле которого создайте
расширяющий метод, который будет сортировать элементы целочисленного массива по
возрастанию. Также в теле класса создайте метод, который будет создавать массив
целочисленных элементов, и заполнять его случайными значениями элементов, длина массива –
параметр метода. В методе Main() с помощью метода описанного выше создайте массив
целочисленных элементов размерностью 10 элементов, выведите значение всех элементов
массива на консоль, далее с помощью расширяющего метода отсортируйте массив, и
отсортированный массив снова выведите на консоль.
*/

int[] array = new int[10];

ArrayOpertaion.ArrayDefine(array);
Console.WriteLine("Массив чисел:");
foreach (var item in array)
{
    Console.Write(item + " ");
}

Console.WriteLine();

array.ArrayExtension();
Console.WriteLine("Отсортированный массив чисел:");
foreach (var item in array)
{
    Console.Write(item + " ");
}

Console.ReadKey();
static class ArrayOpertaion
{
    public static void ArrayDefine(int[] array)
    {
        Random random = new();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1,50);
        }
    }
    public static void ArrayExtension(this int[] array)
    {
        //Array.Sort(array);
        int temp;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] < array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }
}