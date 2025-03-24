using System;
using System.Collections.Generic;

public class StockMarket : ISubject
{
    private readonly Dictionary<string, decimal> _stocks = new();
    private readonly List<IObserver> _observers = new();

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify(string stock, decimal price)
    {
        foreach (var observer in _observers)
        {
            observer.Update(stock, price);
        }
    }

    public void UpdateStockPrice(string stock, decimal price)
    {
        _stocks[stock] = price;
        Console.WriteLine($"[StockMarket] Цена {stock} обновлена: {price:C}");
        Notify(stock, price);
    }
}
