using System;

public class Trader : IObserver
{
    private readonly string _name;

    public Trader(string name)
    {
        _name = name;
    }

    public void Update(string stock, decimal price)
    {
        Console.WriteLine($"[Trader {_name}] получил обновление: {stock} - {price:C}");
        if (price < 100)
        {
            Console.WriteLine($"[Trader {_name}] Покупаю акции {stock}, так как цена ниже 100!");
        }
    }
}
