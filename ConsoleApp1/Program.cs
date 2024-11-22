try
{
    int x = 5;
    int y = 0;
    int z = x / y;
} catch (DivideByZeroException ex)
{
    Console.WriteLine($"Сообщение: {ex.Message}\nМетод: {ex.TargetSite}");
}