using System;

namespace StockChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates store object (Observable)
            OnlineStore argus = new OnlineStore("Argus");
            OnlineStore currys = new OnlineStore("Currys");
            OnlineStore amazon = new OnlineStore("Amazon");

            /*Creates mobile user objects. Observable
             object passed in as argument.*/
            MobileUser mobile1 = new MobileUser(argus);
            MobileUser mobile2 = new MobileUser(currys);
            MobileUser mobile3 = new MobileUser(amazon);



            //Sets stock of store objects
            argus.SetStock(4, 6);
            argus.SetStock(1, 1);
            argus.SetStock(22, 6);
            currys.SetStock(2, 2);
            currys.SetStock(3, 3);
            currys.SetStock(11, 12);
            amazon.SetStock(44, 22);
            amazon.SetStock(76, 85);
            amazon.SetStock(75, 84);


            Console.ReadKey();
        }
    }
}
