using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockChecker
{
    //Subject. More than one interface can be implemented
    interface IObservable
    {
        /* Add & Remove to be used 
         to add/remove observers from list*/

        //Add observer
        void AddSubscriber (IObserver subscriber);
        //Remove observer
        void RemoveSubscriber(IObserver subscriber);
        //Called when a concrete observable has changed
        void Notify();
        /*Name of the store. Used to differentiate
         Between different stores*/
        public string Name { get; set; }
    }
}
