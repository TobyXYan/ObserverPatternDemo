using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternDemo
{
    public interface IObserver
    {
        public void Update(double ibmPrice, double applePrice, double googlePrice);
    }
}
