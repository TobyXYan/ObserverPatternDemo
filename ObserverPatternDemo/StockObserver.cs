using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternDemo
{
    public class StockObserver : IObserver
    {
        private double _ibmPrice;
        private double _applePrice;
        private double _googlePrice;

        private static int _observerIDTracker = 0;

        private int _observerID;

        private ISubject _stockGrabber;

        public StockObserver(ISubject stockGrabber)
        {
            _stockGrabber = stockGrabber;
            _observerID = ++_observerIDTracker;
            _stockGrabber.Register(this);
        }

        public void Update(double ibmPrice, double applePrice, double googlePrice)
        {
            _ibmPrice    = ibmPrice;
            _applePrice  = applePrice;
            _googlePrice = googlePrice;
            Console.WriteLine($"IBM Price: {_ibmPrice}\n Apple Price: {_applePrice}\n Google Price: {_googlePrice}\n");
        }
    }
}
