using System;

public class Broker : IObserver
{
    private readonly string _name;

    public Broker(string name)
    {
        _name = name;
    }

    public void Update(string stock, decimal price)
    {
        Console.WriteLine($"[Broker {_name}] получил обновление: {stock} - {price:C}");
        if (price > 150)
        {
            Console.WriteLine($"[Broker {_name}] Продаю акции {stock}, так как цена выше 150!");
        }
    }
}
