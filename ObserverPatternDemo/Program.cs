using System;

namespace ObserverPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var stockGrabber = new StockGrabber();
            var observer1    = new StockObserver(stockGrabber);
            stockGrabber.SetIBMPrice(197.00);
            stockGrabber.SetApplePrice(677.60);
            stockGrabber.SetGooglePrice(676.40);

            var observer2 = new StockObserver(stockGrabber);
            stockGrabber.SetIBMPrice(197.00);
            stockGrabber.SetApplePrice(677.60);
            stockGrabber.SetGooglePrice(676.40);

            stockGrabber.Unregister(observer1);
            stockGrabber.SetIBMPrice(197.00);
            stockGrabber.SetApplePrice(677.60);
            stockGrabber.SetGooglePrice(676.40);

            Console.ReadLine();
        }
    }
}
