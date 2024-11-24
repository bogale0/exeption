try
{
    Console.WriteLine("Введите целое число");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"5 / {x} = {5 / x}");

    int[] arr = { 5, -3, 9 };
    Console.WriteLine("Введите индекс");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Число с индексом \"{i}\": {arr[i]}");
}
catch (DivideByZeroException)
{
    Console.WriteLine($"Деление на 0!");
}
catch (FormatException)
{
    Console.WriteLine("Неправильный формат ввода!");
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine($"Индекс за пределами массива!");
}
catch (Exception ex)
{
    Console.WriteLine($"Непредвиденная ошибка. Сообщение: {ex.Message}\nМетод: {ex.TargetSite}");
}
finally
{
    Console.WriteLine($"try-catch-finally блок завершён");
}