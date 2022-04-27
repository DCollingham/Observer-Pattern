using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockChecker
{
    //Concrete observer
    class MobileUser : IObserver
    {
        //Stock variables
        private int _PS5Stock;
        private int _XboxStock;
        //Observable. Can only be changed during initialisation
        private readonly IObservable _onlineStore;

        /*Constructor takes observable as an arguement.
        This allows the concrete observable to add the concrete
        observer to the list of observers */
        public MobileUser(IObservable onlineStore)
        {
            _onlineStore = onlineStore;
            /*Calls add subscriber method to add this object
             to list of observers*/
            _onlineStore.AddSubscriber(this);
        }
        //Sets class variables to passed in values
        public void Update(int PS5Stock, int XboxStock)
        {
            _PS5Stock = PS5Stock;
            _XboxStock = XboxStock;
            //Calls display function
            Display();
        }

        //Displays currect stock
        void Display()
        {
            Console.WriteLine($"{_onlineStore.Name}");
            Console.WriteLine($"PS5 Stock: {_PS5Stock} Xbox Stock: {_XboxStock}");
        }
    }
}
