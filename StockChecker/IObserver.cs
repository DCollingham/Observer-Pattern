using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockChecker
{
    interface IObserver
    {
        /*The observable calls this update on all the
         observers when a change has taken place*/
        void Update(int PS5Stock, int XboxStock);
    }
}
