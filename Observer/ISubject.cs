public interface ISubject
{
    void Attach(IObserver observer);  // подписка
    void Detach(IObserver observer);  // отписка
    void Notify(string stock, decimal price); // оповещение
}
