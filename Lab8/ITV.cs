using System;

namespace Lab8
{
    public interface ITV
    {

        public TV replenishTV(int budget);

        public void getInfo();

        internal int getPrice();

        internal void setPrice(int price);

        internal string getTVType();

        internal void setType(string tvType);

        internal string getBrand();

        internal void setBrand(string brand);

    }
}
