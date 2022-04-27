using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockChecker
{
    //Concrete Observable implements Observable interface
    class OnlineStore : IObservable
    {
        /*PS5 & Xbox stock variables are being tracked.
        Variables don't use standard camel casing as 
        they are easier to read like this*/
        private int _PS5Stock;
        private int _XboxStock;
        //List of observers. Used later for updating.
        private readonly List<IObserver> _observers;
        public string Name { get; set; }


        //Constructor assigning instance variable to list
        public OnlineStore(string storeName)
        {
            _observers = new List<IObserver>();
            Name = storeName;
        }

        //Adds observer to list of observers
        public void AddSubscriber(IObserver subscriber)
        {
            _observers.Add(subscriber);
        }

        //Removes observer from list of observers
        public void RemoveSubscriber(IObserver subscriber)
        {
            _observers.Remove(subscriber);
        }

        /*Iterates through list of observers and calls
        Update method. Called after stock is changed*/ 
        public void Notify()
        {
            foreach(IObserver sub in _observers)
            {
                sub.Update(_PS5Stock, _XboxStock);
            }
        }
        //Sets stock and calls Notify
        public void SetStock(int PS5Stock, int XboxStock)
        {
            _PS5Stock = PS5Stock;
            _XboxStock = XboxStock;
            Notify();
        }
    }
}
