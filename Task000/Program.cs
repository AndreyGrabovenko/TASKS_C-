//  0. Вывести квадрат числа

public class Program
{
    public static void Main()
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int square = number * number;
        Console.WriteLine("Квадрат числа {0} равен {1}", number, square);
    }
}