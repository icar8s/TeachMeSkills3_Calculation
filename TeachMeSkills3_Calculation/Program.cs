public class Program
{
    public static void Main()
    {
        Console.WriteLine("Привет пользователь!Это онлайн калькутор");
        Console.WriteLine("1. Сложение\n" +
            "2. Вычитание\n" +
            "3. Умножение\n" +
            "4. Деление\n" +
            "5. Процент от числа\n" +
            "6. Квадратный корень числа\n" +
            "7. Выход из программы");
        ChooseOperation();
        Console.WriteLine("Конец программы");
        Console.ReadLine();
    }
public static void ChooseOperation()
    {
        Console.WriteLine("Введите название операции,которую планируете использовать");
        var operation = Console.ReadLine();

        if (operation == "Сложение")
        {
            Console.WriteLine("Введите первое число");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{firstNumber}+{secondNumber}={firstNumber + secondNumber}");
        }
        else if (operation == "Вычитание")
        {
            Console.WriteLine("Введите первое число");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{firstNumber}-{secondNumber}={firstNumber - secondNumber}");
        }
        else if (operation == "Деление")
        {
            Console.WriteLine("Введите первое число");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{firstNumber}/{secondNumber}={firstNumber / secondNumber}");
        }
        else if (operation == "Умножение")
        {
            Console.WriteLine("Введите первое число");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{firstNumber}*{secondNumber}={firstNumber * secondNumber}");
        }
        else if (operation == "Процент от числа")
        {
            Console.WriteLine("Введите число");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите процент");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{secondNumber} процентов от числа {firstNumber} составляет {firstNumber * (secondNumber / 100)}");
        }
        else if (operation == "Квадратный корень")
        {
            Console.WriteLine("Введите число");
            double Number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Квадратный корень числа {Number} составляет {Math.Sqrt(Number)}");
        }
        else if (operation == "Выход из программы")
        {
            Console.WriteLine("Прощайте!");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Некоректный выбор операции.Попробуйте снова");
        }
        }
    }
