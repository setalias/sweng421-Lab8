using System;

namespace Lab8
{
    class Retailer
    {
        static void Main(string[] args)
        {
            ITV tv = new TVProxy();
            tv.replenishTV(150).getInfo();


        }
    }
}



