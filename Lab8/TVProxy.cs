using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class TVProxy : ITV
    {
        private ITV tv;

        public TVProxy(ITV tv)
        {
            this.tv = tv;
        }

        public void getInfo()
        {
            Console.WriteLine("Type: " + this.getTVType());
            Console.WriteLine("Price: $" + this.getPrice());
        }

        internal int getPrice()
        {
            return this.tv.getPrice();
        }

        internal void setPrice(int price)
        {
            this.tv.setPrice(price);
        }

        internal string getTVType()
        {
            this.tv.getTVType();
        }

        internal void setType(string tvType)
        {
            this.tv.setType(tvType);
        }

        internal string getBrand()
        {
            return this.tv.getBrand();
        }

        internal void setBrand(string brand)
        {
            this.setBrand(brand);
        }

    }
}
