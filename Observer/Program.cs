using System;

class Program
{
    static void Main()
    {
        StockMarket stockMarket = new StockMarket();

        Trader trader1 = new Trader("Алексей");
        Trader trader2 = new Trader("Мария");
        Broker broker1 = new Broker("Олег");

        // подписка наблюдателей
        stockMarket.Attach(trader1);
        stockMarket.Attach(trader2);
        stockMarket.Attach(broker1);

        // смена цены акций
        stockMarket.UpdateStockPrice("AAPL", 95);
        stockMarket.UpdateStockPrice("MSFT", 160);

        // откл. одного трейдера
        stockMarket.Detach(trader2);

        // еще одна смена цены
        stockMarket.UpdateStockPrice("AAPL", 105);
    }
}
