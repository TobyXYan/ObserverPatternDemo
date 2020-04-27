using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternDemo
{
    public class StockGrabber : ISubject
    {
        private double _ibmPrice;
        private double _applePrice;
        private double _googlePrice;
        private List<IObserver> _observers;

        public StockGrabber()
        {
            _observers = new List<IObserver>();
        }

        public void NotifyObserver()
        {
            foreach (var observer in _observers)
                observer.Update(_ibmPrice,_applePrice,_googlePrice);
        }

        public void Register(IObserver o)
        {
            if (_observers.Contains(o))
                return;
            _observers.Add(o);
        }

        public void Unregister(IObserver o)
        {
            _observers.Remove(o);
        }

        public void SetIBMPrice(double ibmPrice)
        {
            _ibmPrice = ibmPrice;
            NotifyObserver();
        }

        public void SetApplePrice(double applePrice)
        {
            _applePrice = applePrice;
            NotifyObserver();
        }

        public void SetGooglePrice(double googlePrice)
        {
            _googlePrice = googlePrice;
            NotifyObserver();
        }
    }
}
