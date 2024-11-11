using System;

class Program
{
    static void Main(string[] args)
    {
        // Виводимо запит на введення мінімального значення x
        Console.WriteLine("Введіть мінімальне значення x (xmin):");
        string sxMin = Console.ReadLine();

        // Виводимо запит на введення максимального значення x
        Console.WriteLine("Введіть максимальне значення x (xmax):");
        string sxMax = Console.ReadLine();

        // Виводимо запит на введення кроку зміни x
        Console.WriteLine("Введіть крок зміни x (dx):");
        string sdx = Console.ReadLine();

        // Конвертуємо введені рядкові значення у тип double
        double xMin = double.Parse(sxMin);
        double xMax = double.Parse(sxMax);
        double dx = double.Parse(sdx);

        // Встановлюємо початкове значення x рівним мінімальному значенню
        double x = xMin;

        // Змінна для зберігання суми значень f(x)
        double sum = 0;

        // Цикл while працює, поки x не перевищує максимальне значення
        while (x <= xMax)
        {
            // Обчислюємо значення функції за заданою формулою
            double y = (Math.Pow(Math.Sin(x), 3) + 45 + 3 * x) / (2 * Math.Pow(x, 4) + 12 * x);
            
            // Виводимо поточні значення x та y
            Console.WriteLine("x = {0}\t\t y = {1}", x, y);

            // Додаємо y до суми для обчислення суми всіх значень
            sum += y;

            // Збільшуємо x на величину кроку dx
            x += dx;
        }

        // Перевіряємо, чи потрібно вивести значення для xmax, якщо цикл зупинився трохи раніше
        if (Math.Abs(x - xMax + dx) < 0.0001)
        {
            double yMax = (Math.Pow(Math.Sin(xMax), 3) + 45 + 3 * xMax) / (2 * Math.Pow(xMax, 4) + 12 * xMax);
            Console.WriteLine("x = {0}\t\t y = {1}", xMax, yMax);
            sum += yMax; // Додаємо y для xmax до загальної суми
        }

        // Виводимо суму всіх розрахованих значень
        Console.WriteLine("Сума всіх розрахованих значень f(x): {0}", sum);

        // Виводимо повідомлення про завершення роботи програми
        Console.WriteLine("Натисніть будь-яку клавішу для виходу...");
        Console.ReadKey();
    }
}
